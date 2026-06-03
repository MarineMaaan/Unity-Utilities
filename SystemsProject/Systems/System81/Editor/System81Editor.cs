using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System81Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System81 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System81 goes here.");
        }
    }
}
