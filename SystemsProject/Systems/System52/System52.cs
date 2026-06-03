using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System52Config
    {
        public string SystemID { get; set; } = "System52";
        public float Base = 52;
    }

    public class System52 : MonoBehaviour
    {
        public System52Config Config { get; private set; } = new System52Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 52; public void ProcessTick(float dt) { Val += dt * 52; }

        public void Initialize(System52Config config)
        {
            Config = config;
        }
    }
}
