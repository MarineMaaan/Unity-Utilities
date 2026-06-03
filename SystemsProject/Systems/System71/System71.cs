using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System71Config
    {
        public string SystemID { get; set; } = "System71";
        public float Base = 71;
    }

    public class System71 : MonoBehaviour
    {
        public System71Config Config { get; private set; } = new System71Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 71; public void ProcessTick(float dt) { Val += dt * 71; }

        public void Initialize(System71Config config)
        {
            Config = config;
        }
    }
}
