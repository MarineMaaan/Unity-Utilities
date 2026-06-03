using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System4Config
    {
        public string SystemID { get; set; } = "System4";
        public float Base = 4;
    }

    public class System4 : MonoBehaviour
    {
        public System4Config Config { get; private set; } = new System4Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 4; public void ProcessTick(float dt) { Val += dt * 4; }

        public void Initialize(System4Config config)
        {
            Config = config;
        }
    }
}
