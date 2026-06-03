using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System97Config
    {
        public string SystemID { get; set; } = "System97";
        public float Base = 97;
    }

    public class System97 : MonoBehaviour
    {
        public System97Config Config { get; private set; } = new System97Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 97; public void ProcessTick(float dt) { Val += dt * 97; }

        public void Initialize(System97Config config)
        {
            Config = config;
        }
    }
}
