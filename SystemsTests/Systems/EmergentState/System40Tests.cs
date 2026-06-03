using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System40Tests
    {
        [Fact]
        public void System40_Logic_WorksAsExpected()
        {
            var sys = new System40(); sys.Initialize(new System40Config()); sys.ProcessTick(1); Assert.Equal(40 + 40, sys.Val);
        }
    }
}
