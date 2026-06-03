using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System39Tests
    {
        [Fact]
        public void System39_Logic_WorksAsExpected()
        {
            var sys = new System39(); sys.Initialize(new System39Config()); sys.ProcessTick(1); Assert.Equal(39 + 39, sys.Val);
        }
    }
}
