using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System80Config
    {
        public string SystemID { get; set; } = "System80";
        public float Base = 80;
    }

    public class System80 : MonoBehaviour
    {
        public System80Config Config { get; private set; } = new System80Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 80; public void ProcessTick(float dt) { Val += dt * 80; }

        public void Initialize(System80Config config)
        {
            Config = config;
        }
    }
}
