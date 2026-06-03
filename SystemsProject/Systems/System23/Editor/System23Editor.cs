using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System23Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System23 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System23 goes here.");
        }
    }
}
