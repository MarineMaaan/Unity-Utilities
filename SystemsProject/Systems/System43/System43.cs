using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System43Config
    {
        public string SystemID { get; set; } = "System43";
        public float Base = 43;
    }

    public class System43 : MonoBehaviour
    {
        public System43Config Config { get; private set; } = new System43Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 43; public void ProcessTick(float dt) { Val += dt * 43; }

        public void Initialize(System43Config config)
        {
            Config = config;
        }
    }
}
