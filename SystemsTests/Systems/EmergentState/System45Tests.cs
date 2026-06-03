using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System45Tests
    {
        [Fact]
        public void System45_Logic_WorksAsExpected()
        {
            var sys = new System45(); sys.Initialize(new System45Config()); sys.ProcessTick(1); Assert.Equal(45 + 45, sys.Val);
        }
    }
}
