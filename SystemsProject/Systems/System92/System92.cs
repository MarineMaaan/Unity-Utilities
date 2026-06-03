using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System92Config
    {
        public string SystemID { get; set; } = "System92";
        public float Base = 92;
    }

    public class System92 : MonoBehaviour
    {
        public System92Config Config { get; private set; } = new System92Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 92; public void ProcessTick(float dt) { Val += dt * 92; }

        public void Initialize(System92Config config)
        {
            Config = config;
        }
    }
}
