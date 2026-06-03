using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System77Config
    {
        public string SystemID { get; set; } = "System77";
        public float Base = 77;
    }

    public class System77 : MonoBehaviour
    {
        public System77Config Config { get; private set; } = new System77Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 77; public void ProcessTick(float dt) { Val += dt * 77; }

        public void Initialize(System77Config config)
        {
            Config = config;
        }
    }
}
