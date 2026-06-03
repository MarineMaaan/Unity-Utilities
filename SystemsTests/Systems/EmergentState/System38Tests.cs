using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System38Tests
    {
        [Fact]
        public void System38_Logic_WorksAsExpected()
        {
            var sys = new System38(); sys.Initialize(new System38Config()); sys.ProcessTick(1); Assert.Equal(38 + 38, sys.Val);
        }
    }
}
