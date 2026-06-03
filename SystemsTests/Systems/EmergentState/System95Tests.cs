using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System95Tests
    {
        [Fact]
        public void System95_Logic_WorksAsExpected()
        {
            var sys = new System95(); sys.Initialize(new System95Config()); sys.ProcessTick(1); Assert.Equal(95 + 95, sys.Val);
        }
    }
}
