using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System95Config
    {
        public string SystemID { get; set; } = "System95";
        public float Base = 95;
    }

    public class System95 : MonoBehaviour
    {
        public System95Config Config { get; private set; } = new System95Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 95; public void ProcessTick(float dt) { Val += dt * 95; }

        public void Initialize(System95Config config)
        {
            Config = config;
        }
    }
}
