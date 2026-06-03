using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System85Config
    {
        public string SystemID { get; set; } = "System85";
        public float Base = 85;
    }

    public class System85 : MonoBehaviour
    {
        public System85Config Config { get; private set; } = new System85Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 85; public void ProcessTick(float dt) { Val += dt * 85; }

        public void Initialize(System85Config config)
        {
            Config = config;
        }
    }
}
