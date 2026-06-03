using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System47Config
    {
        public string SystemID { get; set; } = "System47";
        public float Base = 47;
    }

    public class System47 : MonoBehaviour
    {
        public System47Config Config { get; private set; } = new System47Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 47; public void ProcessTick(float dt) { Val += dt * 47; }

        public void Initialize(System47Config config)
        {
            Config = config;
        }
    }
}
