using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System63Tests
    {
        [Fact]
        public void System63_Logic_WorksAsExpected()
        {
            var sys = new System63(); sys.Initialize(new System63Config()); sys.ProcessTick(1); Assert.Equal(63 + 63, sys.Val);
        }
    }
}
