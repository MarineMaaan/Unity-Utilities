using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System69Config
    {
        public string SystemID { get; set; } = "System69";
        public float Base = 69;
    }

    public class System69 : MonoBehaviour
    {
        public System69Config Config { get; private set; } = new System69Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 69; public void ProcessTick(float dt) { Val += dt * 69; }

        public void Initialize(System69Config config)
        {
            Config = config;
        }
    }
}
