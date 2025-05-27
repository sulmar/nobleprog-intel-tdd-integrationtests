namespace PathBasedTesting;

public class RentTests
{
    [Fact]
    public void CanReturn_UserIsRentee_ReturnsTrue()
    {
        // Arrange
        var rentee = new User { IsAdmin = false };   
        var rent = new Rent { Rentee = rentee };
        
        // Act
        var result = rent.CanReturn(rentee);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanReturn_UserIsAdminAndNotRentee_ReturnsTrue()
    {
        // Arrange
        var admin = new User { IsAdmin = true };   
        var rent = new Rent { Rentee = new User() };
        
        // Act
        var result = rent.CanReturn(admin);
        
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void CanReturn_UserIsAdminAndRentee_ReturnsTrue()
    {
        // Arrange
        var admin = new User { IsAdmin = true };   
        var rent = new Rent { Rentee = admin };
        
        // Act
        var result = rent.CanReturn(admin);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanReturn_UserIsEmpty_ThrowsArgumentNullException()
    {
        // Arrange
        var rent = new Rent();
        
        // Act
        Action act = () => rent.CanReturn(null);

        // Assert
        Assert.Throws<ArgumentNullException>(act);
    }

    [Fact]
    public void CanReturn_UserIsNotRenteeAndIsNotAdmin_ReturnsFalse()
    {
        // Arrange
        var rentee = new User { IsAdmin = false };  
        var rent = new Rent { Rentee = new User() };
        
        // Act
        var result = rent.CanReturn(rentee);
        
        // Assert
        Assert.False(result);
    }
    
}
