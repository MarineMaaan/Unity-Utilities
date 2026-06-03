using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System86Tests
    {
        [Fact]
        public void System86_Logic_WorksAsExpected()
        {
            var sys = new System86(); sys.Initialize(new System86Config()); sys.ProcessTick(1); Assert.Equal(86 + 86, sys.Val);
        }
    }
}
