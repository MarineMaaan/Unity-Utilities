using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System79Config
    {
        public string SystemID { get; set; } = "System79";
        public float Base = 79;
    }

    public class System79 : MonoBehaviour
    {
        public System79Config Config { get; private set; } = new System79Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 79; public void ProcessTick(float dt) { Val += dt * 79; }

        public void Initialize(System79Config config)
        {
            Config = config;
        }
    }
}
