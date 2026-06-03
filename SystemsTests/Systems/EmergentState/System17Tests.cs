using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System17Tests
    {
        [Fact]
        public void System17_Logic_WorksAsExpected()
        {
            var sys = new System17(); sys.Initialize(new System17Config()); sys.ProcessTick(1); Assert.Equal(17 + 17, sys.Val);
        }
    }
}
