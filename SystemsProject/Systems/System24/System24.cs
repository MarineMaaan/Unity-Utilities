using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System24Config
    {
        public string SystemID { get; set; } = "System24";
        public float Base = 24;
    }

    public class System24 : MonoBehaviour
    {
        public System24Config Config { get; private set; } = new System24Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 24; public void ProcessTick(float dt) { Val += dt * 24; }

        public void Initialize(System24Config config)
        {
            Config = config;
        }
    }
}
