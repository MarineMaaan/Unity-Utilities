using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System14Config
    {
        public string SystemID { get; set; } = "System14";
        public float Base = 14;
    }

    public class System14 : MonoBehaviour
    {
        public System14Config Config { get; private set; } = new System14Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 14; public void ProcessTick(float dt) { Val += dt * 14; }

        public void Initialize(System14Config config)
        {
            Config = config;
        }
    }
}
