using VotingApp.UI;

namespace VotingApp
{
    public class App
    {
        private readonly IVotingService _votingService;

        public App(IVotingService votingService)
        {
            _votingService = votingService;
        }

        public void Run(string[] args)
        {
            bool isRun = true;
            int counter = 0;
            while (isRun)
            {
                EntryScreen(counter);
                _votingService.CategoriesListing();
                var userVoting = _votingService.UserVoting();

                if (userVoting.isBack)
                {
                    Console.Clear();
                    _votingService.CategoriesListing();
                }
                _votingService.Voting(userVoting.user.UserName);
                _votingService.VotingResult();
                counter++;

                Console.WriteLine("\n\nDevam Etmek İstiyormusunuz? (Y/N)");

                var key = Console.ReadLine();
                if(key?.ToLower() == "n")
                    isRun = false;
                else if(key?.ToLower() == "y")
                    continue;
                else 
                {
                     Console.WriteLine("Hatalı tuşlama yaptınız uygulama kapatıldı.");
                     isRun = false;
                }
                
                
            }

        }



        private void EntryScreen(int i)
        {
            if (i > 0)
                Console.WriteLine("Hemen oylamaya devam etmek için bir tuşa basınız");
            else
            {
                Console.WriteLine("Voting Uygulamamıza Hoşgeldiniz 🫥");
                Console.WriteLine("Hemen oylamaya başlamak için bir tuşa basınız");
            }
            Console.ReadLine();
            Console.Clear();

        }


    }

}

