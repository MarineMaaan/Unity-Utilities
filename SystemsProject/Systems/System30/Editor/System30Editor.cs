using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System30Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System30 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System30 goes here.");
        }
    }
}
