using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System37Tests
    {
        [Fact]
        public void System37_Logic_WorksAsExpected()
        {
            var sys = new System37(); sys.Initialize(new System37Config()); sys.ProcessTick(1); Assert.Equal(37 + 37, sys.Val);
        }
    }
}
