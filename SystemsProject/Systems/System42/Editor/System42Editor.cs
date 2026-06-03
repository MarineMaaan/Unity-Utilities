using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System42Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System42 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System42 goes here.");
        }
    }
}
