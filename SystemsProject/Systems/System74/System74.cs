using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System74Config
    {
        public string SystemID { get; set; } = "System74";
        public float Base = 74;
    }

    public class System74 : MonoBehaviour
    {
        public System74Config Config { get; private set; } = new System74Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 74; public void ProcessTick(float dt) { Val += dt * 74; }

        public void Initialize(System74Config config)
        {
            Config = config;
        }
    }
}
