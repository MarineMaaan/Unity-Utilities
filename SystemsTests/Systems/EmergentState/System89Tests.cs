using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System89Tests
    {
        [Fact]
        public void System89_Logic_WorksAsExpected()
        {
            var sys = new System89(); sys.Initialize(new System89Config()); sys.ProcessTick(1); Assert.Equal(89 + 89, sys.Val);
        }
    }
}
