using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System34Tests
    {
        [Fact]
        public void System34_Logic_WorksAsExpected()
        {
            var sys = new System34(); sys.Initialize(new System34Config()); sys.ProcessTick(1); Assert.Equal(34 + 34, sys.Val);
        }
    }
}
