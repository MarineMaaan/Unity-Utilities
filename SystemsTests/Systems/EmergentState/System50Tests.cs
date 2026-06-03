using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System50Tests
    {
        [Fact]
        public void System50_Logic_WorksAsExpected()
        {
            var sys = new System50(); sys.Initialize(new System50Config()); sys.ProcessTick(1); Assert.Equal(50 + 50, sys.Val);
        }
    }
}
