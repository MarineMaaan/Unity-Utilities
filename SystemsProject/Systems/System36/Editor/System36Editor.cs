using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System36Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System36 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System36 goes here.");
        }
    }
}
