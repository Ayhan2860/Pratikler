using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace  Business.Concrete
{
    public class BoardManager : IBoardService
    {
        private readonly IBoardDal _boarDal;

        public BoardManager(IBoardDal boarDal)
        {
           
            _boarDal = boarDal;
        }

        public List<Board> GelAllTodos()
        {
            List<Board> todoList = _boarDal.GetList().FindAll(b=> b.Todo != null );
            return todoList;
        }
        public List<Board> GelAllInProgress()
        {
            List<Board> inProgressList = _boarDal.GetList().FindAll(b=> b.InProgress != null );
            return inProgressList;
        }
        public List<Board> GelAllDone()
        {
            List<Board> doneList = _boarDal.GetList().FindAll(b=> b.Done != null );
            return doneList;
        }

        public Board GetCardContentHeaderBoard(string cardHeader)
        {
            return _boarDal.GetCardContentHeaderBoard(cardHeader);
        }

        public List<Board> GetCardContentHeaderBoards(string cardHeader)
        {
            return _boarDal.GetCardContentHeaderBoards(cardHeader);
        }

        public void AddCard(CardContent content)
        {
            if (content.TeamMember == null)
            {
                Console.WriteLine("Kayıt yapılamadı! Geçerli takım üyesi id iletiniz!");
            }
            else if(content.SizeEnum == null || 1>(int)content.SizeEnum || 5< (int)content.SizeEnum)
            {
                Console.WriteLine("Büyük en az 1, en yüsek 5 olarak belirtilmelidir!");
            }
            else
            {   
                Board board = new Board(){Todo = content};
                _boarDal.Add(board);
            }
        }

        public bool DeleteCard(string cardHeader)
        {
            Board board = _boarDal.GetCardContentHeaderBoard(cardHeader);
            bool result = _boarDal.Delete(board);
            if (result)
            {
                Console.WriteLine("Kar Silindi!");
            }
            else
            {
                Console.WriteLine("Kart silinemedi!");
            }
            return result;
        }

        public bool BoardLineMove(string cardHeader, int line)
        {
            Board board = _boarDal.GetCardContentHeaderBoard(cardHeader);
            CardContent card = GetCard(cardHeader);
            _boarDal.Delete(board);
            switch (line)
            {
                 case  1:
                 return _boarDal.Add(new Board{Todo = card});
                 case  2:
                 return _boarDal.Add(new Board{InProgress = card});
                 case  3:
                 return _boarDal.Add(new Board{Done = card});
                 default:
                 return false;
            }
        }

        public CardContent GetCard(string cardHeader)
        {
            Board board = _boarDal.GetCardContentHeaderBoard(cardHeader);
            CardContent card = null;
            if (board != null)
            {
                if (board.Todo != null)
                {
                    card = board.Todo;
                }
                else if(board.InProgress !=null)
                {
                    card = board.InProgress;
                }
                else
                {
                    card = board.Done;
                }
            }
            return card;
        }
    }
}