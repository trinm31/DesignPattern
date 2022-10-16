namespace UndoRedo_CommandPattern
{
    public interface ICommand
    {
        void Undo();

        void Redo();
    }
}