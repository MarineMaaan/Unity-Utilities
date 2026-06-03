using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System23Config
    {
        public string SystemID { get; set; } = "System23";
        public float Base = 23;
    }

    public class System23 : MonoBehaviour
    {
        public System23Config Config { get; private set; } = new System23Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 23; public void ProcessTick(float dt) { Val += dt * 23; }

        public void Initialize(System23Config config)
        {
            Config = config;
        }
    }
}
