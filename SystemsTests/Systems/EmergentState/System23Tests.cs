using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System23Tests
    {
        [Fact]
        public void System23_Logic_WorksAsExpected()
        {
            var sys = new System23(); sys.Initialize(new System23Config()); sys.ProcessTick(1); Assert.Equal(23 + 23, sys.Val);
        }
    }
}
