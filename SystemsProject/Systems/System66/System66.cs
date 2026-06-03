using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System66Config
    {
        public string SystemID { get; set; } = "System66";
        public float Base = 66;
    }

    public class System66 : MonoBehaviour
    {
        public System66Config Config { get; private set; } = new System66Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 66; public void ProcessTick(float dt) { Val += dt * 66; }

        public void Initialize(System66Config config)
        {
            Config = config;
        }
    }
}
