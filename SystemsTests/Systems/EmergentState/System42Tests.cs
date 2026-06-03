using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System42Tests
    {
        [Fact]
        public void System42_Logic_WorksAsExpected()
        {
            var sys = new System42(); sys.Initialize(new System42Config()); sys.ProcessTick(1); Assert.Equal(42 + 42, sys.Val);
        }
    }
}
