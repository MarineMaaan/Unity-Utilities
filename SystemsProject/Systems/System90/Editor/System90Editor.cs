using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System90Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System90 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System90 goes here.");
        }
    }
}
