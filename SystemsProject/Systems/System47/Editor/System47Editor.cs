using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{
    public class System47Editor : EditorWindow
    {
        public override void OnGUI()
        {
            GUILayout.Label("System47 Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for System47 goes here.");
        }
    }
}
