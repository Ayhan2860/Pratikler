using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingApp.Business.Abstract;
using VotingApp.Data.Abstract;
using VotingApp.Data.Concrete;
using VotingApp.Models;

namespace VotingApp.Business.Concrete
{
    public class VoteManager:IVoteService
    {
        private readonly IVoteDal _voteDal;
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        private readonly int id;

        public VoteManager(IVoteDal voteDal, IUserService userService, ICategoryService categoryService)
        {
            _voteDal = voteDal;
            id = _voteDal.GetAll().Count() + 1;
            _userService = userService;
            _categoryService = categoryService;
        }

        public void Add(Vote vote)
        {
            vote.Id = id;
            var user = _userService.GetUserById(vote.UserId);
            var category = _categoryService.GetById(vote.CategoryId);
            vote.Category = category;
            vote.User = user;
            _voteDal.Add(vote);
        }

        public void Delete(int id)
        {
            var vote = GetVoteById(id);
        }

        public List<Vote> GetByCategoryName(string categoryName)
        {
           return _voteDal.GetAllExpression(x => x.Category.Name == categoryName);
        }

        public Vote GetByUserName(string userName)
        {
             return _voteDal.GetFind(x => x.User.UserName == userName);
        }

        public Vote GetVoteById(int id)
        {
            return _voteDal.GetFind(x => x.Id == id);
        }

        public List<Vote> GetVotes()
        {
            return _voteDal.GetAll();
        }

         public bool CheckIfUserVoted(string userName)
        {
            if (GetByUserName(userName) != null)
            {
                Console.WriteLine("Girmiş olduğunuz kullanıcı daha önceden oylamaya katılmıştır!");
                return true;
            }
            return false;
        }
    }
}