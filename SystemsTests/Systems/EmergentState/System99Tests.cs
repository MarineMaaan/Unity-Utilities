using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System99Tests
    {
        [Fact]
        public void System99_Logic_WorksAsExpected()
        {
            var sys = new System99(); sys.Initialize(new System99Config()); sys.ProcessTick(1); Assert.Equal(99 + 99, sys.Val);
        }
    }
}
