// See https://aka.ms/new-console-template for more information
using BarcodeApp;
using BarcodeApp.Utilities;

Screen.WelcomeScreen();
while (true)
{
    Barcode barcode = new Barcode();
    switch (Input.GetDrawLong("Seçiminizi"))
    {

        case 1:
            barcode.BarcodeCreate();
            break;
        case 2:
            barcode.BarcodeRead();
            break;
        case 3:
            Console.WriteLine("Uygulama kapatılıyor bizi tercih ettiğiniz için teşekkür ederiz.");
            Input.Animation();
            Environment.Exit(1);
            break;
        default:
            break;
    }
}



