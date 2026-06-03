using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System83Tests
    {
        [Fact]
        public void System83_Logic_WorksAsExpected()
        {
            var sys = new System83(); sys.Initialize(new System83Config()); sys.ProcessTick(1); Assert.Equal(83 + 83, sys.Val);
        }
    }
}
