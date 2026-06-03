using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System93Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System93 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System93 goes here.");
        }
    }
}
