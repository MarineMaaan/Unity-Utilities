using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System96Config
    {
        public string SystemID { get; set; } = "System96";
        public float Base = 96;
    }

    public class System96 : MonoBehaviour
    {
        public System96Config Config { get; private set; } = new System96Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 96; public void ProcessTick(float dt) { Val += dt * 96; }

        public void Initialize(System96Config config)
        {
            Config = config;
        }
    }
}
