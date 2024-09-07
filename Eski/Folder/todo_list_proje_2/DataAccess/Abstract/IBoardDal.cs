using System;
using System.Collections.Generic;
using Entities;

namespace DataAccess.Abstract
{
    public interface IBoardDal
    {
        List<Board> GetList();
        bool Add(Board board);
        bool Delete(Board board);
        bool Update(Board board);
        Board GetCardContentHeaderBoard(string cardHeader);
        List<Board> GetCardContentHeaderBoards(string cardHeader);
    }
}