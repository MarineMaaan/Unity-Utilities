using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System63Config
    {
        public string SystemID { get; set; } = "System63";
        public float Base = 63;
    }

    public class System63 : MonoBehaviour
    {
        public System63Config Config { get; private set; } = new System63Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 63; public void ProcessTick(float dt) { Val += dt * 63; }

        public void Initialize(System63Config config)
        {
            Config = config;
        }
    }
}
