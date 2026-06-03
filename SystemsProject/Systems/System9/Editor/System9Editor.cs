using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System9Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System9 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System9 goes here.");
        }
    }
}
