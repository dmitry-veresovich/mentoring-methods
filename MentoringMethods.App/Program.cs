using MentoringMethods.Lib;

namespace MentoringMethods.App
{
    class Program
    {
        private const string Path = @"D:\Workspace\wiggle.merchandising\Source\Wiggle.Merchandising.ItemEnrichment.Domain";
        // @"D:\Test Folder"


        static void Main(string[] args)
        {
            var fileSystemVisitor = SetUpFileSystemVisitor();

            var results = fileSystemVisitor.Enumerate(Path);

            foreach (var result in results)
            {
                System.Console.WriteLine(result);
            }
        }

        private static FileSystemVisitor SetUpFileSystemVisitor()
        {
            var fileSystemVisitor = new FileSystemVisitor(s => s.EndsWith(".config"));
            fileSystemVisitor.Start += (sender, eventArgs) => System.Console.WriteLine("Start search");
            fileSystemVisitor.Finish += (sender, eventArgs) => System.Console.WriteLine("Finish search");

            //fileSystemVisitor.FileFinded += FileSystemVisitorOnFileFinded;
            fileSystemVisitor.FilteredFileFinded += FileSystemVisitorOnFileFinded;


            //fileSystemVisitor.DirectoryFinded += (sender, args) => System.Console.WriteLine($"Directory : { args.Path } ");
            //fileSystemVisitor.FileFinded += (sender, args) => System.Console.WriteLine($"File : { args.Path } ");

            return fileSystemVisitor;
        }

        private static void FileSystemVisitorOnFileFinded(object sender, ItemFindedEventArgs args)
        {
            //System.Console.WriteLine($"File : { args.Path } ");
            //if (args.Path.Contains("Installer"))
            //    args.ExcludeItem = true;
            args.ShouldStopSearch = true;
        }
    }
}
