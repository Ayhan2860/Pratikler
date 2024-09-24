using VotingApp.Models;

namespace VotingApp.UI
{
    public interface IVotingService
    {
        void CategoriesListing();
        (User user, bool isBack) UserVoting();
        void Voting(string userName);
        void VotingResult();
    }


}