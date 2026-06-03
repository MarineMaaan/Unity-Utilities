using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System83Config
    {
        public string SystemID { get; set; } = "System83";
        public float Base = 83;
    }

    public class System83 : MonoBehaviour
    {
        public System83Config Config { get; private set; } = new System83Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 83; public void ProcessTick(float dt) { Val += dt * 83; }

        public void Initialize(System83Config config)
        {
            Config = config;
        }
    }
}
