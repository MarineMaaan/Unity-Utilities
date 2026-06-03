using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System89Config
    {
        public string SystemID { get; set; } = "System89";
        public float Base = 89;
    }

    public class System89 : MonoBehaviour
    {
        public System89Config Config { get; private set; } = new System89Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 89; public void ProcessTick(float dt) { Val += dt * 89; }

        public void Initialize(System89Config config)
        {
            Config = config;
        }
    }
}
