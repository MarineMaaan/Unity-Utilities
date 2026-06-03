using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System19Tests
    {
        [Fact]
        public void System19_Logic_WorksAsExpected()
        {
            var sys = new System19(); sys.Initialize(new System19Config()); sys.ProcessTick(1); Assert.Equal(19 + 19, sys.Val);
        }
    }
}
