using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System78Config
    {
        public string SystemID { get; set; } = "System78";
        public float Base = 78;
    }

    public class System78 : MonoBehaviour
    {
        public System78Config Config { get; private set; } = new System78Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 78; public void ProcessTick(float dt) { Val += dt * 78; }

        public void Initialize(System78Config config)
        {
            Config = config;
        }
    }
}
