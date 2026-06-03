using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System46Config
    {
        public string SystemID { get; set; } = "System46";
        public float Base = 46;
    }

    public class System46 : MonoBehaviour
    {
        public System46Config Config { get; private set; } = new System46Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 46; public void ProcessTick(float dt) { Val += dt * 46; }

        public void Initialize(System46Config config)
        {
            Config = config;
        }
    }
}
