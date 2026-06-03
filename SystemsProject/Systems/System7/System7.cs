using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System7Config
    {
        public string SystemID { get; set; } = "System7";
        public float Base = 7;
    }

    public class System7 : MonoBehaviour
    {
        public System7Config Config { get; private set; } = new System7Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 7; public void ProcessTick(float dt) { Val += dt * 7; }

        public void Initialize(System7Config config)
        {
            Config = config;
        }
    }
}
