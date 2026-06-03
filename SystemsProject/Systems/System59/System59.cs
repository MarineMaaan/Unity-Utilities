using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System59Config
    {
        public string SystemID { get; set; } = "System59";
        public float Base = 59;
    }

    public class System59 : MonoBehaviour
    {
        public System59Config Config { get; private set; } = new System59Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 59; public void ProcessTick(float dt) { Val += dt * 59; }

        public void Initialize(System59Config config)
        {
            Config = config;
        }
    }
}
