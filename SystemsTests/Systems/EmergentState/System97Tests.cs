using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System97Tests
    {
        [Fact]
        public void System97_Logic_WorksAsExpected()
        {
            var sys = new System97(); sys.Initialize(new System97Config()); sys.ProcessTick(1); Assert.Equal(97 + 97, sys.Val);
        }
    }
}
