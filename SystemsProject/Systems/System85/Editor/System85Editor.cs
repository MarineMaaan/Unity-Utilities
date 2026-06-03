using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System85Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System85 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System85 goes here.");
        }
    }
}
