using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System61Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System61 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System61 goes here.");
        }
    }
}
