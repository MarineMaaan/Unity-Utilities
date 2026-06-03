using Xunit;
using SystemsProject.TestGames;
namespace SystemsTests {
    public class JezzballTests {
        [Fact] public void JezzballManager_Initialization_SetsUpGame() { var manager = new JezzballManager(); manager.InitializeGame(); Assert.Equal(0, manager.Score); Assert.Equal(2, manager.Balls.Count); Assert.NotNull(manager.Player); Assert.Equal(3, manager.Player.Lives); }
        [Fact] public void Jezzball_WallCollision_ReducesLife() { var manager = new JezzballManager(); manager.InitializeGame(); var wall = new WallGenerator(); wall.StartBuilding(new Vector2(10, 10), new Vector2(1, 0)); manager.Walls.Add(wall); manager.CheckCollisions(); Assert.Equal(2, manager.Player.Lives); Assert.False(wall.IsBuilding); }
    }
}
