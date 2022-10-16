namespace UndoRedo_CommandPattern
{
    public class DocumentEditerCommand : ICommand
    {
        private string _text;
        private Document _document;

        public DocumentEditerCommand(Document document, string text)
        {
            _document = document;
            _text = text;
            document.Write(text);
        }
        public void Undo()
        {
            _document.EraseLast();
        }

        public void Redo()
        {
            _document.Write(_text);
        }
    }
}