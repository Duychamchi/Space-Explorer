# 🚀 2D Unity Game: Space Explorer

## 🏆 Objectives
- Understand and apply **GameObject management** in Unity.
- Get familiar with essential Components such as **Rigidbody2D**, **Collider2D**, and **SpriteRenderer**.
- Practice **C# scripting** for movement, shooting, and interaction.
- Learn about the **2D collision system** (Collision & Trigger).
- Implement **scene management** (Scenes), **UI**, and **audio integration**.

---

## 🎮 Game Concept
The player controls a spaceship in space, avoiding and destroying asteroids to earn points. The game utilizes fundamental Unity elements such as:
- Movement controls
- Collisions
- Random object spawning
- Score system

---

## 🧩 Game Components

### A. 🛸 Player (Spaceship)
**Unity Concepts Applied:**
- **Transform** – Defines the position, rotation, and scale of the spaceship.
- **Rigidbody2D** – Adds physics for smooth movement.
- **Collider2D** – Detects collisions with asteroids and enemy bullets.
- **Script** – Handles movement, shooting, and health reduction when colliding.

**Functionalities:**
- Move using **W, A, S, D** keys.
- Shoot bullets using the **Spacebar**.
- Lose health when colliding with enemies or asteroids.

---

### B. ☄️ Enemies (Asteroids)
- Randomly spawn from the top of the screen and fall downward.
- Use **Prefabs** to generate multiple asteroids from a template.
- Apply **Collider2D** to detect collisions with bullets and the player.
- Asteroids have health; the player must shoot and maneuver to destroy them.

---

### C. 💥 Bullets
- The player uses bullets to destroy enemies.
- **Script** handles straight movement and self-destruction when leaving the screen.
- Uses **Collider2D (IsTrigger)** to detect collisions.

---

### D. ⭐ Scoring System
- **Stars** randomly appear on the screen.
- When the spaceship collides with a star, the player earns **10 points**.
- Each destroyed asteroid grants **1 point**.
- After collecting a star, it disappears, and the score increases.
- **Game Over** occurs when the player collides with an asteroid.

---

### E. 🕹️ User Interface (UI)
- Displays the game title, background, and buttons for **Start** and **Help**.
- The game includes a **tutorial** to guide the player.
- If the player collides with an enemy, the screen shows:
    - **Score**
    - **Game Over** message
    - **Restart** button

---

## 🌱 Future Improvements

### ⚡ Gameplay Enhancements:
- Add spaceship upgrades: **speed boost**, **shields**, and **stronger weapons**.
- Introduce **boss fights** and diverse **enemy types**.
- Include support items such as **health recovery** and **speed boosts**.

### 💎 UI & Experience Enhancements:
- Improve the **main menu**, **level selection**, and **sound settings**.
- Add side missions like **collecting stars** and **defeating a set number of enemies**.
- Enhance **explosion effects** and **dynamic sound effects**.

---

✨ *Happy Game Developing!* ✨
