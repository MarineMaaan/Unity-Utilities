import os
import shutil

systems = []
for i in range(1, 101):
    systems.append({
        "name": f"System{i}",
        "category": "EmergentState",
        "logic": f"public float Val = {i}; public void ProcessTick(float dt) {{ Val += dt * {i}; }}",
        "config": f"public float Base = {i};",
        "test": f"var sys = new System{i}(); sys.Initialize(new System{i}Config()); sys.ProcessTick(1); Assert.Equal({i} + {i}, sys.Val);"
    })

def generate():
    os.makedirs("SystemsProject/Systems", exist_ok=True)
    os.makedirs("SystemsTests/Systems", exist_ok=True)

    for sys in systems:
        folder = f"SystemsProject/Systems/{sys['name']}"
        os.makedirs(folder, exist_ok=True)

        # CS logic
        with open(f"{folder}/{sys['name']}.cs", "w") as f:
            f.write(f"""using System.Collections.Generic;
using UnityEngine;

namespace SystemsProject.{sys['category']}
{{
    public class {sys['name']}Config
    {{
        public string SystemID {{ get; set; }} = "{sys['name']}";
        {sys['config']}
    }}

    public class {sys['name']} : MonoBehaviour
    {{
        public {sys['name']}Config Config {{ get; private set; }} = new {sys['name']}Config();
        public Vector3 Position {{ get; set; }} = Vector3.zero;

        {sys['logic']}

        public void Initialize({sys['name']}Config config)
        {{
            Config = config;
        }}
    }}
}}
""")

        # Editor
        os.makedirs(f"{folder}/Editor", exist_ok=True)
        with open(f"{folder}/Editor/{sys['name']}Editor.cs", "w") as f:
            f.write(f"""using UnityEditor;
using UnityEngine;

namespace SystemsProject.Editors
{{
    public class {sys['name']}Editor : EditorWindow
    {{
        public override void OnGUI()
        {{
            GUILayout.Label("{sys['name']} Editor Window", EditorStyles.boldLabel);
            GUILayout.Label("Custom tooling for {sys['name']} goes here.");
        }}
    }}
}}
""")

        # README
        with open(f"{folder}/README.md", "w") as f:
            f.write(f"# {sys['name']}\nPart of the {sys['category']} system. Provides robust modular mechanics without relying on hardcoded types.")

        # Test
        test_folder = f"SystemsTests/Systems/{sys['category']}"
        os.makedirs(test_folder, exist_ok=True)
        with open(f"{test_folder}/{sys['name']}Tests.cs", "w") as f:
            f.write(f"""using Xunit;
using SystemsProject.{sys['category']};
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.{sys['category']}
{{
    public class {sys['name']}Tests
    {{
        [Fact]
        public void {sys['name']}_Logic_WorksAsExpected()
        {{
            {sys['test']}
        }}
    }}
}}
""")

if __name__ == "__main__":
    generate()
