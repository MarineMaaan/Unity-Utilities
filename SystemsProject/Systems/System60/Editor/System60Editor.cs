using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System60Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System60 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System60 goes here.");
        }
    }
}
