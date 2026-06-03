using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System68Tests
    {
        [Fact]
        public void System68_Logic_WorksAsExpected()
        {
            var sys = new System68(); sys.Initialize(new System68Config()); sys.ProcessTick(1); Assert.Equal(68 + 68, sys.Val);
        }
    }
}
