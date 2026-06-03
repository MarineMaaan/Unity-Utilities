using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System84Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System84 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System84 goes here.");
        }
    }
}
