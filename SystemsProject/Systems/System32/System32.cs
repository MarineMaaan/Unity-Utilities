using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System32Config
    {
        public string SystemID { get; set; } = "System32";
        public float Base = 32;
    }

    public class System32 : MonoBehaviour
    {
        public System32Config Config { get; private set; } = new System32Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 32; public void ProcessTick(float dt) { Val += dt * 32; }

        public void Initialize(System32Config config)
        {
            Config = config;
        }
    }
}
