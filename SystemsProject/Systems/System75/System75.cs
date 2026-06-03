using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System75Config
    {
        public string SystemID { get; set; } = "System75";
        public float Base = 75;
    }

    public class System75 : MonoBehaviour
    {
        public System75Config Config { get; private set; } = new System75Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 75; public void ProcessTick(float dt) { Val += dt * 75; }

        public void Initialize(System75Config config)
        {
            Config = config;
        }
    }
}
