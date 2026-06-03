using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System72Tests
    {
        [Fact]
        public void System72_Logic_WorksAsExpected()
        {
            var sys = new System72(); sys.Initialize(new System72Config()); sys.ProcessTick(1); Assert.Equal(72 + 72, sys.Val);
        }
    }
}
