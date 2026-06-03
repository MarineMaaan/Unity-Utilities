using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System24Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System24 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System24 goes here.");
        }
    }
}
