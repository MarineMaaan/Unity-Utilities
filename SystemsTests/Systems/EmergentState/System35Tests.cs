using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System35Tests
    {
        [Fact]
        public void System35_Logic_WorksAsExpected()
        {
            var sys = new System35(); sys.Initialize(new System35Config()); sys.ProcessTick(1); Assert.Equal(35 + 35, sys.Val);
        }
    }
}
