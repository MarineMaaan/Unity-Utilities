using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System2Tests
    {
        [Fact]
        public void System2_Logic_WorksAsExpected()
        {
            var sys = new System2(); sys.Initialize(new System2Config()); sys.ProcessTick(1); Assert.Equal(2 + 2, sys.Val);
        }
    }
}
