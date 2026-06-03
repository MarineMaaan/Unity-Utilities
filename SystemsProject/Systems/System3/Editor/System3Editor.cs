using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System3Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System3 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System3 goes here.");
        }
    }
}
