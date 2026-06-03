using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System13Tests
    {
        [Fact]
        public void System13_Logic_WorksAsExpected()
        {
            var sys = new System13(); sys.Initialize(new System13Config()); sys.ProcessTick(1); Assert.Equal(13 + 13, sys.Val);
        }
    }
}
