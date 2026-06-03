using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System58Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System58 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System58 goes here.");
        }
    }
}
