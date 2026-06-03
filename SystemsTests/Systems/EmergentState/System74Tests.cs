using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System74Tests
    {
        [Fact]
        public void System74_Logic_WorksAsExpected()
        {
            var sys = new System74(); sys.Initialize(new System74Config()); sys.ProcessTick(1); Assert.Equal(74 + 74, sys.Val);
        }
    }
}
