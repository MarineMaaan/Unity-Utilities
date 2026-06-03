using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System69Tests
    {
        [Fact]
        public void System69_Logic_WorksAsExpected()
        {
            var sys = new System69(); sys.Initialize(new System69Config()); sys.ProcessTick(1); Assert.Equal(69 + 69, sys.Val);
        }
    }
}
