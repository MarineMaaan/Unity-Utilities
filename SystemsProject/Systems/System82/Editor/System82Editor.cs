using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System82Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System82 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System82 goes here.");
        }
    }
}
