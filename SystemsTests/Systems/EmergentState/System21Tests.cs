using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System21Tests
    {
        [Fact]
        public void System21_Logic_WorksAsExpected()
        {
            var sys = new System21(); sys.Initialize(new System21Config()); sys.ProcessTick(1); Assert.Equal(21 + 21, sys.Val);
        }
    }
}
