using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System73Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System73 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System73 goes here.");
        }
    }
}
