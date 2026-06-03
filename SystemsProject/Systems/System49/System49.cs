using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System49Config
    {
        public string SystemID { get; set; } = "System49";
        public float Base = 49;
    }

    public class System49 : MonoBehaviour
    {
        public System49Config Config { get; private set; } = new System49Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 49; public void ProcessTick(float dt) { Val += dt * 49; }

        public void Initialize(System49Config config)
        {
            Config = config;
        }
    }
}
