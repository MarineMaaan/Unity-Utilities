using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System36Config
    {
        public string SystemID { get; set; } = "System36";
        public float Base = 36;
    }

    public class System36 : MonoBehaviour
    {
        public System36Config Config { get; private set; } = new System36Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 36; public void ProcessTick(float dt) { Val += dt * 36; }

        public void Initialize(System36Config config)
        {
            Config = config;
        }
    }
}
