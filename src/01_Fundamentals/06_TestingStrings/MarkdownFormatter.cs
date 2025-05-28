using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingStrings;

// Markdown syntax
// https://www.markdownguide.org/basic-syntax/

public class MarkdownFormatter
{
    public string FormatAsBold(string content)
    {
        return $"**{content}**";
    }
}


// TODO: Dodaj kolejne formatowania Italic, Header i Hiperlink

public class MarkdownFormatterTests
{
    private const string DoubleAsterix = "**";
    
    [Theory]
    [InlineData("a")]
    [InlineData("Lorem ipsum")]
    [InlineData("Lorem*ipsum")]
    public void FormatAsBold_NotEmptyContent_ReturnsAroundedByDoubleAsterix(string content)
    {
        // Arrange
        var formatter = new MarkdownFormatter();
        
        // Act
        var result = formatter.FormatAsBold(content);
        
        // Assert
        Assert.StartsWith(DoubleAsterix, result);
        Assert.Contains(content, result);
        Assert.EndsWith(DoubleAsterix, result);
    }
}