using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System2Config
    {
        public string SystemID { get; set; } = "System2";
        public float Base = 2;
    }

    public class System2 : MonoBehaviour
    {
        public System2Config Config { get; private set; } = new System2Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 2; public void ProcessTick(float dt) { Val += dt * 2; }

        public void Initialize(System2Config config)
        {
            Config = config;
        }
    }
}
