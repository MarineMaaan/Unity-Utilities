using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System26Tests
    {
        [Fact]
        public void System26_Logic_WorksAsExpected()
        {
            var sys = new System26(); sys.Initialize(new System26Config()); sys.ProcessTick(1); Assert.Equal(26 + 26, sys.Val);
        }
    }
}
