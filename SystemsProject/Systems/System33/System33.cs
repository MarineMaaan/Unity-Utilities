using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System33Config
    {
        public string SystemID { get; set; } = "System33";
        public float Base = 33;
    }

    public class System33 : MonoBehaviour
    {
        public System33Config Config { get; private set; } = new System33Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 33; public void ProcessTick(float dt) { Val += dt * 33; }

        public void Initialize(System33Config config)
        {
            Config = config;
        }
    }
}
