public class Solution {
    public bool IsValid(string s) 
    {
        Dictionary<char, char> people = new Dictionary<char, char>()
        {
            { ')', '('},
            { ']', '['},
            { '}', '{'}
        };

        Stack<char> st = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                st.Push(s[i]);
            }
            else if ((s[i] == ')' || s[i] == ']' || s[i] == '}') && st.Count == 0)
            {
                return false;
            }
            else
            {
                char i1 = people[s[i]];

                if (st.Peek() == i1)
                {
                    st.Pop();
                }
                else
                {
                    st.Push(s[i]);
                }
                
                
                
            }
        }

        if(st.Count == 0)
        {
            return true;
        }
        return false;
        

    }
}