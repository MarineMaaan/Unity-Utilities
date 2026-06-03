using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System88Config
    {
        public string SystemID { get; set; } = "System88";
        public float Base = 88;
    }

    public class System88 : MonoBehaviour
    {
        public System88Config Config { get; private set; } = new System88Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 88; public void ProcessTick(float dt) { Val += dt * 88; }

        public void Initialize(System88Config config)
        {
            Config = config;
        }
    }
}
