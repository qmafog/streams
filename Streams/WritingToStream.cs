using System.Text;
#pragma warning disable

namespace Streams
{
    public static class WritingToStream
    {
        public static void ReadAndWriteIntegers(StreamReader streamReader, StreamWriter outputWriter)
        {
            int character;
            while ((character = streamReader.Read()) != -1)
            {
                outputWriter.Write(character);
            }
        }

        public static void ReadAndWriteChars(StreamReader streamReader, StreamWriter outputWriter)
        {
            int character;
            while ((character = streamReader.Read()) != -1)
            {
                outputWriter.Write((char)character);
            }
        }

        public static void TransformBytesToHex(StreamReader contentReader, StreamWriter outputWriter)
        {
            int character;
            while ((character = contentReader.Peek()) != -1)
            {
                character = contentReader.Read();
                string hexString = character.ToString("X2");
                outputWriter.Write(hexString);
            }
        }

        public static void WriteLinesWithNumbers(StreamReader contentReader, StreamWriter outputWriter)
        {
            int lineNumber = 0;
            string line;
            while ((line = contentReader.ReadLine()) != null)
            {
                lineNumber++;
                string lineNumberFormatted = lineNumber.ToString("D3");
                string updatedLine = lineNumberFormatted + line;
                outputWriter.Write(updatedLine);
                outputWriter.WriteLine();
            }
        }

        public static void RemoveWordsFromContentAndWrite(StreamReader contentReader, StreamReader wordsReader, StreamWriter outputWriter)
        {
            StringBuilder contentBuilder = new StringBuilder();

            while (contentReader.Peek() >= 0)
            {
                contentBuilder.Append((char)contentReader.Read());
            }

            string word;
            while ((word = wordsReader.ReadLine()) != null)
            {
                contentBuilder.Replace(word, "");
            }

            outputWriter.Write(contentBuilder.ToString());
        }
    }
}
