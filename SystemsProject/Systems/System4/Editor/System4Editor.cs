using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System4Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System4 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System4 goes here.");
        }
    }
}
