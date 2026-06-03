using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System98Config
    {
        public string SystemID { get; set; } = "System98";
        public float Base = 98;
    }

    public class System98 : MonoBehaviour
    {
        public System98Config Config { get; private set; } = new System98Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 98; public void ProcessTick(float dt) { Val += dt * 98; }

        public void Initialize(System98Config config)
        {
            Config = config;
        }
    }
}
