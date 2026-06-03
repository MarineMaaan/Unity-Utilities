using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System60Tests
    {
        [Fact]
        public void System60_Logic_WorksAsExpected()
        {
            var sys = new System60(); sys.Initialize(new System60Config()); sys.ProcessTick(1); Assert.Equal(60 + 60, sys.Val);
        }
    }
}
