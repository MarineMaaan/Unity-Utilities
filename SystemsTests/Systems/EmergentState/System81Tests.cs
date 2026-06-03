using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System81Tests
    {
        [Fact]
        public void System81_Logic_WorksAsExpected()
        {
            var sys = new System81(); sys.Initialize(new System81Config()); sys.ProcessTick(1); Assert.Equal(81 + 81, sys.Val);
        }
    }
}
