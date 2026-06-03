using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System52Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System52 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System52 goes here.");
        }
    }
}
