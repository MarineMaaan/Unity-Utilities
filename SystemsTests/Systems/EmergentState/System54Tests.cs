using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System54Tests
    {
        [Fact]
        public void System54_Logic_WorksAsExpected()
        {
            var sys = new System54(); sys.Initialize(new System54Config()); sys.ProcessTick(1); Assert.Equal(54 + 54, sys.Val);
        }
    }
}
