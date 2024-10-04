

using BarcodeApp.Utilities;
using IronBarCode;

namespace BarcodeApp
{
    public class Barcode
    {
        private static string? filePath;
        private static string? folderPath;
        public Barcode()
        {
            License.LicenseKey = "IRONSUITE.WEBSITEM28.GMAIL.COM.20579-FEC0525D99-OQVWS-3PFW52K5OXPF-DUDBB6TSBEYO-HZYQPIN4TB2M-WDLFKIQFRL7S-T3TONYEYQ3KL-BY5RQLJBESOS-IXKTQW-TKRYE5MWOT2NUA-DEPLOYMENT.TRIAL-CXKIGF.TRIAL.EXPIRES.02.NOV.2024";

            folderPath = Environment.CurrentDirectory + "/Barcodes";
            filePath = folderPath + $"/my_barcode.png";
        }

        public  void BarcodeCreate()
        {
            try
            {
                Console.WriteLine("Barkod oluşturmak istediğiniz değeri numerik sayı olarak giriniz");
                long barcodeValue = Input.GetDrawLong("Değeri");

                GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(barcodeValue.ToString(), BarcodeEncoding.EAN8);
                Console.WriteLine("Lütfen bekleyin barkodunuz oluşturuluyor.");
                Input.Animation(20);
                barcode.SaveAsImage(filePath);
                Input.WriteMessage("Barkod başarıyla oluşturuldu", true);
            }
            catch
            {
                Input.WriteMessage("Geçersiz Barkod Formatı", false);
            }
        }

        public  void BarcodeRead()
        {
            try
            {
                Console.WriteLine("Barkod okunuyor....");
                Input.Animation();

                BarcodeResult[] results = BarcodeReader.Read(filePath).ToArray();
                Console.WriteLine(results[0].Text);
                Input.WriteMessage("Barkod başarıyla okundu", true);
            }
            catch 
            {
                Input.WriteMessage("Barkod bulunamadı!", false);
            }
        }
    }
}