using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System12Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System12 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System12 goes here.");
        }
    }
}
