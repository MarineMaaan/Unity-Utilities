using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System38Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System38 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System38 goes here.");
        }
    }
}
