using System;
using System.Collections.Generic;

namespace MentoringMethods.Lib
{
    public interface IFileSystemVisitor
    {
        event EventHandler Start;
        event EventHandler Finish;
        event EventHandler<ItemFindedEventArgs> FileFinded;
        event EventHandler<ItemFindedEventArgs> DirectoryFinded;
        event EventHandler<ItemFindedEventArgs> FilteredFileFinded;
        event EventHandler<ItemFindedEventArgs> FilteredDirectoryFinded;

        IEnumerable<string> Enumerate(string path);
    }
}
