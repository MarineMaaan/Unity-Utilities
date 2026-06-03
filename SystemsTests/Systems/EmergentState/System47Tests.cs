using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System47Tests
    {
        [Fact]
        public void System47_Logic_WorksAsExpected()
        {
            var sys = new System47(); sys.Initialize(new System47Config()); sys.ProcessTick(1); Assert.Equal(47 + 47, sys.Val);
        }
    }
}
