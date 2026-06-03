using System;
using System.Diagnostics;
using Xunit;
using SystemsProject.TestGames;

namespace SystemsTests {
    public class BenchmarkTest {
        [Fact]
        public void BenchmarkCheckCollisions() {
            var manager = new JezzballManager();
            manager.InitializeGame();

            // Add lots of balls and walls
            for (int i = 0; i < 1000; i++) {
                manager.Balls.Add(new BallController { position = new Vector2(i, i), velocity = new Vector2(1, 1) });
            }
            for (int i = 0; i < 1000; i++) {
                var wall = new WallGenerator();
                wall.StartBuilding(new Vector2(i+2, i+2), new Vector2(1, 0));
                manager.Walls.Add(wall);
            }

            var sw = Stopwatch.StartNew();
            for (int i = 0; i < 100; i++) {
                manager.CheckCollisions();
            }
            sw.Stop();
            Console.WriteLine($"CheckCollisions took {sw.ElapsedMilliseconds}ms");
        }
    }
}
