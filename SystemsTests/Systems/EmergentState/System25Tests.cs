using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System25Tests
    {
        [Fact]
        public void System25_Logic_WorksAsExpected()
        {
            var sys = new System25(); sys.Initialize(new System25Config()); sys.ProcessTick(1); Assert.Equal(25 + 25, sys.Val);
        }
    }
}
