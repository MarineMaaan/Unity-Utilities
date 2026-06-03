using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System17Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System17 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System17 goes here.");
        }
    }
}
