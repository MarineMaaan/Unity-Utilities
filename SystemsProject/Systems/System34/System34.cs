using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System34Config
    {
        public string SystemID { get; set; } = "System34";
        public float Base = 34;
    }

    public class System34 : MonoBehaviour
    {
        public System34Config Config { get; private set; } = new System34Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 34; public void ProcessTick(float dt) { Val += dt * 34; }

        public void Initialize(System34Config config)
        {
            Config = config;
        }
    }
}
