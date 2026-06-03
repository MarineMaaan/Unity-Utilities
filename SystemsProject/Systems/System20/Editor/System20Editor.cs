using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System20Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System20 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System20 goes here.");
        }
    }
}
