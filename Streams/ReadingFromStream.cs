using System.Text;
#pragma warning disable

namespace Streams
{
    public static class ReadingFromStream
    {
        public static string ReadAllStreamContent(StreamReader streamReader)
        {
            return streamReader.ReadToEnd();
        }

        public static string[] ReadLineByLine(StreamReader streamReader)
        {
            List<string> lines = new List<string>();

            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines.ToArray();
        }

        public static StringBuilder ReadOnlyLettersAndNumbers(StreamReader streamReader)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int character;
            while ((character = streamReader.Read()) != -1)
            {
                if (char.IsLetterOrDigit((char)character))
                {
                    stringBuilder.Append((char)character);
                }
            }

            return stringBuilder;
        }

        public static char[][] ReadAsCharArrays(StreamReader streamReader, int arraySize)
        {
            string text = streamReader.ReadToEnd().Trim();

            int length = text.Length;
            int rows = (length + arraySize - 1) / arraySize;

            char[][] charArrays = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                int startIndex = row * arraySize;
                int endIndex = Math.Min(startIndex + arraySize, length);
                int rowLength = endIndex - startIndex;

                charArrays[row] = new char[rowLength];

                for (int i = startIndex, j = 0; i < endIndex; i++, j++)
                {
                    charArrays[row][j] = text[i];
                }
            }

            return charArrays;
        }
    }
}
