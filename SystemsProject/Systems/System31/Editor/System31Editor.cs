using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System31Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System31 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System31 goes here.");
        }
    }
}
