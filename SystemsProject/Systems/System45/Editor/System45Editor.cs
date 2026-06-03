using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System45Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System45 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System45 goes here.");
        }
    }
}
