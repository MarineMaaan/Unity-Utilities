using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System8Config
    {
        public string SystemID { get; set; } = "System8";
        public float Base = 8;
    }

    public class System8 : MonoBehaviour
    {
        public System8Config Config { get; private set; } = new System8Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 8; public void ProcessTick(float dt) { Val += dt * 8; }

        public void Initialize(System8Config config)
        {
            Config = config;
        }
    }
}
