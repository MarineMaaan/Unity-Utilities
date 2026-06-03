using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System38Config
    {
        public string SystemID { get; set; } = "System38";
        public float Base = 38;
    }

    public class System38 : MonoBehaviour
    {
        public System38Config Config { get; private set; } = new System38Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 38; public void ProcessTick(float dt) { Val += dt * 38; }

        public void Initialize(System38Config config)
        {
            Config = config;
        }
    }
}
