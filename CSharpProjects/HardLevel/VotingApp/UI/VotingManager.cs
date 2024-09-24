

using VotingApp.Business.Abstract;
using VotingApp.Models;

namespace VotingApp.UI
{
    public class VotingManager : IVotingService
    {
        private readonly IVoteService _voteService;
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;

        public VotingManager(IVoteService voteService, IAuthService authService, IUserService userService, ICategoryService categoryService)
        {
            _voteService = voteService;
            _authService = authService;
            _userService = userService;
            _categoryService = categoryService;
        }


        public void CategoriesListing()
        {
            Console.Clear();
            Console.WriteLine("\n********************************************\n");

            var categories = _categoryService.GetCategories();
            foreach (var item in categories)
            {
                Console.WriteLine("{0}- {1}", item.Id, item.Name);
            }
        }

        public (User user, bool isBack) UserVoting()
        {
            Console.WriteLine("\n********************************************\n");
            bool isBack = false;
        Back:
            Console.Write("Kullanıcı adınız: ");
            string username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
                goto Back;
            if (_voteService.CheckIfUserVoted(username))
                goto Back;
            if (!_userService.CheckExistsUser(username))
            {
                Console.WriteLine("Kullanıcı bulunamadı!");
                UserSwitcher();
                isBack = true;
                goto Back;
            }
            return (_userService.GetUserByName(username), isBack);

        }

        public void VotingResult()
        {
            Console.WriteLine("\n********************************************\n");
            var categories = _categoryService.GetCategories();
            foreach (var item in categories)
            {
                Console.WriteLine("{0,-2}- {1,-25} -> Verilen oy : {2} (%{3:.#})", item.Id, item.Name,
                   _voteService.GetByCategoryName(item.Name).Count,
                   (Convert.ToDouble(_voteService.GetByCategoryName(item.Name).Count) /
                   Convert.ToDouble(_voteService.GetVotes().Count)) * 100);
            }
        }

        public void Voting(string userName)
        {

            Console.Write("Yukarıda verilen kategorilerin hangisinden daha fazla" +
               " içerik üretilmesini istiyorsanız belirtiniz : ");
            int categoryId = Convert.ToInt32(Console.ReadLine());
            var user = _userService.GetUserByName(userName);
            var category = _categoryService.GetById(categoryId);
            Vote vote = new Vote()
            {
                CategoryId = category.Id,
                UserId = user.Id,
                Category = category,
                User = user
            };
            _voteService.Add(vote);
            Console.WriteLine("Tebrikler oylamanız yapıldı.");
        }
        private void UserSwitcher()
        {
            Console.WriteLine("1- Oyumu Kullanmak İstiyorum\n");
            Console.WriteLine("2- Kayıt Olmak İstiyorum\n");
            int select = Convert.ToInt32(Console.ReadLine());
            // User user = null!;
            switch (select)
            {
                case 1:
                    {
                        UserVoting();
                    }
                    break;
                case 2:
                    {
                        Register();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Hatalı bir işlem gerçekleştirdiniz");

                    }
                    break;
            }

            // return user;
        }
        private void Register()
        {

        UserName:
            Console.Write("Kullanıcı Adınız : ");
            string newUserName = Console.ReadLine();
            if (_userService.CheckExistsUser(newUserName!))
            {
                Console.WriteLine("Kullanıcı adı daha önce kayıt edilmiştir.");
                goto UserName;
            }


        Email:
            Console.Write("Email Adresiniz : ");
            string newEmail = Console.ReadLine();
            if (_userService.CheckExistsUser(newUserName!))
            {
                Console.WriteLine("Email adresi daha önce kayıt edilmiştir.");
                goto Email;
            }
            Console.Write("Parolanız : ");
            string newPassword = Console.ReadLine();

            _authService.Register(new User { UserName = newUserName!, Password = newPassword!, Email = newEmail! });

            //return _userService.GetUserByName(newUserName!);
        }


    }


}