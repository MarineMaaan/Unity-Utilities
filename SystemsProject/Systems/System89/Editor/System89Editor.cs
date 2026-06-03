using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System89Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System89 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System89 goes here.");
        }
    }
}
