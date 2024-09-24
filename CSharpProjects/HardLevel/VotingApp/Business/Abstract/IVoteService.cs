
using VotingApp.Models;

namespace VotingApp.Business.Abstract
{
    public interface IVoteService
    {
        void Add(Vote vote);
        void Delete(int id);
        Vote GetVoteById(int id);
        List<Vote> GetVotes();
        List<Vote> GetByCategoryName(string categoryName);
        Vote GetByUserName(string userName);
        bool CheckIfUserVoted(string userName);
    }
}