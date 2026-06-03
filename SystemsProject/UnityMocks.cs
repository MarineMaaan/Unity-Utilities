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
