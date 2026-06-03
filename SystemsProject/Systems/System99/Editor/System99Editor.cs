using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System99Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System99 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System99 goes here.");
        }
    }
}
