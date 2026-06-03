using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System43Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System43 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System43 goes here.");
        }
    }
}
