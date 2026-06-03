using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System33Tests
    {
        [Fact]
        public void System33_Logic_WorksAsExpected()
        {
            var sys = new System33(); sys.Initialize(new System33Config()); sys.ProcessTick(1); Assert.Equal(33 + 33, sys.Val);
        }
    }
}
