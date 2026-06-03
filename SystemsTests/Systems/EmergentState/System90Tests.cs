using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System90Tests
    {
        [Fact]
        public void System90_Logic_WorksAsExpected()
        {
            var sys = new System90(); sys.Initialize(new System90Config()); sys.ProcessTick(1); Assert.Equal(90 + 90, sys.Val);
        }
    }
}
