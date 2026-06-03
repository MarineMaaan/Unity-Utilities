using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System33Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System33 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System33 goes here.");
        }
    }
}
