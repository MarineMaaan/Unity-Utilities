using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System65Config
    {
        public string SystemID { get; set; } = "System65";
        public float Base = 65;
    }

    public class System65 : MonoBehaviour
    {
        public System65Config Config { get; private set; } = new System65Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 65; public void ProcessTick(float dt) { Val += dt * 65; }

        public void Initialize(System65Config config)
        {
            Config = config;
        }
    }
}
