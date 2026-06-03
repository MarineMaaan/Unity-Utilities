using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System29Config
    {
        public string SystemID { get; set; } = "System29";
        public float Base = 29;
    }

    public class System29 : MonoBehaviour
    {
        public System29Config Config { get; private set; } = new System29Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 29; public void ProcessTick(float dt) { Val += dt * 29; }

        public void Initialize(System29Config config)
        {
            Config = config;
        }
    }
}
