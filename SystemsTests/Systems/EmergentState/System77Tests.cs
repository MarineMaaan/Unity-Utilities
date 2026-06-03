using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System77Tests
    {
        [Fact]
        public void System77_Logic_WorksAsExpected()
        {
            var sys = new System77(); sys.Initialize(new System77Config()); sys.ProcessTick(1); Assert.Equal(77 + 77, sys.Val);
        }
    }
}
