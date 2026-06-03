using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System56Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System56 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System56 goes here.");
        }
    }
}
