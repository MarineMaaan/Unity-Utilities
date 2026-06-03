using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System46Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System46 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System46 goes here.");
        }
    }
}
