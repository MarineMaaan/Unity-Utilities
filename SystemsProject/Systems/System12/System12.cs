using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System12Config
    {
        public string SystemID { get; set; } = "System12";
        public float Base = 12;
    }

    public class System12 : MonoBehaviour
    {
        public System12Config Config { get; private set; } = new System12Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 12; public void ProcessTick(float dt) { Val += dt * 12; }

        public void Initialize(System12Config config)
        {
            Config = config;
        }
    }
}
