using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System36Tests
    {
        [Fact]
        public void System36_Logic_WorksAsExpected()
        {
            var sys = new System36(); sys.Initialize(new System36Config()); sys.ProcessTick(1); Assert.Equal(36 + 36, sys.Val);
        }
    }
}
