using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System48Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System48 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System48 goes here.");
        }
    }
}
