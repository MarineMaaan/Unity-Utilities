using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System70Config
    {
        public string SystemID { get; set; } = "System70";
        public float Base = 70;
    }

    public class System70 : MonoBehaviour
    {
        public System70Config Config { get; private set; } = new System70Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 70; public void ProcessTick(float dt) { Val += dt * 70; }

        public void Initialize(System70Config config)
        {
            Config = config;
        }
    }
}
