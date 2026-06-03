using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System58Config
    {
        public string SystemID { get; set; } = "System58";
        public float Base = 58;
    }

    public class System58 : MonoBehaviour
    {
        public System58Config Config { get; private set; } = new System58Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 58; public void ProcessTick(float dt) { Val += dt * 58; }

        public void Initialize(System58Config config)
        {
            Config = config;
        }
    }
}
