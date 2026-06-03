using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.EmergentState
{
    public class System67Config
    {
        public string SystemID { get; set; } = "System67";
        public float Base = 67;
    }

    public class System67 : MonoBehaviour
    {
        public System67Config Config { get; private set; } = new System67Config();
        public Vector3 Position { get; set; } = Vector3.zero;

        public float Val = 67; public void ProcessTick(float dt) { Val += dt * 67; }

        public void Initialize(System67Config config)
        {
            Config = config;
        }
    }
}
