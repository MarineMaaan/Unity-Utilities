using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System35Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System35 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System35 goes here.");
        }
    }
}
