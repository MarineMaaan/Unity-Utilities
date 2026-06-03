using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System16Config
    {
        public string SystemID { get; set; } = "System16";
        public float Base = 16;
    }

    public class System16 : MonoBehaviour
    {
        public System16Config Config { get; private set; } = new System16Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 16; public void ProcessTick(float dt) { Val += dt * 16; }

        public void Initialize(System16Config config)
        {
            Config = config;
        }
    }
}
