using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System44Tests
    {
        [Fact]
        public void System44_Logic_WorksAsExpected()
        {
            var sys = new System44(); sys.Initialize(new System44Config()); sys.ProcessTick(1); Assert.Equal(44 + 44, sys.Val);
        }
    }
}
