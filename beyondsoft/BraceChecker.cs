using System;
namespace beyondsoft
{
	public class BraceChecker
	{
		public BraceChecker()
		{
		}

		public bool isValid(string s)
		{
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }
            Stack<char> tmp = new Stack<char>();
            string openbracket = "{[(";
            string closingbracket = "}])";
            for (int i = 0; i < s.Length; i++)
            {
                if (openbracket.Contains(s[i]))
                {
                    tmp.Push(s[i]);
                }
                if (closingbracket.Contains(s[i]) && tmp.Count > 0)
                {
                    var opening = tmp.Pop();
                    if (s[i] == '}' && opening != '{')
                    {
                        return false;
                    }
                    if (s[i] == ']' && opening != '[')
                    {
                        return false;
                    }
                    if (s[i] == ')' && opening != '(')
                    {
                        return false;
                    }
                }
            }

            if(tmp.Count > 0)
            {
                return false;
            }
            return true;
        }
	}
}

