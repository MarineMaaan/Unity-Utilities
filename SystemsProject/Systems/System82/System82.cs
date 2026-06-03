using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System82Config
    {
        public string SystemID { get; set; } = "System82";
        public float Base = 82;
    }

    public class System82 : MonoBehaviour
    {
        public System82Config Config { get; private set; } = new System82Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 82; public void ProcessTick(float dt) { Val += dt * 82; }

        public void Initialize(System82Config config)
        {
            Config = config;
        }
    }
}
