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