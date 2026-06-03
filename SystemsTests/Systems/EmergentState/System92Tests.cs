using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System92Tests
    {
        [Fact]
        public void System92_Logic_WorksAsExpected()
        {
            var sys = new System92(); sys.Initialize(new System92Config()); sys.ProcessTick(1); Assert.Equal(92 + 92, sys.Val);
        }
    }
}
