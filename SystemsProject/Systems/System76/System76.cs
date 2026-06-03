using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System76Config
    {
        public string SystemID { get; set; } = "System76";
        public float Base = 76;
    }

    public class System76 : MonoBehaviour
    {
        public System76Config Config { get; private set; } = new System76Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 76; public void ProcessTick(float dt) { Val += dt * 76; }

        public void Initialize(System76Config config)
        {
            Config = config;
        }
    }
}
