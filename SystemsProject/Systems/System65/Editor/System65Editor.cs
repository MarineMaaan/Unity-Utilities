using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System65Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System65 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System65 goes here.");
        }
    }
}
