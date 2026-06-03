using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System63Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System63 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System63 goes here.");
        }
    }
}
