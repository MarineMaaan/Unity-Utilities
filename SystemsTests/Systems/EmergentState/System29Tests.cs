using Xunit;
using SystemsProject.EmergentState;
using UnityEngine;
using System.Collections.Generic;

namespace SystemsTests.EmergentState
{
    public class System29Tests
    {
        [Fact]
        public void System29_Logic_WorksAsExpected()
        {
            var sys = new System29(); sys.Initialize(new System29Config()); sys.ProcessTick(1); Assert.Equal(29 + 29, sys.Val);
        }
    }
}
