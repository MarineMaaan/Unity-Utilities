using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System9Tests
    {
        [Fact]
        public void System9_Logic_WorksAsExpected()
        {
            var sys = new System9(); sys.Initialize(new System9Config()); sys.ProcessTick(1); Assert.Equal(9 + 9, sys.Val);
        }
    }
}
