using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System86Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System86 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System86 goes here.");
        }
    }
}
