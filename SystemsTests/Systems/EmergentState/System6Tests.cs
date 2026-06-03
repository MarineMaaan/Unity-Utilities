using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System6Tests
    {
        [Fact]
        public void System6_Logic_WorksAsExpected()
        {
            var sys = new System6(); sys.Initialize(new System6Config()); sys.ProcessTick(1); Assert.Equal(6 + 6, sys.Val);
        }
    }
}
