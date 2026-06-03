using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System51Config
    {
        public string SystemID { get; set; } = "System51";
        public float Base = 51;
    }

    public class System51 : MonoBehaviour
    {
        public System51Config Config { get; private set; } = new System51Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 51; public void ProcessTick(float dt) { Val += dt * 51; }

        public void Initialize(System51Config config)
        {
            Config = config;
        }
    }
}
