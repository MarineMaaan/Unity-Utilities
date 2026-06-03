using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System18Config
    {
        public string SystemID { get; set; } = "System18";
        public float Base = 18;
    }

    public class System18 : MonoBehaviour
    {
        public System18Config Config { get; private set; } = new System18Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 18; public void ProcessTick(float dt) { Val += dt * 18; }

        public void Initialize(System18Config config)
        {
            Config = config;
        }
    }
}
