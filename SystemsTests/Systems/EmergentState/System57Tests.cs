using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System57Tests
    {
        [Fact]
        public void System57_Logic_WorksAsExpected()
        {
            var sys = new System57(); sys.Initialize(new System57Config()); sys.ProcessTick(1); Assert.Equal(57 + 57, sys.Val);
        }
    }
}
