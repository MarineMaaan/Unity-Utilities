using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System55Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System55 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System55 goes here.");
        }
    }
}
