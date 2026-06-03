using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System1Tests
    {
        [Fact]
        public void System1_Logic_WorksAsExpected()
        {
            var sys = new System1(); sys.Initialize(new System1Config()); sys.ProcessTick(1); Assert.Equal(1 + 1, sys.Val);
        }
    }
}
