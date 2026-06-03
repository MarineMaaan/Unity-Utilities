using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System85Tests
    {
        [Fact]
        public void System85_Logic_WorksAsExpected()
        {
            var sys = new System85(); sys.Initialize(new System85Config()); sys.ProcessTick(1); Assert.Equal(85 + 85, sys.Val);
        }
    }
}
