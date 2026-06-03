using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System94Tests
    {
        [Fact]
        public void System94_Logic_WorksAsExpected()
        {
            var sys = new System94(); sys.Initialize(new System94Config()); sys.ProcessTick(1); Assert.Equal(94 + 94, sys.Val);
        }
    }
}
