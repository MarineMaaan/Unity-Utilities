using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System87Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System87 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System87 goes here.");
        }
    }
}
