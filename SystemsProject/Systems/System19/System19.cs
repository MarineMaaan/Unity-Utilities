using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System19Config
    {
        public string SystemID { get; set; } = "System19";
        public float Base = 19;
    }

    public class System19 : MonoBehaviour
    {
        public System19Config Config { get; private set; } = new System19Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 19; public void ProcessTick(float dt) { Val += dt * 19; }

        public void Initialize(System19Config config)
        {
            Config = config;
        }
    }
}
