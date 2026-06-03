using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System10Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System10 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System10 goes here.");
        }
    }
}
