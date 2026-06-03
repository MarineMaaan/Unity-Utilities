using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System12Tests
    {
        [Fact]
        public void System12_Logic_WorksAsExpected()
        {
            var sys = new System12(); sys.Initialize(new System12Config()); sys.ProcessTick(1); Assert.Equal(12 + 12, sys.Val);
        }
    }
}
