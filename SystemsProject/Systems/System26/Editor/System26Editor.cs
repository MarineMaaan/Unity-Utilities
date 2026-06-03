using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System26Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System26 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System26 goes here.");
        }
    }
}
