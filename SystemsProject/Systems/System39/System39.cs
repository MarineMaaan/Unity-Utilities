using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System39Config
    {
        public string SystemID { get; set; } = "System39";
        public float Base = 39;
    }

    public class System39 : MonoBehaviour
    {
        public System39Config Config { get; private set; } = new System39Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 39; public void ProcessTick(float dt) { Val += dt * 39; }

        public void Initialize(System39Config config)
        {
            Config = config;
        }
    }
}
