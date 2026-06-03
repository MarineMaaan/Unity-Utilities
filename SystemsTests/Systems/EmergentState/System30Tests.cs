using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System30Tests
    {
        [Fact]
        public void System30_Logic_WorksAsExpected()
        {
            var sys = new System30(); sys.Initialize(new System30Config()); sys.ProcessTick(1); Assert.Equal(30 + 30, sys.Val);
        }
    }
}
