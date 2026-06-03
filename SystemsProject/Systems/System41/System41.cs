using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System41Config
    {
        public string SystemID { get; set; } = "System41";
        public float Base = 41;
    }

    public class System41 : MonoBehaviour
    {
        public System41Config Config { get; private set; } = new System41Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 41; public void ProcessTick(float dt) { Val += dt * 41; }

        public void Initialize(System41Config config)
        {
            Config = config;
        }
    }
}
