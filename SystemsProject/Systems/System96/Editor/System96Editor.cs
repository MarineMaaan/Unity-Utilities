using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System96Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System96 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System96 goes here.");
        }
    }
}
