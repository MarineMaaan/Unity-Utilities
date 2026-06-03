using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System9Config
    {
        public string SystemID { get; set; } = "System9";
        public float Base = 9;
    }

    public class System9 : MonoBehaviour
    {
        public System9Config Config { get; private set; } = new System9Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 9; public void ProcessTick(float dt) { Val += dt * 9; }

        public void Initialize(System9Config config)
        {
            Config = config;
        }
    }
}
