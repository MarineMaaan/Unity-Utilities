using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System56Config
    {
        public string SystemID { get; set; } = "System56";
        public float Base = 56;
    }

    public class System56 : MonoBehaviour
    {
        public System56Config Config { get; private set; } = new System56Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 56; public void ProcessTick(float dt) { Val += dt * 56; }

        public void Initialize(System56Config config)
        {
            Config = config;
        }
    }
}
