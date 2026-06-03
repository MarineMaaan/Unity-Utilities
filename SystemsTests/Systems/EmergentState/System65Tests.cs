using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System65Tests
    {
        [Fact]
        public void System65_Logic_WorksAsExpected()
        {
            var sys = new System65(); sys.Initialize(new System65Config()); sys.ProcessTick(1); Assert.Equal(65 + 65, sys.Val);
        }
    }
}
