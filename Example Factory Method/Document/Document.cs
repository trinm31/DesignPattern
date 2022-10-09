using System.Collections.Generic;
using Example_Factory_Method.Page;

namespace Example_Factory_Method.Document
{
    public abstract class Document
    {
        private List<Page.Page> _pages = new List<Page.Page>();

        public Document()
        {
            CreatePages();
        }

        public List<Page.Page> Pages
        {
            get {return _pages; }
        }

        public abstract void CreatePages();
    }
}