using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System62Config
    {
        public string SystemID { get; set; } = "System62";
        public float Base = 62;
    }

    public class System62 : MonoBehaviour
    {
        public System62Config Config { get; private set; } = new System62Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 62; public void ProcessTick(float dt) { Val += dt * 62; }

        public void Initialize(System62Config config)
        {
            Config = config;
        }
    }
}
