using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System2Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System2 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System2 goes here.");
        }
    }
}
