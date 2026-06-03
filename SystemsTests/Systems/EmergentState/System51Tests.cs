using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System51Tests
    {
        [Fact]
        public void System51_Logic_WorksAsExpected()
        {
            var sys = new System51(); sys.Initialize(new System51Config()); sys.ProcessTick(1); Assert.Equal(51 + 51, sys.Val);
        }
    }
}
