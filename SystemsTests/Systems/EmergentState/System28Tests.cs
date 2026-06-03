using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System28Tests
    {
        [Fact]
        public void System28_Logic_WorksAsExpected()
        {
            var sys = new System28(); sys.Initialize(new System28Config()); sys.ProcessTick(1); Assert.Equal(28 + 28, sys.Val);
        }
    }
}
