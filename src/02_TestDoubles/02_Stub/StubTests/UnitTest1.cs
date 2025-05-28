namespace StubTests;

public class TrackingServiceTests
{
    [Fact]
    public void Get_ValidFile_ReturnsLocation()
    {
        // Arrange
        TrackingService service = new TrackingService(new StubValidFileReader());
        
        // Act
        var location = service.Get();

        // Assert
        Assert.NotNull(location);
        Assert.Equal(21.01, location.Latitude);
        Assert.Equal(52.01, location.Longitude);

    }

    [Fact]
    public void Get_InvalidFile_ThrowsException()
    {
        // Arrange
        TrackingService service = new TrackingService(new StubInvalidFileReader());
        
        // Act & Assert
        Assert.Throws<ApplicationException>( () => service.Get());
        
    }
}