using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System8Tests
    {
        [Fact]
        public void System8_Logic_WorksAsExpected()
        {
            var sys = new System8(); sys.Initialize(new System8Config()); sys.ProcessTick(1); Assert.Equal(8 + 8, sys.Val);
        }
    }
}
