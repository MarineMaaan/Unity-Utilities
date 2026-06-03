using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System46Tests
    {
        [Fact]
        public void System46_Logic_WorksAsExpected()
        {
            var sys = new System46(); sys.Initialize(new System46Config()); sys.ProcessTick(1); Assert.Equal(46 + 46, sys.Val);
        }
    }
}
