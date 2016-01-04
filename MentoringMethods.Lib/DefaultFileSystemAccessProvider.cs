using System.Collections.Generic;
using System.IO;

namespace MentoringMethods.Lib
{
    public class DefaultFileSystemAccessProvider : IFileSystemAccessProvider
    {
        public IEnumerable<string> GetFiles(string path)
        {
            return Directory.EnumerateFiles(path);
        }

        public IEnumerable<string> GetDirectories(string path)
        {
            return Directory.EnumerateDirectories(path);
        }
    }
}
