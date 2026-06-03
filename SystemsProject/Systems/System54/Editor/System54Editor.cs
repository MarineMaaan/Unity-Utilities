using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System54Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System54 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System54 goes here.");
        }
    }
}
