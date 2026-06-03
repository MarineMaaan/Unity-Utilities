using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System21Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System21 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System21 goes here.");
        }
    }
}
