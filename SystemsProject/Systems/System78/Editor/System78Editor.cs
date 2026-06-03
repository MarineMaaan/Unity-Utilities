using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System78Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System78 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System78 goes here.");
        }
    }
}
