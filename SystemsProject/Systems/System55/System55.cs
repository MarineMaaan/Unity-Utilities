using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System55Config
    {
        public string SystemID { get; set; } = "System55";
        public float Base = 55;
    }

    public class System55 : MonoBehaviour
    {
        public System55Config Config { get; private set; } = new System55Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 55; public void ProcessTick(float dt) { Val += dt * 55; }

        public void Initialize(System55Config config)
        {
            Config = config;
        }
    }
}
