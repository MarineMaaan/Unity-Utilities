using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System62Tests
    {
        [Fact]
        public void System62_Logic_WorksAsExpected()
        {
            var sys = new System62(); sys.Initialize(new System62Config()); sys.ProcessTick(1); Assert.Equal(62 + 62, sys.Val);
        }
    }
}
