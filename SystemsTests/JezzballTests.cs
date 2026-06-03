using Xunit;
using SystemsProject.TestGames;
namespace SystemsTests {
    public class JezzballTests {
        [Fact] public void JezzballManager_Initialization_SetsUpGame() { var manager = new JezzballManager(); manager.InitializeGame(); Assert.Equal(0, manager.Score); Assert.Equal(2, manager.Balls.Count); Assert.NotNull(manager.Player); Assert.Equal(3, manager.Player.Lives); }
        [Fact] public void Jezzball_WallCollision_ReducesLife() { var manager = new JezzballManager(); manager.InitializeGame(); var wall = new WallGenerator(); wall.StartBuilding(new Vector2(10, 10), new Vector2(1, 0)); manager.Walls.Add(wall); manager.CheckCollisions(); Assert.Equal(2, manager.Player.Lives); Assert.False(wall.IsBuilding); }

        [Fact]
        public void WallGenerator_StartBuilding_SetsProperties() {
            var wall = new WallGenerator();
            var start = new Vector2(5, 5);
            var dir = new Vector2(0, 1);

            wall.StartBuilding(start, dir);

            Assert.True(wall.IsBuilding);
            Assert.Equal(start.x, wall.startPosition.x);
            Assert.Equal(start.y, wall.startPosition.y);
            Assert.Equal(start.x, wall.currentPosition.x);
            Assert.Equal(start.y, wall.currentPosition.y);
            Assert.Equal(dir.x, wall.direction.x);
            Assert.Equal(dir.y, wall.direction.y);
        }

        [Fact]
        public void WallGenerator_UpdateWall_UpdatesPositionWhenBuilding() {
            var wall = new WallGenerator();
            var start = new Vector2(5, 5);
            var dir = new Vector2(1, 0); // moving right

            wall.StartBuilding(start, dir);
            wall.UpdateWall(0.5f, 10.0f); // dt=0.5, speed=10

            Assert.Equal(10.0f, wall.currentPosition.x);
            Assert.Equal(5.0f, wall.currentPosition.y);
        }

        [Fact]
        public void WallGenerator_UpdateWall_DoesNotUpdateWhenNotBuilding() {
            var wall = new WallGenerator();
            var start = new Vector2(5, 5);
            var dir = new Vector2(1, 0);

            wall.StartBuilding(start, dir);
            wall.DestroyWall(); // sets IsBuilding to false

            wall.UpdateWall(0.5f, 10.0f);

            Assert.Equal(5.0f, wall.currentPosition.x);
            Assert.Equal(5.0f, wall.currentPosition.y);
        }

        [Fact]
        public void WallGenerator_DestroyWall_SetsIsBuildingToFalse() {
            var wall = new WallGenerator();
            wall.StartBuilding(new Vector2(0, 0), new Vector2(1, 0));
            Assert.True(wall.IsBuilding);

            wall.DestroyWall();

            Assert.False(wall.IsBuilding);
        }
        [Fact] public void JezzballManager_OnAreaCaptured_UpdatesScoreAndArea() {
            var manager = new JezzballManager();
            manager.InitializeGame();
            float initialArea = manager.PlayAreaArea;
            float captured1 = 50.5f;
            float captured2 = 20.2f;
            manager.OnAreaCaptured(captured1);
            Assert.Equal(initialArea - captured1, manager.PlayAreaArea);
            Assert.Equal(50, manager.Score);
            manager.OnAreaCaptured(captured2);
            Assert.Equal(initialArea - captured1 - captured2, manager.PlayAreaArea);
            Assert.Equal(70, manager.Score);
        }
        [Fact] public void BallController_UpdatePosition_UpdatesCorrectly() { var ball = new BallController { position = new Vector2(0, 0), velocity = new Vector2(2, 3) }; ball.UpdatePosition(0.5f); Assert.Equal(1.0f, ball.position.x); Assert.Equal(1.5f, ball.position.y); }
        [Fact] public void BallController_UpdatePosition_NegativeVelocity() { var ball = new BallController { position = new Vector2(10, 10), velocity = new Vector2(-2, -4) }; ball.UpdatePosition(2.0f); Assert.Equal(6.0f, ball.position.x); Assert.Equal(2.0f, ball.position.y); }
        [Fact] public void BallController_UpdatePosition_ZeroVelocity() { var ball = new BallController { position = new Vector2(5, 5), velocity = new Vector2(0, 0) }; ball.UpdatePosition(1.0f); Assert.Equal(5.0f, ball.position.x); Assert.Equal(5.0f, ball.position.y); }
    }
}
