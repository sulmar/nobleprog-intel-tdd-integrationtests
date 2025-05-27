namespace PathBasedTesting;

public class RentTests
{
    private Rent rent;

    public RentTests()
    {
        rent = new Rent { Rentee = new User() };
    }
    
    [Fact]
    public void CanReturn_UserIsRentee_ReturnsTrue()
    {
        // Arrange
        var rentee = new User { IsAdmin = false };   
        rent.Rentee = rentee;
        
        // Act
        var result = rent.CanReturn(rentee);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanReturn_UserIsAdminAndNotRentee_ReturnsTrue()
    {
        // Act
        var result = rent.CanReturn(new User { IsAdmin = true });
        
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void CanReturn_UserIsAdminAndRentee_ReturnsTrue()
    {
        // Arrange
        var admin = new User { IsAdmin = true };   
        rent.Rentee = admin;
        
        // Act
        var result = rent.CanReturn(admin);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanReturn_UserIsEmpty_ThrowsArgumentNullException()
    {
        // Act
        Action act = () => rent.CanReturn(null);

        // Assert
        Assert.Throws<ArgumentNullException>(act);
    }

    [Fact]
    public void CanReturn_UserIsNotRenteeAndIsNotAdmin_ReturnsFalse()
    {
        // Act
        var result = rent.CanReturn(new User());
        
        // Assert
        Assert.False(result);
    }
    
}
