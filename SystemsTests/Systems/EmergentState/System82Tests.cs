using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System82Tests
    {
        [Fact]
        public void System82_Logic_WorksAsExpected()
        {
            var sys = new System82(); sys.Initialize(new System82Config()); sys.ProcessTick(1); Assert.Equal(82 + 82, sys.Val);
        }
    }
}
