using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System11Tests
    {
        [Fact]
        public void System11_Logic_WorksAsExpected()
        {
            var sys = new System11(); sys.Initialize(new System11Config()); sys.ProcessTick(1); Assert.Equal(11 + 11, sys.Val);
        }
    }
}
