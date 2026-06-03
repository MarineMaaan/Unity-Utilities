using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System90Config
    {
        public string SystemID { get; set; } = "System90";
        public float Base = 90;
    }

    public class System90 : MonoBehaviour
    {
        public System90Config Config { get; private set; } = new System90Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 90; public void ProcessTick(float dt) { Val += dt * 90; }

        public void Initialize(System90Config config)
        {
            Config = config;
        }
    }
}
