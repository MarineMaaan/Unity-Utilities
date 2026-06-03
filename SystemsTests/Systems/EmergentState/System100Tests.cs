using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System100Tests
    {
        [Fact]
        public void System100_Logic_WorksAsExpected()
        {
            var sys = new System100(); sys.Initialize(new System100Config()); sys.ProcessTick(1); Assert.Equal(100 + 100, sys.Val);
        }
    }
}
