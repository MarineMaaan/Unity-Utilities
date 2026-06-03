using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System3Tests
    {
        [Fact]
        public void System3_Logic_WorksAsExpected()
        {
            var sys = new System3(); sys.Initialize(new System3Config()); sys.ProcessTick(1); Assert.Equal(3 + 3, sys.Val);
        }
    }
}
