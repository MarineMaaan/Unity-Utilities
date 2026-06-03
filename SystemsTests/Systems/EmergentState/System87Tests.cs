using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System87Tests
    {
        [Fact]
        public void System87_Logic_WorksAsExpected()
        {
            var sys = new System87(); sys.Initialize(new System87Config()); sys.ProcessTick(1); Assert.Equal(87 + 87, sys.Val);
        }
    }
}
