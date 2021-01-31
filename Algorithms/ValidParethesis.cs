namespace Algorithms
{
    public static class ValidPaarethesis
    {
        public static bool Run(string input)
        {
            var stack = new char[input.Length + 1];
            stack[0] = ' ';

            int j = 0;
            for(int i = 0; i < input.Length; i++)
            {
                var c = input[i];
                if (c == '{' || c == '[' || c == '(')
                {
                    stack[++j] = c;
                }
                else
                {
                    var last = stack[j];
                    if (c == ')' && last != '(') return false;
                    else if (c == ']' && last != '[') return false;
                    else if (c == '}' && last != '{') return false;
                    j--;
                }
            }

            return j == 0;
        }
    }
}
