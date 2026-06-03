using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System56Tests
    {
        [Fact]
        public void System56_Logic_WorksAsExpected()
        {
            var sys = new System56(); sys.Initialize(new System56Config()); sys.ProcessTick(1); Assert.Equal(56 + 56, sys.Val);
        }
    }
}
