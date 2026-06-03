using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System64Config
    {
        public string SystemID { get; set; } = "System64";
        public float Base = 64;
    }

    public class System64 : MonoBehaviour
    {
        public System64Config Config { get; private set; } = new System64Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 64; public void ProcessTick(float dt) { Val += dt * 64; }

        public void Initialize(System64Config config)
        {
            Config = config;
        }
    }
}
