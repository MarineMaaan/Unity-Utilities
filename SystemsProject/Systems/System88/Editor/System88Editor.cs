using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System88Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System88 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System88 goes here.");
        }
    }
}
