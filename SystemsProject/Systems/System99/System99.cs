using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System99Config
    {
        public string SystemID { get; set; } = "System99";
        public float Base = 99;
    }

    public class System99 : MonoBehaviour
    {
        public System99Config Config { get; private set; } = new System99Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 99; public void ProcessTick(float dt) { Val += dt * 99; }

        public void Initialize(System99Config config)
        {
            Config = config;
        }
    }
}
