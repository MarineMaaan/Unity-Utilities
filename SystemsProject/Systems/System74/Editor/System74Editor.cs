using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System74Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System74 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System74 goes here.");
        }
    }
}
