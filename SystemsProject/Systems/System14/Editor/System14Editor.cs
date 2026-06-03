using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System14Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System14 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System14 goes here.");
        }
    }
}
