using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System71Tests
    {
        [Fact]
        public void System71_Logic_WorksAsExpected()
        {
            var sys = new System71(); sys.Initialize(new System71Config()); sys.ProcessTick(1); Assert.Equal(71 + 71, sys.Val);
        }
    }
}
