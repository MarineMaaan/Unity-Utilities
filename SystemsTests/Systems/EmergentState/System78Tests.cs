using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System78Tests
    {
        [Fact]
        public void System78_Logic_WorksAsExpected()
        {
            var sys = new System78(); sys.Initialize(new System78Config()); sys.ProcessTick(1); Assert.Equal(78 + 78, sys.Val);
        }
    }
}
