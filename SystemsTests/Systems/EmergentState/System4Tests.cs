using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System4Tests
    {
        [Fact]
        public void System4_Logic_WorksAsExpected()
        {
            var sys = new System4(); sys.Initialize(new System4Config()); sys.ProcessTick(1); Assert.Equal(4 + 4, sys.Val);
        }
    }
}
