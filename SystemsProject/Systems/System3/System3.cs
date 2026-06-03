using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System3Config
    {
        public string SystemID { get; set; } = "System3";
        public float Base = 3;
    }

    public class System3 : MonoBehaviour
    {
        public System3Config Config { get; private set; } = new System3Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 3; public void ProcessTick(float dt) { Val += dt * 3; }

        public void Initialize(System3Config config)
        {
            Config = config;
        }
    }
}
