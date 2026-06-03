using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System5Config
    {
        public string SystemID { get; set; } = "System5";
        public float Base = 5;
    }

    public class System5 : MonoBehaviour
    {
        public System5Config Config { get; private set; } = new System5Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 5; public void ProcessTick(float dt) { Val += dt * 5; }

        public void Initialize(System5Config config)
        {
            Config = config;
        }
    }
}
