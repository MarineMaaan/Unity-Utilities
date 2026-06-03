using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System66Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System66 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System66 goes here.");
        }
    }
}
