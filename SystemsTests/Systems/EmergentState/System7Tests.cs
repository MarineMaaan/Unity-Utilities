using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System7Tests
    {
        [Fact]
        public void System7_Logic_WorksAsExpected()
        {
            var sys = new System7(); sys.Initialize(new System7Config()); sys.ProcessTick(1); Assert.Equal(7 + 7, sys.Val);
        }
    }
}
