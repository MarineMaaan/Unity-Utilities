using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System100Config
    {
        public string SystemID { get; set; } = "System100";
        public float Base = 100;
    }

    public class System100 : MonoBehaviour
    {
        public System100Config Config { get; private set; } = new System100Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 100; public void ProcessTick(float dt) { Val += dt * 100; }

        public void Initialize(System100Config config)
        {
            Config = config;
        }
    }
}
