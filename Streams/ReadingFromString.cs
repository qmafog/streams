namespace Streams
{
#pragma warning disable

    public static class ReadingFromString
    {
        public static string ReadAllStreamContent(StringReader stringReader)
        {
            return stringReader.ReadToEnd();
        }

        public static string ReadCurrentLine(StringReader stringReader)
        {
            return stringReader.ReadLine();
        }

        public static bool ReadNextCharacter(StringReader stringReader, out char currentChar)
        {
            char peekedChar = Convert.ToChar(stringReader.Read());
            if (peekedChar != ' ')
            {
                currentChar = peekedChar;
                return true;
            }
            else
            {
                currentChar = default;
                return false;
            }
        }

        public static bool PeekNextCharacter(StringReader stringReader, out char currentChar)
        {
            char peekedChar = Convert.ToChar(stringReader.Peek());
            if (peekedChar != ' ')
            {
                currentChar = peekedChar;
                return true;
            }
            else
            {
                currentChar = default;
                return false;
            }
        }

        public static char[] ReadCharactersToBuffer(StringReader stringReader, int count)
        {
            char peekedChar;
            char[] block = new char[count];
            for (int i = 0; i < count; i++)
            {
                peekedChar = Convert.ToChar(stringReader.Read());
                block[i] = peekedChar;
            }

            return block;
        }
    }
}
