using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System41Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System41 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System41 goes here.");
        }
    }
}
