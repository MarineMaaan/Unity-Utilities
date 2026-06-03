using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System17Config
    {
        public string SystemID { get; set; } = "System17";
        public float Base = 17;
    }

    public class System17 : MonoBehaviour
    {
        public System17Config Config { get; private set; } = new System17Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 17; public void ProcessTick(float dt) { Val += dt * 17; }

        public void Initialize(System17Config config)
        {
            Config = config;
        }
    }
}
