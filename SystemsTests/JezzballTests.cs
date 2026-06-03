using Xunit;
using SystemsProject.TestGames;
namespace SystemsTests {
    public class JezzballTests {
        [Fact] public void JezzballManager_Initialization_SetsUpGame() { var manager = new JezzballManager(); manager.InitializeGame(); Assert.Equal(0, manager.Score); Assert.Equal(2, manager.Balls.Count); Assert.NotNull(manager.Player); Assert.Equal(3, manager.Player.Lives); }
        [Fact] public void Jezzball_WallCollision_ReducesLife() { var manager = new JezzballManager(); manager.InitializeGame(); var wall = new WallGenerator(); wall.StartBuilding(new Vector2(10, 10), new Vector2(1, 0)); manager.Walls.Add(wall); manager.CheckCollisions(); Assert.Equal(2, manager.Player.Lives); Assert.False(wall.IsBuilding); }
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
    }
}
