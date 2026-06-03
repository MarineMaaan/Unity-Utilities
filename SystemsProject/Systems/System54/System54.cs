using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System54Config
    {
        public string SystemID { get; set; } = "System54";
        public float Base = 54;
    }

    public class System54 : MonoBehaviour
    {
        public System54Config Config { get; private set; } = new System54Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 54; public void ProcessTick(float dt) { Val += dt * 54; }

        public void Initialize(System54Config config)
        {
            Config = config;
        }
    }
}
