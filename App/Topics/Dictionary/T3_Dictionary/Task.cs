using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace App.Topics.Dictionary.T3_Dictionary;

public static class DictionaryTasks’
{
    public static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, int>>
    TopNWords(string text, int n)
    {
        string _text = text;
        string _textLower;
        int _n = n;
        int count = 0;
        System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

        if (_text == null || _text == "") throw new ArgumentNullException(nameof(text));
        if (_n <= 0) throw new ArgumentNullException($"{n}");
        _textLower = _text.ToLower();
        for (int i = 0; i < _textLower.Length; i++) 
        {
            if (char.IsLetterOrDigit(_textLower[i]) == false)
            {

            }
        }
    }
}