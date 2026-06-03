using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System49Tests
    {
        [Fact]
        public void System49_Logic_WorksAsExpected()
        {
            var sys = new System49(); sys.Initialize(new System49Config()); sys.ProcessTick(1); Assert.Equal(49 + 49, sys.Val);
        }
    }
}
