using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System91Tests
    {
        [Fact]
        public void System91_Logic_WorksAsExpected()
        {
            var sys = new System91(); sys.Initialize(new System91Config()); sys.ProcessTick(1); Assert.Equal(91 + 91, sys.Val);
        }
    }
}
