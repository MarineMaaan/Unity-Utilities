using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System31Config
    {
        public string SystemID { get; set; } = "System31";
        public float Base = 31;
    }

    public class System31 : MonoBehaviour
    {
        public System31Config Config { get; private set; } = new System31Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 31; public void ProcessTick(float dt) { Val += dt * 31; }

        public void Initialize(System31Config config)
        {
            Config = config;
        }
    }
}
