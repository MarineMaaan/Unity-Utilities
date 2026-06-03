using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System43Tests
    {
        [Fact]
        public void System43_Logic_WorksAsExpected()
        {
            var sys = new System43(); sys.Initialize(new System43Config()); sys.ProcessTick(1); Assert.Equal(43 + 43, sys.Val);
        }
    }
}
