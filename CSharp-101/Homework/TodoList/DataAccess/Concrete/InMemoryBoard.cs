using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete
{
    public class InMemoryBoard:IBoardDal
    {
        private static List<Board> _boards;
        static InMemoryBoard()
        {
             InMemoryTeamMember teamMember = new InMemoryTeamMember();
            _boards = new List<Board>
            {
                new Board{Todo = new CardContent{Header = "İlk yapılacak iş", SizeEnum = SizeEnum.XS, Content = "İlk yapılacak iş hakkında",TeamMember= teamMember.GetTeamMember(1) }},
                new Board{Todo = new CardContent{Header = "İkinci yapılacak iş", SizeEnum = SizeEnum.S, Content = "İkinci yapılacak iş hakkında",TeamMember= teamMember.GetTeamMember(3) }},
                new Board{InProgress = new CardContent{Header = "Üçüncü yapılacak iş", SizeEnum = SizeEnum.L, Content = "Üçüncü yapılacak iş hakkında",TeamMember= teamMember.GetTeamMember(2) }}
            };
        }

        public bool Add(Board board)
        {
            _boards.Add(board);
            return true;
        }

        public bool Delete(Board board)
        {
            int result = _boards.RemoveAll(b=>b==board);
            if (result < 0)
            {
                return false;
            }else
            {
                return true;
            }
        }

        

        public Board GetCardContentHeaderBoard(string cardHeader)
        {
            Board? board = _boards.SingleOrDefault(x => (x.Todo != null && x.Todo.Header.Equals(cardHeader)) || 
            x.Done != null && x.Done.Header.Equals(cardHeader) ||
            x.InProgress != null && x.InProgress.Header.Equals(cardHeader));
            // board = board ?? _boards.SingleOrDefault(x => x.Done != null && x.Done.Header.Equals(cardHeader));
            // board = board ?? _boards.SingleOrDefault(x => x.InProgress != null && x.InProgress.Header.Equals(cardHeader));
            return board!;
        }

        public List<Board> GetCardContentHeaderBoards(string cardHeader)
        {
            var boards = _boards.FindAll(b=>b.Todo.Header.ToLower() == cardHeader.ToLower() ||
             b.InProgress.Header.ToLower() == cardHeader.ToLower() || b.Done.Header.ToLower()==cardHeader.ToLower());
             return boards;
        }

        public List<Board> GetList()
        {
            return _boards;
        }

        public bool Update(Board board)
        {
             int index = _boards.IndexOf(board);
             if (index <0)
             {
                 return false;
             }else
             {
                 return true;
             }
        }
    }
}