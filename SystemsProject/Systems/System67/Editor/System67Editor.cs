using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System67Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System67 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System67 goes here.");
        }
    }
}
