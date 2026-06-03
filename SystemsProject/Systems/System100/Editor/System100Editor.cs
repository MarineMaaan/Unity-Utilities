using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System100Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System100 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System100 goes here.");
        }
    }
}
