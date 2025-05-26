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