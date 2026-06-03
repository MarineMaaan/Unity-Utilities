using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System64Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System64 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System64 goes here.");
        }
    }
}
