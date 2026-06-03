using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System28Config
    {
        public string SystemID { get; set; } = "System28";
        public float Base = 28;
    }

    public class System28 : MonoBehaviour
    {
        public System28Config Config { get; private set; } = new System28Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 28; public void ProcessTick(float dt) { Val += dt * 28; }

        public void Initialize(System28Config config)
        {
            Config = config;
        }
    }
}
