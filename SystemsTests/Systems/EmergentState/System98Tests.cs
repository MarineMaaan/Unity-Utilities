using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System98Tests
    {
        [Fact]
        public void System98_Logic_WorksAsExpected()
        {
            var sys = new System98(); sys.Initialize(new System98Config()); sys.ProcessTick(1); Assert.Equal(98 + 98, sys.Val);
        }
    }
}
