using System.Collections.Generic;

namespace CompositeDesignPattern
{
    public class FolderComposite: IFileComponent
    {
        private List<IFileComponent> _files = new List<IFileComponent>();

        public FolderComposite(List<IFileComponent> files)
        {
            _files = files;
        }
        public void ShowProperty()
        {
            foreach (var file in _files)
            {
                file.ShowProperty();
            }
        }

        public long TotalSize()
        {
            long total = 0;
            foreach (var file in _files)
            {
                total += file.TotalSize();
            }

            return total;
        }
        
        public void Delete()
        {
            foreach (var file in _files)
            {
                file.Delete();
            }
        }
    }
}