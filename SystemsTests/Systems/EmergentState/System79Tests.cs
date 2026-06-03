using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System79Tests
    {
        [Fact]
        public void System79_Logic_WorksAsExpected()
        {
            var sys = new System79(); sys.Initialize(new System79Config()); sys.ProcessTick(1); Assert.Equal(79 + 79, sys.Val);
        }
    }
}
