using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System6Config
    {
        public string SystemID { get; set; } = "System6";
        public float Base = 6;
    }

    public class System6 : MonoBehaviour
    {
        public System6Config Config { get; private set; } = new System6Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 6; public void ProcessTick(float dt) { Val += dt * 6; }

        public void Initialize(System6Config config)
        {
            Config = config;
        }
    }
}
