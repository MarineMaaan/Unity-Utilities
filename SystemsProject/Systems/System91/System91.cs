using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System91Config
    {
        public string SystemID { get; set; } = "System91";
        public float Base = 91;
    }

    public class System91 : MonoBehaviour
    {
        public System91Config Config { get; private set; } = new System91Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 91; public void ProcessTick(float dt) { Val += dt * 91; }

        public void Initialize(System91Config config)
        {
            Config = config;
        }
    }
}
