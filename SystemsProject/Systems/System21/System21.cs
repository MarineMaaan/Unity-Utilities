using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System21Config
    {
        public string SystemID { get; set; } = "System21";
        public float Base = 21;
    }

    public class System21 : MonoBehaviour
    {
        public System21Config Config { get; private set; } = new System21Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 21; public void ProcessTick(float dt) { Val += dt * 21; }

        public void Initialize(System21Config config)
        {
            Config = config;
        }
    }
}
