using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System11Config
    {
        public string SystemID { get; set; } = "System11";
        public float Base = 11;
    }

    public class System11 : MonoBehaviour
    {
        public System11Config Config { get; private set; } = new System11Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 11; public void ProcessTick(float dt) { Val += dt * 11; }

        public void Initialize(System11Config config)
        {
            Config = config;
        }
    }
}
