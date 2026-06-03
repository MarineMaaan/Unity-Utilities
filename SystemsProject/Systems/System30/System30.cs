using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System30Config
    {
        public string SystemID { get; set; } = "System30";
        public float Base = 30;
    }

    public class System30 : MonoBehaviour
    {
        public System30Config Config { get; private set; } = new System30Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 30; public void ProcessTick(float dt) { Val += dt * 30; }

        public void Initialize(System30Config config)
        {
            Config = config;
        }
    }
}
