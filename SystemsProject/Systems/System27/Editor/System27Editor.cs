using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System27Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System27 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System27 goes here.");
        }
    }
}
