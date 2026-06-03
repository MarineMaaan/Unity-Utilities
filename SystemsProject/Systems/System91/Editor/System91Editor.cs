using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System91Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System91 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System91 goes here.");
        }
    }
}
