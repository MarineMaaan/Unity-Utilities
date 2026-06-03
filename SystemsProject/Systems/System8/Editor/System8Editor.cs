using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System8Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System8 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System8 goes here.");
        }
    }
}
