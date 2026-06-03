using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System69Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System69 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System69 goes here.");
        }
    }
}
