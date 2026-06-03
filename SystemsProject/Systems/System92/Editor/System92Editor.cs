using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System92Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System92 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System92 goes here.");
        }
    }
}
