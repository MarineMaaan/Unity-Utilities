using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System11Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System11 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System11 goes here.");
        }
    }
}
