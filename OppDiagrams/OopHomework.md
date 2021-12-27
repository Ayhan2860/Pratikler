
## Üniversite Yönetim Sistemi
- - -
+ Üniversite Yönetim Sisteminin aşağıda ki isterlere göre tasvir eden Class(Sınıf) diyagramı çizimi.
    + Üniversiteye ait sınıflıklar, çalışma ofisleri ve departmanlar vardır.
    + Departmanlara ait ofisler vardır.
    + Üniversiteye ait çalışanlar vardır. Bu çalışanlar profesör veya memur olabilir.
    + Her çalışan bir ofiste çalışır.

![univercity](https://user-images.githubusercontent.com/68536015/147480905-f8e7c445-8a77-4370-a6bd-b59a3efa7232.png)

- - - 

## Hayvanat Bahçesi Yönetimi
- - -
+ Bir hayvanat bahçesindeki hayvanlar hakkındaki bilgileri takip etmek için bir sistem tasarlanıyor, Polimorfizm modelini kullanarak,      aşağıda açıklanan durumu ele almak için bir sınıf diyagramı tasarımı.
    + Hayvanlar:
    + Atlar (atlar, zebralar, eşekler vb.),
    + Kedigiller (kaplanlar, aslanlar vb.),
    + Kemirgenler (sıçanlar, kunduzlar vb.) gibi gruplardaki türlerle karakterize edilir.
    + Hayvanlar hakkında depolanan bilgilerin çoğu tüm gruplamalar için aynıdır.
    + tür adı, ağırlığı, yaşı vb.
    + Sistem ayrıca her hayvan için belirli ilaçların dozajını alabilmeli => getDosage ()
    + Sistem Yem verme zamanlarını hesaplayabilmelidir => getFeedSchedule ()
    + Sistemin bu işlevleri yerine getirme mantığı, her gruplama için farklı olacaktır. Örneğin, atlar için yem verme algoritması farklı olup, kaplanlar için farklı olacaktır.

![Animals](https://user-images.githubusercontent.com/68536015/147481540-0336c52c-0267-4a2a-ae53-2b09c81bb1fa.jpg)

- - -

## Uçuş Yönetim Sistemi
- - - 
+ Uçuşların ve pilotların yönetimi için aşağıda yer alan isterlere göre sistemi tasvir eden Class(Sınıf) diyagramı çizimi.
    
    + Hava yolu şirketleri uçuşları gerçekleştirir. Her hava yolunun bir kimliği vardır.
    + Hava yolu şirketi, farklı tipteki uçaklara sahiptir.
    + Uçaklar çalışır veya onarım durumunda olabilir.
    + Her uçuşun benzersiz kimliği, kalkacağı ve ineceği havaalanı, kalkış ve iniş saatleri vardır.
    + Her uçuşun bir pilotu ve yardımcı pilotu vardır ve uçağı kullanırlar.
    + Havaalanlarının benzersiz kimlikleri ve isimleri vardır.
    + Hava yolu şirketlerinin pilotları vardır ve her pilotun bir deneyim seviyesi mevcuttur.
    + Bir uçak tipi, belirli sayıda pilota ihtiyaç duyabilir.

![ucusYonetimi](https://user-images.githubusercontent.com/68536015/147481964-d289d379-a822-4489-a641-02c0b9eec0bd.png)
    - - - 
## Online Film Projesi

- - -

+ Online film satan veya kiralayan uygulamanın sistemini aşağıda ki isterlere göre tasvir eden Class(Sınıf) diyagramı çizimi.
  + Uygulamada filmler listelenebilir, sıralanabilir ve kullanıcılar uygulamaya abone olabilir.
  + Kullanıcılar abonelik için sistem üzerinden kredi satın alır.
  + Sadece abone olan kullanıcılar, kredileri ile film kiralayabilir ve kiraladığı filmin kredi bedeli kadar hesabından düşülür.
  + Normal kullanıcılar ve aboneler film satın alabilirler.
  + Eğer film mevcut değil ise talep edilebilir.

 - - - 
 
 ![onlinefilm](https://user-images.githubusercontent.com/68536015/147460370-54c585ca-c295-4e22-99ed-8322fa73a99f.png)
