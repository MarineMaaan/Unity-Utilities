using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System72Config
    {
        public string SystemID { get; set; } = "System72";
        public float Base = 72;
    }

    public class System72 : MonoBehaviour
    {
        public System72Config Config { get; private set; } = new System72Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 72; public void ProcessTick(float dt) { Val += dt * 72; }

        public void Initialize(System72Config config)
        {
            Config = config;
        }
    }
}
