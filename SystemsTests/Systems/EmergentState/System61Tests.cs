using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System61Tests
    {
        [Fact]
        public void System61_Logic_WorksAsExpected()
        {
            var sys = new System61(); sys.Initialize(new System61Config()); sys.ProcessTick(1); Assert.Equal(61 + 61, sys.Val);
        }
    }
}
