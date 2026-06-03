using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System57Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System57 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System57 goes here.");
        }
    }
}
