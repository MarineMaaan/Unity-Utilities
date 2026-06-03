using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System86Config
    {
        public string SystemID { get; set; } = "System86";
        public float Base = 86;
    }

    public class System86 : MonoBehaviour
    {
        public System86Config Config { get; private set; } = new System86Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 86; public void ProcessTick(float dt) { Val += dt * 86; }

        public void Initialize(System86Config config)
        {
            Config = config;
        }
    }
}
