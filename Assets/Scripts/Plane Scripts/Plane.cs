﻿using System;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public float planeSpeed;
    public float shootCooldown;

    private Rigidbody2D myBody;

    [SerializeField]
    private GameObject[] bullets;
    private int bulletLevel = 1;
    private float lastShotime;

    private GameObject flame;



    private void Awake()
    {
        // Get the Rigidbody2D component attached to the plane
        myBody = GetComponent<Rigidbody2D>();

        flame = transform.GetChild(0).gameObject;
        flame.SetActive(false);
    }

    void Start()
    {

    }

    void Update()
    {
        PlaneMovement();
        Shoot();
        HandlePause(); // Gọi hàm kiểm tra Pause
    }

    private bool isPaused = false; // Biến kiểm tra trạng thái pause

    private void HandlePause()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Nếu nhấn ESC
        {
            isPaused = !isPaused; // Đảo trạng thái pause

            if (isPaused)
            {
                Time.timeScale = 0; // Dừng game
                Debug.Log("Game Paused");
            }
            else
            {
                Time.timeScale = 1; // Tiếp tục game
                Debug.Log("Game Resumed");
            }
        }
    }


    private void PlaneMovement()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // If the player is moving up, turn on flame
        // Else turn off flame
        if (moveVertical > 0)
        {
            ToggleFlame(true);
        }
        else
        {
            ToggleFlame(false);
        }

        if (moveHorizontal != 0)
        {
            ToggleFlame(true);
            transform.rotation = Quaternion.Euler(0, 0, 180 + -moveHorizontal * 30);
        }

        // Move the plane
        myBody.linearVelocity = movement * planeSpeed;
    }

    private void Shoot()
    {
        // Get the Renderer component attached to the plane
        Renderer renderer = GetComponent<Renderer>();
        // Calculate the height of the plane
        float planeHeight = renderer.bounds.size.y;

        var bulletPos = new Vector3(transform.position.x, transform.position.y + (planeHeight / 2) + 0.1f, 0);

        // Đổi điều kiện bắn từ chuột trái sang phím Space
        if (Input.GetKey(KeyCode.Space) && Time.time >= lastShotime + shootCooldown)
        {
            Instantiate(bullets[Math.Min(bulletLevel, 4) - 1], bulletPos, Quaternion.Euler(0, 0, 180));
            lastShotime = Time.time;
        }
    }


    private void ToggleFlame(bool isActive)
    {
        if (flame.activeSelf != isActive)
        {
            flame.SetActive(isActive);
            //Debug.Log("Flame is active: " + isActive);
        }
    }

    private void UpgradeBullet()
    {

        bulletLevel++;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Upgrade Bullet Item"))
        {
            UpgradeBullet();
            Destroy(other.gameObject);
        }
    }

    public int GetBulletLevel()
    {
        return bulletLevel;
    }

    public void SetBulletLevel(int level)
    {
        bulletLevel = level;
    }




}
