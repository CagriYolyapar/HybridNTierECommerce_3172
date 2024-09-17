Bilinmelidir ki bu mimaride yapabildigimiz zaman bilerek Domain Entity ile calısılmıstır...Bunun olmaması gerektiginin farkındayız...Bu refactor edilecektir...Bunu bilerek secme sebebimiz ise elimizdeki zamanı en iyi sekilde degerlendirerek projenin asıl kilit noktasına gelecegimiz vakti kısaltmaktır(Satıs,siparis , Admin paneli islemleri banka ile haberlesme sistemidir)


--------------------------------------

Entities Katmanı => Microsoft.AspNetCore.Identity.EntityFramework kütüphanesini benim bir takım DomainEntity'lerim  Identity sınıflarından miras alacagı icin indirildi

*Microsoft.Extensions.Identity.Stores => MVC tarafından ve EntityFramework tarafından bagımsız olarak CoreIdentity yapısı kullanılacaksa Identity kütüphanesinin yanında Stores kütüphanesinin de indirilmesi gereklidir...



-------------------------------------------------------------------------

Core Platorformunda referanslarda (Projelerin birbirini referans alma durumunda) Framework'den farklı bir yontem izlenmeye basladı...

BU yöntem : 

Framework platformunda

DAL(Entity Framework,Entities,Conf)  => BLL  => UI