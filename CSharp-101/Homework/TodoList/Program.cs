// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities;

class Program
{
     static IBoardService boardManager = new BoardManager(new InMemoryBoard());
    
    static void Main()
    {

        while (true)
        {
            int n = ScreenMenu();
            switch (n)
            {
                case 1:
                    Console.Clear();
                    BoardListed();
                    continue;
                case 2:
                    Console.Clear();
                    CardAdded();
                    continue;
                case 3:
                    Console.Clear();
                    CardDeleted();
                    continue;
                case 4:
                    Console.Clear();
                    CardMoved();
                    continue;
                default:
                    n = 0;
                    continue;
            }
        }


        static int ScreenMenu()
        {
            Console.WriteLine(@"Lütfen yapmak istediğiniz işlemi seçiniz :) 
            *******************************************
            (1) Board Listelemek
            (2) Board'a Kart Eklemek
            (3) Board'dan Kart Silmek
            (4) Kart Taşımak");
            Console.Write("Seçiminiz : ");
            return IntReadLineCheck();
        }

        static void BoardListed()
        {
            Console.WriteLine(@"TODO Line
             ************************");
            List<Board> todoList = boardManager.GelAllTodos();
            foreach (Board item in todoList)
            {
                Console.WriteLine(@"
                Başlık      : {0}
                İçerik      : {1}
                Atanan Kişi : {2}
                Büyüklük    : {3}
                ----", item.Todo.Header, item.Todo.Content, item.Todo.TeamMember.Name, item.Todo.SizeEnum);
            }
            Console.WriteLine(@"IN PROGRESS Line
                ************************");
            List<Board> inProgressList = boardManager.GelAllInProgress();
            foreach (Board item in inProgressList)
            {
                Console.WriteLine(@" Başlık      : {0}
                İçerik      : {1}
                Atanan Kişi : {2}
                Büyüklük    : {3}
                ----", item.InProgress.Header, item.InProgress.Content, item.InProgress.TeamMember.Name, item.InProgress.SizeEnum);
            }

            Console.WriteLine(@"DONE Line
                ************************");
            List<Board> doneList = boardManager.GelAllDone();
            foreach (Board item in doneList)
            {
                Console.WriteLine(@" Başlık      : {0}
                İçerik      : {1}
                Atanan Kişi : {2}
                Büyüklük    : {3}
                ----", item.Done.Header, item.Done.Content, item.Done.TeamMember.Name, item.Done.SizeEnum);
            }
        }

        static void CardAdded()
        {
            Console.Write("Başlık Giriniz :                                  ");
            string header = Console.ReadLine();
            Console.Write("İçerik Giriniz :                                  ");
            string content = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            int sizeEnum = IntReadLineCheck();
            Console.Write("Kişi Seçiniz :                                    ");
            int teamMember = IntReadLineCheck();
            CardContent card = new CardContent
            {
                Header = header,
                Content = content,
                SizeEnum = (SizeEnum)sizeEnum,
                TeamMember = new InMemoryTeamMember().GetTeamMember(teamMember)
            };
            boardManager.AddCard(card);
        }
        static void CardDeleted()
        {
            while (true)
            {
                Console.Write(@"Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.Lütfen kart başlığını yazınız: ");
                string header = Console.ReadLine();
                bool result = boardManager.DeleteCard(header);
                if (result)
                {
                    break;
                }
                else
                {
                    bool searchVote = CheckIsCard();
                    if (searchVote)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static void CardMoved()
        {
            while (true)
            {
                Console.Write("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\n Lütfen kart başlığını yazınız: ");
                string cardHeader = Console.ReadLine();
                CardContent card = boardManager.GetCard(cardHeader);
                if (card == null)
                {
                    bool searchVote = CheckIsCard();
                    if (searchVote)
                        continue;
                    else
                        break;
                }

                Console.WriteLine(@"Bulunan Kart Bilgileri:
                **************************************
                Başlık      : {0}
                İçerik      : {1}
                Atanan Kişi : {2}
                Büyüklük    : {3}
                
                Lütfen taşımak istediğiniz Line'ı seçiniz: 
                (1) TODO
                (2) IN PROGRESS
                (3) DONE", card.Header, card.Content, card.TeamMember.Name, card.SizeEnum);
                Console.Write("Seçiminiz : ");
                int line = IntReadLineCheck();
                bool result = boardManager.BoardLineMove(cardHeader, line);
                if (result)
                    break;
                else
                {
                    Console.WriteLine("İşlem Başarısız oldu!");
                    continue;
                }
            }
        }
        static bool CheckIsCard()
        {
            Console.WriteLine(@"Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.
            * Silmeyi sonlandırmak için : (1)
            * Yeniden denemek için : (2)");
            Console.Write("Seçiminiz : ");
            int num = IntReadLineCheck();
            if (num == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static int IntReadLineCheck()
        {
            int number;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {

                number = 0;
                Console.WriteLine("Lütfen sayısal bir seçim yapınız.");
            }
            return number;
        }
    }
}
