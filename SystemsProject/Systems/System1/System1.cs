using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System1Config
    {
        public string SystemID { get; set; } = "System1";
        public float Base = 1;
    }

    public class System1 : MonoBehaviour
    {
        public System1Config Config { get; private set; } = new System1Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 1; public void ProcessTick(float dt) { Val += dt * 1; }

        public void Initialize(System1Config config)
        {
            Config = config;
        }
    }
}
