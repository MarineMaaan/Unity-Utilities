using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System80Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System80 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System80 goes here.");
        }
    }
}
