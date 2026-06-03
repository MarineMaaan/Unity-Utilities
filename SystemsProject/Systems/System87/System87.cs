using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System87Config
    {
        public string SystemID { get; set; } = "System87";
        public float Base = 87;
    }

    public class System87 : MonoBehaviour
    {
        public System87Config Config { get; private set; } = new System87Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 87; public void ProcessTick(float dt) { Val += dt * 87; }

        public void Initialize(System87Config config)
        {
            Config = config;
        }
    }
}
