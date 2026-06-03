using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System93Tests
    {
        [Fact]
        public void System93_Logic_WorksAsExpected()
        {
            var sys = new System93(); sys.Initialize(new System93Config()); sys.ProcessTick(1); Assert.Equal(93 + 93, sys.Val);
        }
    }
}
