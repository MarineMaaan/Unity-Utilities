using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System94Config
    {
        public string SystemID { get; set; } = "System94";
        public float Base = 94;
    }

    public class System94 : MonoBehaviour
    {
        public System94Config Config { get; private set; } = new System94Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 94; public void ProcessTick(float dt) { Val += dt * 94; }

        public void Initialize(System94Config config)
        {
            Config = config;
        }
    }
}
