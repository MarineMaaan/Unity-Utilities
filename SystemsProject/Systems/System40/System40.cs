using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System40Config
    {
        public string SystemID { get; set; } = "System40";
        public float Base = 40;
    }

    public class System40 : MonoBehaviour
    {
        public System40Config Config { get; private set; } = new System40Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 40; public void ProcessTick(float dt) { Val += dt * 40; }

        public void Initialize(System40Config config)
        {
            Config = config;
        }
    }
}
