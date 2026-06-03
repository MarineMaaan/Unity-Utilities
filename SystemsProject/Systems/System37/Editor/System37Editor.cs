using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System37Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System37 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System37 goes here.");
        }
    }
}
