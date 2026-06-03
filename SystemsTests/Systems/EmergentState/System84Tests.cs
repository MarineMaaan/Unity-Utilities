using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System84Tests
    {
        [Fact]
        public void System84_Logic_WorksAsExpected()
        {
            var sys = new System84(); sys.Initialize(new System84Config()); sys.ProcessTick(1); Assert.Equal(84 + 84, sys.Val);
        }
    }
}
