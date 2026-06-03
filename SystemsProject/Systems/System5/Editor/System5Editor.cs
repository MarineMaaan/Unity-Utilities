using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System5Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System5 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System5 goes here.");
        }
    }
}
