using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System98Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System98 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System98 goes here.");
        }
    }
}
