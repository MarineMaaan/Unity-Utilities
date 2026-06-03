using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System83Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System83 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System83 goes here.");
        }
    }
}
