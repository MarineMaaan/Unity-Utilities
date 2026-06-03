using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System59Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System59 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System59 goes here.");
        }
    }
}
