using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System68Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System68 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System68 goes here.");
        }
    }
}
