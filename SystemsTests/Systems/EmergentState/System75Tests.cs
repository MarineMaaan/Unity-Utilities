using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System75Tests
    {
        [Fact]
        public void System75_Logic_WorksAsExpected()
        {
            var sys = new System75(); sys.Initialize(new System75Config()); sys.ProcessTick(1); Assert.Equal(75 + 75, sys.Val);
        }
    }
}
