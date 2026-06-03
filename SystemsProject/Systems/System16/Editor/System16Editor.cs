using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System16Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System16 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System16 goes here.");
        }
    }
}
