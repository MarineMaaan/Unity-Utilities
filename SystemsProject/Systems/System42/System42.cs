using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System42Config
    {
        public string SystemID { get; set; } = "System42";
        public float Base = 42;
    }

    public class System42 : MonoBehaviour
    {
        public System42Config Config { get; private set; } = new System42Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 42; public void ProcessTick(float dt) { Val += dt * 42; }

        public void Initialize(System42Config config)
        {
            Config = config;
        }
    }
}
