using Entities;

namespace Business.Abstract
{
    public interface IBoardService
    {
        List<Board> GelAllTodos();
        List<Board> GelAllInProgress();
        List<Board> GelAllDone();
        void AddCard(CardContent content);
        bool DeleteCard(string cardHeader);
        bool BoardLineMove(string cardHeader, int line);
        CardContent  GetCard(string cardHeader);
    }
}