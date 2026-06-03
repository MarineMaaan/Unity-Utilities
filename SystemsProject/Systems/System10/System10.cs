using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System10Config
    {
        public string SystemID { get; set; } = "System10";
        public float Base = 10;
    }

    public class System10 : MonoBehaviour
    {
        public System10Config Config { get; private set; } = new System10Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 10; public void ProcessTick(float dt) { Val += dt * 10; }

        public void Initialize(System10Config config)
        {
            Config = config;
        }
    }
}
