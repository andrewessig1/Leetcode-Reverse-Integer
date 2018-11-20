public class Solution {
    public int Reverse(int x) {
            try
            {
                char[] c = x.ToString().ToCharArray();
                char hold;
                //Reverse negative integer
                if (c[0] == '-')
                {
                    for (int i = 1; i < (c.Length + 1) / 2; i++)
                    {
                        hold = c[i];
                        c[i] = c[c.Length - i];
                        c[c.Length - i] = hold;
                    }
                }
                //Reverse positive integer
                else
                {
                    for (int y = 0; y < c.Length / 2; y++)
                    {
                        hold = c[y];
                        c[y] = c[c.Length - 1 - y];
                        c[c.Length - 1 - y] = hold;
                    }
                }
                return Int32.Parse(new string(c));
            }
            //Per instructions, return 0 on overflow
            catch (OverflowException ex)
            {
                return 0;
            }   
    }
}
