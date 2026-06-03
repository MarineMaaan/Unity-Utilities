using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System22Config
    {
        public string SystemID { get; set; } = "System22";
        public float Base = 22;
    }

    public class System22 : MonoBehaviour
    {
        public System22Config Config { get; private set; } = new System22Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 22; public void ProcessTick(float dt) { Val += dt * 22; }

        public void Initialize(System22Config config)
        {
            Config = config;
        }
    }
}
