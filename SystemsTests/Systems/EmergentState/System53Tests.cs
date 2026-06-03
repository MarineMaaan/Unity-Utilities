using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System53Tests
    {
        [Fact]
        public void System53_Logic_WorksAsExpected()
        {
            var sys = new System53(); sys.Initialize(new System53Config()); sys.ProcessTick(1); Assert.Equal(53 + 53, sys.Val);
        }
    }
}
