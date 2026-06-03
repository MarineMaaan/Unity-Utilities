using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System39Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System39 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System39 goes here.");
        }
    }
}
