using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System19Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System19 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System19 goes here.");
        }
    }
}
