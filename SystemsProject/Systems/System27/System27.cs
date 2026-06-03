using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System27Config
    {
        public string SystemID { get; set; } = "System27";
        public float Base = 27;
    }

    public class System27 : MonoBehaviour
    {
        public System27Config Config { get; private set; } = new System27Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 27; public void ProcessTick(float dt) { Val += dt * 27; }

        public void Initialize(System27Config config)
        {
            Config = config;
        }
    }
}
