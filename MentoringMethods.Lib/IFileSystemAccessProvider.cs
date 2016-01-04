using System.Collections.Generic;

namespace MentoringMethods.Lib
{
    public interface IFileSystemAccessProvider
    {
        IEnumerable<string> GetFiles(string rootPath);
        IEnumerable<string> GetDirectories(string rootPath);
    }
}
