using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System93Config
    {
        public string SystemID { get; set; } = "System93";
        public float Base = 93;
    }

    public class System93 : MonoBehaviour
    {
        public System93Config Config { get; private set; } = new System93Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 93; public void ProcessTick(float dt) { Val += dt * 93; }

        public void Initialize(System93Config config)
        {
            Config = config;
        }
    }
}
