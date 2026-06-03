using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System32Tests
    {
        [Fact]
        public void System32_Logic_WorksAsExpected()
        {
            var sys = new System32(); sys.Initialize(new System32Config()); sys.ProcessTick(1); Assert.Equal(32 + 32, sys.Val);
        }
    }
}
