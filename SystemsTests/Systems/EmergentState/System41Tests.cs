using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System41Tests
    {
        [Fact]
        public void System41_Logic_WorksAsExpected()
        {
            var sys = new System41(); sys.Initialize(new System41Config()); sys.ProcessTick(1); Assert.Equal(41 + 41, sys.Val);
        }
    }
}
