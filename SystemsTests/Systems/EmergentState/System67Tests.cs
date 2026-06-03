using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System67Tests
    {
        [Fact]
        public void System67_Logic_WorksAsExpected()
        {
            var sys = new System67(); sys.Initialize(new System67Config()); sys.ProcessTick(1); Assert.Equal(67 + 67, sys.Val);
        }
    }
}
