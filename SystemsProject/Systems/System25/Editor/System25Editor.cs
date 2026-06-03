using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System25Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System25 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System25 goes here.");
        }
    }
}
