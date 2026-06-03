using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System60Config
    {
        public string SystemID { get; set; } = "System60";
        public float Base = 60;
    }

    public class System60 : MonoBehaviour
    {
        public System60Config Config { get; private set; } = new System60Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 60; public void ProcessTick(float dt) { Val += dt * 60; }

        public void Initialize(System60Config config)
        {
            Config = config;
        }
    }
}
