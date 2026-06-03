using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System62Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System62 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System62 goes here.");
        }
    }
}
