using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System37Config
    {
        public string SystemID { get; set; } = "System37";
        public float Base = 37;
    }

    public class System37 : MonoBehaviour
    {
        public System37Config Config { get; private set; } = new System37Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 37; public void ProcessTick(float dt) { Val += dt * 37; }

        public void Initialize(System37Config config)
        {
            Config = config;
        }
    }
}
