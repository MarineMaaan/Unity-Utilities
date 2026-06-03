using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System76Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System76 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System76 goes here.");
        }
    }
}
