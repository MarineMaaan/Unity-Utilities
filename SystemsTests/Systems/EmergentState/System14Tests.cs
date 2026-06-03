using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System14Tests
    {
        [Fact]
        public void System14_Logic_WorksAsExpected()
        {
            var sys = new System14(); sys.Initialize(new System14Config()); sys.ProcessTick(1); Assert.Equal(14 + 14, sys.Val);
        }
    }
}
