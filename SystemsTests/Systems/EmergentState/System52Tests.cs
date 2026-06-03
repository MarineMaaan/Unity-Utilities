using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System52Tests
    {
        [Fact]
        public void System52_Logic_WorksAsExpected()
        {
            var sys = new System52(); sys.Initialize(new System52Config()); sys.ProcessTick(1); Assert.Equal(52 + 52, sys.Val);
        }
    }
}
