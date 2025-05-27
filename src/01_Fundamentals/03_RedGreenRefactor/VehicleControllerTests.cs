using _RedGreenRefactor;

namespace _03_RedGreenRefactor;

public class VehicleControllerTests
{
    [Fact]
    public void IsValid_CoolerAndEngineEnabled_ReturnsTrue()
    {
        // Arrange
        var controller = new VehicleController();

        // Act
        var result = controller.IsValid(VehicleState.Cooler | VehicleState.Engine);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValid_CoolerAndEngineDisabled_ReturnsFalse()
    {
        // Arrange
        var controller = new VehicleController();
        
        // Act
        var result = controller.IsValid(VehicleState.None);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValid_CoolerEnabled_ReturnsFalse()
    {
        // Arrange
        var controller = new VehicleController();
        
        // Act
        var result = controller.IsValid(VehicleState.Cooler);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValid_EngineEnabled_ReturnsFalse()
    {
        // Arrange
        var controller = new VehicleController();
        
        // Act
        var result = controller.IsValid(VehicleState.Engine);
        
        // Assert
        Assert.False(result);
        
    }
}