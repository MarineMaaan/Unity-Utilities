using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System34Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System34 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System34 goes here.");
        }
    }
}
