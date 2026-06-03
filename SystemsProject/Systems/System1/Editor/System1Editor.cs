using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System1Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System1 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System1 goes here.");
        }
    }
}
