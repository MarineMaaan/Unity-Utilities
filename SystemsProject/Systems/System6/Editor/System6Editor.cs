using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System6Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System6 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System6 goes here.");
        }
    }
}
