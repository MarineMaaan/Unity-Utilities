using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System70Tests
    {
        [Fact]
        public void System70_Logic_WorksAsExpected()
        {
            var sys = new System70(); sys.Initialize(new System70Config()); sys.ProcessTick(1); Assert.Equal(70 + 70, sys.Val);
        }
    }
}
