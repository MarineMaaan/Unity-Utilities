using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System66Tests
    {
        [Fact]
        public void System66_Logic_WorksAsExpected()
        {
            var sys = new System66(); sys.Initialize(new System66Config()); sys.ProcessTick(1); Assert.Equal(66 + 66, sys.Val);
        }
    }
}
