using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System88Tests
    {
        [Fact]
        public void System88_Logic_WorksAsExpected()
        {
            var sys = new System88(); sys.Initialize(new System88Config()); sys.ProcessTick(1); Assert.Equal(88 + 88, sys.Val);
        }
    }
}
