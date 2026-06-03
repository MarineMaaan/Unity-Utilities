using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System13Config
    {
        public string SystemID { get; set; } = "System13";
        public float Base = 13;
    }

    public class System13 : MonoBehaviour
    {
        public System13Config Config { get; private set; } = new System13Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 13; public void ProcessTick(float dt) { Val += dt * 13; }

        public void Initialize(System13Config config)
        {
            Config = config;
        }
    }
}
