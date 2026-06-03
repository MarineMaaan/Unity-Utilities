using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System61Config
    {
        public string SystemID { get; set; } = "System61";
        public float Base = 61;
    }

    public class System61 : MonoBehaviour
    {
        public System61Config Config { get; private set; } = new System61Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 61; public void ProcessTick(float dt) { Val += dt * 61; }

        public void Initialize(System61Config config)
        {
            Config = config;
        }
    }
}
