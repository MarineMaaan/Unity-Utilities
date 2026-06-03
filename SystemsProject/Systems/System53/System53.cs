using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System53Config
    {
        public string SystemID { get; set; } = "System53";
        public float Base = 53;
    }

    public class System53 : MonoBehaviour
    {
        public System53Config Config { get; private set; } = new System53Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 53; public void ProcessTick(float dt) { Val += dt * 53; }

        public void Initialize(System53Config config)
        {
            Config = config;
        }
    }
}
