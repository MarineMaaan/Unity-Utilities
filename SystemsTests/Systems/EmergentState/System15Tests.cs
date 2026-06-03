using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System15Tests
    {
        [Fact]
        public void System15_Logic_WorksAsExpected()
        {
            var sys = new System15(); sys.Initialize(new System15Config()); sys.ProcessTick(1); Assert.Equal(15 + 15, sys.Val);
        }
    }
}
