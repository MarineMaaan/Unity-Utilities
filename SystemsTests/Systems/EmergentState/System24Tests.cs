using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System24Tests
    {
        [Fact]
        public void System24_Logic_WorksAsExpected()
        {
            var sys = new System24(); sys.Initialize(new System24Config()); sys.ProcessTick(1); Assert.Equal(24 + 24, sys.Val);
        }
    }
}
