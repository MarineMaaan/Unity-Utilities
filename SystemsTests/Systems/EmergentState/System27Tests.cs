using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System27Tests
    {
        [Fact]
        public void System27_Logic_WorksAsExpected()
        {
            var sys = new System27(); sys.Initialize(new System27Config()); sys.ProcessTick(1); Assert.Equal(27 + 27, sys.Val);
        }
    }
}
