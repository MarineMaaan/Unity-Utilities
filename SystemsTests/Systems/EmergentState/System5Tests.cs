using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System5Tests
    {
        [Fact]
        public void System5_Logic_WorksAsExpected()
        {
            var sys = new System5(); sys.Initialize(new System5Config()); sys.ProcessTick(1); Assert.Equal(5 + 5, sys.Val);
        }
    }
}
