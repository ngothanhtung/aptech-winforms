namespace AptechWinforms.Components
{
    public interface IQuestion
    {
        bool CheckCorrect(string userOption);
        void LoadFromFile(int index);
        string GetDisplayContent();
    }

}
