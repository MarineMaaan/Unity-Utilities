using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System53Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System53 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System53 goes here.");
        }
    }
}
