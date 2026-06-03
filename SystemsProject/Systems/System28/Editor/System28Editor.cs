using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System28Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System28 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System28 goes here.");
        }
    }
}
