using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System64Tests
    {
        [Fact]
        public void System64_Logic_WorksAsExpected()
        {
            var sys = new System64(); sys.Initialize(new System64Config()); sys.ProcessTick(1); Assert.Equal(64 + 64, sys.Val);
        }
    }
}
