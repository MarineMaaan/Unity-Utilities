using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System76Tests
    {
        [Fact]
        public void System76_Logic_WorksAsExpected()
        {
            var sys = new System76(); sys.Initialize(new System76Config()); sys.ProcessTick(1); Assert.Equal(76 + 76, sys.Val);
        }
    }
}
