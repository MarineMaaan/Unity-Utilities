using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System16Tests
    {
        [Fact]
        public void System16_Logic_WorksAsExpected()
        {
            var sys = new System16(); sys.Initialize(new System16Config()); sys.ProcessTick(1); Assert.Equal(16 + 16, sys.Val);
        }
    }
}
