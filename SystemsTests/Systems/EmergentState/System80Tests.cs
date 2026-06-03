using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System80Tests
    {
        [Fact]
        public void System80_Logic_WorksAsExpected()
        {
            var sys = new System80(); sys.Initialize(new System80Config()); sys.ProcessTick(1); Assert.Equal(80 + 80, sys.Val);
        }
    }
}
