using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System31Tests
    {
        [Fact]
        public void System31_Logic_WorksAsExpected()
        {
            var sys = new System31(); sys.Initialize(new System31Config()); sys.ProcessTick(1); Assert.Equal(31 + 31, sys.Val);
        }
    }
}
