using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System44Config
    {
        public string SystemID { get; set; } = "System44";
        public float Base = 44;
    }

    public class System44 : MonoBehaviour
    {
        public System44Config Config { get; private set; } = new System44Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 44; public void ProcessTick(float dt) { Val += dt * 44; }

        public void Initialize(System44Config config)
        {
            Config = config;
        }
    }
}
