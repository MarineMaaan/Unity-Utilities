using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System20Config
    {
        public string SystemID { get; set; } = "System20";
        public float Base = 20;
    }

    public class System20 : MonoBehaviour
    {
        public System20Config Config { get; private set; } = new System20Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 20; public void ProcessTick(float dt) { Val += dt * 20; }

        public void Initialize(System20Config config)
        {
            Config = config;
        }
    }
}
