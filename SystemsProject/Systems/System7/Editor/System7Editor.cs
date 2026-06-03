using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System7Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System7 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System7 goes here.");
        }
    }
}
