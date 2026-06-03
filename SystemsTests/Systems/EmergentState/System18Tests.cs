using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System18Tests
    {
        [Fact]
        public void System18_Logic_WorksAsExpected()
        {
            var sys = new System18(); sys.Initialize(new System18Config()); sys.ProcessTick(1); Assert.Equal(18 + 18, sys.Val);
        }
    }
}
