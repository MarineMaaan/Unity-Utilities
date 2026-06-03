using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System22Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System22 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System22 goes here.");
        }
    }
}
