

using Microsoft.Extensions.DependencyInjection;
using VotingApp.Business.Abstract;
using VotingApp.Business.Concrete;
using VotingApp.Data.Abstract;
using VotingApp.Data.Concrete;
using VotingApp.UI;

namespace VotingApp.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection CreateService(this IServiceCollection services)
        {
             services
            .AddScoped<ICategoryDal, CategoryDal>()
            .AddScoped<ICategoryService, CategoryManager>()
            .AddScoped<IUserDal, UserDal>()
            .AddScoped<IUserService, UserManager>()
            .AddScoped<IVoteDal, VoteDal>()
            .AddScoped<IVoteService, VoteManager>()
            .AddScoped<IAuthService, AuthManager>()
            .AddScoped<IVotingService, VotingManager>();
    
            return services;
        }
    }
}