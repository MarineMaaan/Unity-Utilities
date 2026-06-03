using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System84Config
    {
        public string SystemID { get; set; } = "System84";
        public float Base = 84;
    }

    public class System84 : MonoBehaviour
    {
        public System84Config Config { get; private set; } = new System84Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 84; public void ProcessTick(float dt) { Val += dt * 84; }

        public void Initialize(System84Config config)
        {
            Config = config;
        }
    }
}
