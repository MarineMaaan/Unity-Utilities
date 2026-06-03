using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System26Config
    {
        public string SystemID { get; set; } = "System26";
        public float Base = 26;
    }

    public class System26 : MonoBehaviour
    {
        public System26Config Config { get; private set; } = new System26Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 26; public void ProcessTick(float dt) { Val += dt * 26; }

        public void Initialize(System26Config config)
        {
            Config = config;
        }
    }
}
