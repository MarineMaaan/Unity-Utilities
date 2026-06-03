using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System18Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System18 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System18 goes here.");
        }
    }
}
