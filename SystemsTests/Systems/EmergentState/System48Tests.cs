using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System48Tests
    {
        [Fact]
        public void System48_Logic_WorksAsExpected()
        {
            var sys = new System48(); sys.Initialize(new System48Config()); sys.ProcessTick(1); Assert.Equal(48 + 48, sys.Val);
        }
    }
}
