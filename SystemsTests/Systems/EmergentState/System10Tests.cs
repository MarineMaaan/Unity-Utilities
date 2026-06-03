using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System10Tests
    {
        [Fact]
        public void System10_Logic_WorksAsExpected()
        {
            var sys = new System10(); sys.Initialize(new System10Config()); sys.ProcessTick(1); Assert.Equal(10 + 10, sys.Val);
        }
    }
}
