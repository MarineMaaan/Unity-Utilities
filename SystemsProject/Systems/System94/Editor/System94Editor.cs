using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System94Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System94 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System94 goes here.");
        }
    }
}
