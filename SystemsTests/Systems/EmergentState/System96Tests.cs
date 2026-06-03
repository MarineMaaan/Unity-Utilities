using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System96Tests
    {
        [Fact]
        public void System96_Logic_WorksAsExpected()
        {
            var sys = new System96(); sys.Initialize(new System96Config()); sys.ProcessTick(1); Assert.Equal(96 + 96, sys.Val);
        }
    }
}
