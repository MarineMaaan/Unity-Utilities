using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System97Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System97 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System97 goes here.");
        }
    }
}
