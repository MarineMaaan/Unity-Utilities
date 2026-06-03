using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System15Config
    {
        public string SystemID { get; set; } = "System15";
        public float Base = 15;
    }

    public class System15 : MonoBehaviour
    {
        public System15Config Config { get; private set; } = new System15Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 15; public void ProcessTick(float dt) { Val += dt * 15; }

        public void Initialize(System15Config config)
        {
            Config = config;
        }
    }
}
