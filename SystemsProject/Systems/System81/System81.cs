using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System81Config
    {
        public string SystemID { get; set; } = "System81";
        public float Base = 81;
    }

    public class System81 : MonoBehaviour
    {
        public System81Config Config { get; private set; } = new System81Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 81; public void ProcessTick(float dt) { Val += dt * 81; }

        public void Initialize(System81Config config)
        {
            Config = config;
        }
    }
}
