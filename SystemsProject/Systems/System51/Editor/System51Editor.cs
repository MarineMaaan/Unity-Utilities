using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System51Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System51 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System51 goes here.");
        }
    }
}
