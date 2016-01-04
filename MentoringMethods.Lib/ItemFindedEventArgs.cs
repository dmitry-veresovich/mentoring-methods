using System;

namespace MentoringMethods.Lib
{
    public class ItemFindedEventArgs : EventArgs
    {
        public string Path { get; }
        public ItemType Type { get; }

        public ItemFindedEventArgs(string path, ItemType type)
        {
            Path = path;
            Type = type;
        }

        public bool ShouldStopSearch { get; set; }
        public bool ShouldExcludeItem { get; set; }
    }
}
