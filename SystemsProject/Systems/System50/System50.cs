using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System50Config
    {
        public string SystemID { get; set; } = "System50";
        public float Base = 50;
    }

    public class System50 : MonoBehaviour
    {
        public System50Config Config { get; private set; } = new System50Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 50; public void ProcessTick(float dt) { Val += dt * 50; }

        public void Initialize(System50Config config)
        {
            Config = config;
        }
    }
}
