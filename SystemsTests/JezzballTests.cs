using Xunit;
using SystemsProject.TestGames;
namespace SystemsTests {
    public class JezzballTests {
        [Fact] public void JezzballManager_Initialization_SetsUpGame() { var manager = new JezzballManager(); manager.InitializeGame(); Assert.Equal(0, manager.Score); Assert.Equal(2, manager.Balls.Count); Assert.NotNull(manager.Player); Assert.Equal(3, manager.Player.Lives); }
        [Fact] public void Jezzball_WallCollision_ReducesLife() { var manager = new JezzballManager(); manager.InitializeGame(); var wall = new WallGenerator(); wall.StartBuilding(new Vector2(10, 10), new Vector2(1, 0)); manager.Walls.Add(wall); manager.CheckCollisions(); Assert.Equal(2, manager.Player.Lives); Assert.False(wall.IsBuilding); }
        [Fact] public void BallController_UpdatePosition_UpdatesCorrectly() { var ball = new BallController { position = new Vector2(0, 0), velocity = new Vector2(2, 3) }; ball.UpdatePosition(0.5f); Assert.Equal(1.0f, ball.position.x); Assert.Equal(1.5f, ball.position.y); }
        [Fact] public void BallController_UpdatePosition_NegativeVelocity() { var ball = new BallController { position = new Vector2(10, 10), velocity = new Vector2(-2, -4) }; ball.UpdatePosition(2.0f); Assert.Equal(6.0f, ball.position.x); Assert.Equal(2.0f, ball.position.y); }
        [Fact] public void BallController_UpdatePosition_ZeroVelocity() { var ball = new BallController { position = new Vector2(5, 5), velocity = new Vector2(0, 0) }; ball.UpdatePosition(1.0f); Assert.Equal(5.0f, ball.position.x); Assert.Equal(5.0f, ball.position.y); }
    }
}
