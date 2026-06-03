using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System25Config
    {
        public string SystemID { get; set; } = "System25";
        public float Base = 25;
    }

    public class System25 : MonoBehaviour
    {
        public System25Config Config { get; private set; } = new System25Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 25; public void ProcessTick(float dt) { Val += dt * 25; }

        public void Initialize(System25Config config)
        {
            Config = config;
        }
    }
}
