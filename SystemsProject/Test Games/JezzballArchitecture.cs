using System.Collections.Generic;
using UnityEngine;
namespace SystemsProject.TestGames {
    public class JezzballManager : MonoBehaviour {
        public List<BallController> Balls = new List<BallController>();
        public List<WallGenerator> Walls = new List<WallGenerator>();
        public PlayerController Player = new PlayerController();
        public int Score { get; private set; } = 0; public float PlayAreaArea { get; private set; } = 10000f;
        public void InitializeGame() { Score = 0; Balls.Clear(); Walls.Clear(); Player = new PlayerController(); Player.Manager = this;
            Balls.Add(new BallController { position = new Vector2(10, 10), velocity = new Vector2(5, 5) });
            Balls.Add(new BallController { position = new Vector2(50, 50), velocity = new Vector2(-5, -5) });
        }
        public void OnAreaCaptured(float areaCaptured) { PlayAreaArea -= areaCaptured; Score += (int)areaCaptured; }
        public void CheckCollisions() {
            foreach (var wall in Walls) {
                if (!wall.IsBuilding) continue;
                float wx = wall.currentPosition.x;
                float wy = wall.currentPosition.y;
                foreach (var ball in Balls) {
                    float dx = ball.position.x - wx;
                    float dy = ball.position.y - wy;
                    if (dx * dx + dy * dy < 1.0f) { Player.LoseLife(); wall.DestroyWall(); break; }
                }
            }
        }
    }
    public struct Vector2 {
        public float x; public float y; public Vector2(float x, float y) { this.x = x; this.y = y; }
        public static float Distance(Vector2 a, Vector2 b) { float dx = a.x - b.x; float dy = a.y - b.y; return (float)System.Math.Sqrt(dx * dx + dy * dy); }
    }
    public class BallController {
        public Vector2 position; public Vector2 velocity;
        public void UpdatePosition(float dt) { position.x += velocity.x * dt; position.y += velocity.y * dt; }
    }
    public class WallGenerator {
        public bool IsBuilding { get; set; } = false; public Vector2 startPosition; public Vector2 currentPosition; public Vector2 direction;
        public void StartBuilding(Vector2 start, Vector2 dir) { IsBuilding = true; startPosition = start; currentPosition = start; direction = dir; }
        public void UpdateWall(float dt, float speed) { if (!IsBuilding) return; currentPosition.x += direction.x * speed * dt; currentPosition.y += direction.y * speed * dt; }
        public void DestroyWall() { IsBuilding = false; }
    }
    public class PlayerController { public JezzballManager? Manager; public int Lives { get; private set; } = 3; public void LoseLife() { Lives--; } }
}
