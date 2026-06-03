using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System70Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System70 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System70 goes here.");
        }
    }
}
