using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System45Config
    {
        public string SystemID { get; set; } = "System45";
        public float Base = 45;
    }

    public class System45 : MonoBehaviour
    {
        public System45Config Config { get; private set; } = new System45Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 45; public void ProcessTick(float dt) { Val += dt * 45; }

        public void Initialize(System45Config config)
        {
            Config = config;
        }
    }
}
