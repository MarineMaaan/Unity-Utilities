using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System44Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System44 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System44 goes here.");
        }
    }
}
