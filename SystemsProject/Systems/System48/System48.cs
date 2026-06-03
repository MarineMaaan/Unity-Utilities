using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System48Config
    {
        public string SystemID { get; set; } = "System48";
        public float Base = 48;
    }

    public class System48 : MonoBehaviour
    {
        public System48Config Config { get; private set; } = new System48Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 48; public void ProcessTick(float dt) { Val += dt * 48; }

        public void Initialize(System48Config config)
        {
            Config = config;
        }
    }
}
