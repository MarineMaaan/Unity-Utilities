using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System79Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System79 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System79 goes here.");
        }
    }
}
