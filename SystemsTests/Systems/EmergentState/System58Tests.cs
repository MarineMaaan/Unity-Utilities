using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System58Tests
    {
        [Fact]
        public void System58_Logic_WorksAsExpected()
        {
            var sys = new System58(); sys.Initialize(new System58Config()); sys.ProcessTick(1); Assert.Equal(58 + 58, sys.Val);
        }
    }
}
