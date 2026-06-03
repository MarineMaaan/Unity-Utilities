using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System68Config
    {
        public string SystemID { get; set; } = "System68";
        public float Base = 68;
    }

    public class System68 : MonoBehaviour
    {
        public System68Config Config { get; private set; } = new System68Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 68; public void ProcessTick(float dt) { Val += dt * 68; }

        public void Initialize(System68Config config)
        {
            Config = config;
        }
    }
}
