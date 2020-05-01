using FastColoredTextBoxNS;
using System;
using System.Text.RegularExpressions;

class InsertSpaceSnippet : AutocompleteItem
{
    string pattern;

    public InsertSpaceSnippet(string pattern) : base("")
    {
        this.pattern = pattern;
    }

    public InsertSpaceSnippet()
        : this(@"^(\d+)([a-zA-Z_]+)(\d*)$")
    {
    }

    public override CompareResult Compare(string fragmentText)
    {
        if (Regex.IsMatch(fragmentText, pattern))
        {
            Text = InsertSpaces(fragmentText);
            if (Text != fragmentText)
                return CompareResult.Visible;
        }
        return CompareResult.Hidden;
    }

    public string InsertSpaces(string fragment)
    {
        var m = Regex.Match(fragment, pattern);
        if (m == null)
            return fragment;
        if (m.Groups[1].Value == "" && m.Groups[3].Value == "")
            return fragment;
        return (m.Groups[1].Value + " " + m.Groups[2].Value + " " + m.Groups[3].Value).Trim();
    }

    public override string ToolTipTitle
    {
        get
        {
            return Text;
        }
    }
}
class DeclarationSnippet : SnippetAutocompleteItem
{
    public DeclarationSnippet(string snippet)
        : base(snippet)
    {
    }

    public override CompareResult Compare(string fragmentText)
    {
        var pattern = Regex.Escape(fragmentText);
        if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
            return CompareResult.Visible;
        return CompareResult.Hidden;
    }
}

class InsertEnterSnippet : AutocompleteItem
{
    Place enterPlace = Place.Empty;

    public InsertEnterSnippet()
        : base("[Line break]")
    {
    }

    public override CompareResult Compare(string fragmentText)
    {
        var r = Parent.Fragment.Clone();
        while (r.Start.iChar > 0)
        {
            if (r.CharBeforeStart == '}')
            {
                enterPlace = r.Start;
                return CompareResult.Visible;
            }

            r.GoLeftThroughFolded();
        }

        return CompareResult.Hidden;
    }

    public override string GetTextForReplace()
    {
        //extend range
        Range r = Parent.Fragment;
        Place end = r.End;
        r.Start = enterPlace;
        r.End = r.End;
        //insert line break
        return Environment.NewLine + r.Text;
    }

    public override void OnSelected(AutocompleteMenu popupMenu, SelectedEventArgs e)
    {
        base.OnSelected(popupMenu, e);
        if (Parent.Fragment.tb.AutoIndent)
            Parent.Fragment.tb.DoAutoIndent();
    }

    public override string ToolTipTitle
    {
        get
        {
            return "Insert line break after '}'";
        }
    }
}