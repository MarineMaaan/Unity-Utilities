using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System22Tests
    {
        [Fact]
        public void System22_Logic_WorksAsExpected()
        {
            var sys = new System22(); sys.Initialize(new System22Config()); sys.ProcessTick(1); Assert.Equal(22 + 22, sys.Val);
        }
    }
}
