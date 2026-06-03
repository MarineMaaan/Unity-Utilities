using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System20Tests
    {
        [Fact]
        public void System20_Logic_WorksAsExpected()
        {
            var sys = new System20(); sys.Initialize(new System20Config()); sys.ProcessTick(1); Assert.Equal(20 + 20, sys.Val);
        }
    }
}
