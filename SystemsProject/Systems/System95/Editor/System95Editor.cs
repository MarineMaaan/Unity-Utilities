using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System95Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System95 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System95 goes here.");
        }
    }
}
