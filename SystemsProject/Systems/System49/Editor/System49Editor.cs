using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System49Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System49 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System49 goes here.");
        }
    }
}
