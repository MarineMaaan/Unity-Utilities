using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System57Config
    {
        public string SystemID { get; set; } = "System57";
        public float Base = 57;
    }

    public class System57 : MonoBehaviour
    {
        public System57Config Config { get; private set; } = new System57Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 57; public void ProcessTick(float dt) { Val += dt * 57; }

        public void Initialize(System57Config config)
        {
            Config = config;
        }
    }
}
