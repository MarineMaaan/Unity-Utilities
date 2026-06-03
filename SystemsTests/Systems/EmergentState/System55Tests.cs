using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System55Tests
    {
        [Fact]
        public void System55_Logic_WorksAsExpected()
        {
            var sys = new System55(); sys.Initialize(new System55Config()); sys.ProcessTick(1); Assert.Equal(55 + 55, sys.Val);
        }
    }
}
