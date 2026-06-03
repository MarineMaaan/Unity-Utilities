using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System35Config
    {
        public string SystemID { get; set; } = "System35";
        public float Base = 35;
    }

    public class System35 : MonoBehaviour
    {
        public System35Config Config { get; private set; } = new System35Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 35; public void ProcessTick(float dt) { Val += dt * 35; }

        public void Initialize(System35Config config)
        {
            Config = config;
        }
    }
}
