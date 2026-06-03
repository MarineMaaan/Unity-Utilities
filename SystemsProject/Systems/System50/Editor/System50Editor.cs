using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System50Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System50 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System50 goes here.");
        }
    }
}
