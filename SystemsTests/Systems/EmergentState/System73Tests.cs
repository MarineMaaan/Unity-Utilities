using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System73Tests
    {
        [Fact]
        public void System73_Logic_WorksAsExpected()
        {
            var sys = new System73(); sys.Initialize(new System73Config()); sys.ProcessTick(1); Assert.Equal(73 + 73, sys.Val);
        }
    }
}
