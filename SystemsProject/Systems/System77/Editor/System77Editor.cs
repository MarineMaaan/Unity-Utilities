using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System77Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System77 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System77 goes here.");
        }
    }
}
