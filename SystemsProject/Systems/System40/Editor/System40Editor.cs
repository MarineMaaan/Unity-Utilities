using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System40Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System40 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System40 goes here.");
        }
    }
}
