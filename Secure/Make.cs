namespace Secure
{
    public class Make
    {
        public static string encrypt(string text, string password)
        {
            int textLength = text.Length;
            int passwordLength = password.Length;

            char[] buffer = new char[textLength];

            for(int i= 0; i < textLength; i++)
            {
                buffer[i] = (char)(text[i] ^ password[i%passwordLength]);
            }
            return new string(buffer);
        }

        public static string decrypt(string text, string password)
        {
            return encrypt(text,password);
        }
    }
    
}