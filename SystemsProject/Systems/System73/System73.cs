using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System73Config
    {
        public string SystemID { get; set; } = "System73";
        public float Base = 73;
    }

    public class System73 : MonoBehaviour
    {
        public System73Config Config { get; private set; } = new System73Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 73; public void ProcessTick(float dt) { Val += dt * 73; }

        public void Initialize(System73Config config)
        {
            Config = config;
        }
    }
}
