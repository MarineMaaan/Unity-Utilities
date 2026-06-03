#!/bin/bash
dotnet new classlib -n SystemsProject
dotnet new xunit -n SystemsTests
dotnet add SystemsTests reference SystemsProject
rm SystemsProject/Class1.cs
rm SystemsTests/UnitTest1.cs
mkdir -p "SystemsProject/Test Games"

cat << 'MOCKS' > SystemsProject/UnityMocks.cs
using System;
using System.Collections.Generic;
namespace UnityEngine {
    public class Object { }
    public class MonoBehaviour : Object {
        public GameObject gameObject { get; set; } = new GameObject();
        public Transform transform { get; set; } = new Transform();
        public virtual void Awake() {} public virtual void Start() {} public virtual void Update() {}
    }
    public class GameObject : Object {
        private static int NextId = 1; public int InstanceId { get; } = NextId++;
        public int GetInstanceID() => InstanceId;
        public Transform transform { get; set; } = new Transform();
    }
    public class Transform {
        public Vector3 position { get; set; } = Vector3.zero;
        public Vector3 rotation { get; set; } = Vector3.zero;
        public Vector3 localScale { get; set; } = Vector3.one;
    }
    public struct Vector3 {
        public float x; public float y; public float z;
        public Vector3(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }
        public static Vector3 zero => new Vector3(0, 0, 0); public static Vector3 one => new Vector3(1, 1, 1);
        public static Vector3 up => new Vector3(0, 1, 0); public static Vector3 right => new Vector3(1, 0, 0);
        public static Vector3 operator +(Vector3 a, Vector3 b) => new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        public static Vector3 operator -(Vector3 a, Vector3 b) => new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        public static Vector3 operator *(Vector3 a, float d) => new Vector3(a.x * d, a.y * d, a.z * d);
        public Vector3 normalized { get { float mag = (float)Math.Sqrt(x * x + y * y + z * z); if (mag == 0) return zero; return new Vector3(x / mag, y / mag, z / mag); } }
        public static float Distance(Vector3 a, Vector3 b) { float dx = a.x - b.x; float dy = a.y - b.y; float dz = a.z - b.z; return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz); }
        public static float Dot(Vector3 lhs, Vector3 rhs) { return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z; }
    }
    public class Time { public static float deltaTime { get; set; } = 0.016f; }
    public class Random { public static float value => 0.5f; }
    public class Mathf { public static float Abs(float f) { return f < 0 ? -f : f; } }
}
namespace UnityEditor {
    public class EditorWindow { public virtual void OnGUI() {} }
    public class EditorStyles { public static string boldLabel = "boldLabel"; }
    public class GUILayout { public static void Label(string text, string style = null) {} }
}
MOCKS

cat << 'JEZZBALL' > "SystemsProject/Test Games/JezzballArchitecture.cs"
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
            foreach (var ball in Balls) {
                foreach (var wall in Walls) {
                    if (wall.IsBuilding) {
                        float dist = Vector2.Distance(ball.position, wall.currentPosition);
                        if (dist < 1.0f) { Player.LoseLife(); wall.DestroyWall(); }
                    }
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
JEZZBALL

cat << 'JEZZTEST' > "SystemsTests/JezzballTests.cs"
using Xunit;
using SystemsProject.TestGames;
namespace SystemsTests {
    public class JezzballTests {
        [Fact] public void JezzballManager_Initialization_SetsUpGame() { var manager = new JezzballManager(); manager.InitializeGame(); Assert.Equal(0, manager.Score); Assert.Equal(2, manager.Balls.Count); Assert.NotNull(manager.Player); Assert.Equal(3, manager.Player.Lives); }
        [Fact] public void Jezzball_WallCollision_ReducesLife() { var manager = new JezzballManager(); manager.InitializeGame(); var wall = new WallGenerator(); wall.StartBuilding(new Vector2(10, 10), new Vector2(1, 0)); manager.Walls.Add(wall); manager.CheckCollisions(); Assert.Equal(2, manager.Player.Lives); Assert.False(wall.IsBuilding); }
    }
}
JEZZTEST

python3 generate_all.py

cat << 'IGNORE' > .gitignore
[Bb]in/
[Oo]bj/
TestResults/
*.log
*.txt
*.cache
*.json
*.targets
*.editorconfig
**/obj/**
**/bin/**
**/TestResults/**
IGNORE
