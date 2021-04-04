# Object Oriented Programming
Nesne Yönelimli Programlama (OOP) mantıksal işlemlerden ziyade, nesnelere (object) ve nesneler üzerinde işlemlere odaklanan programlama dili modelidir. OOP’dA programlar, nesnelerin birbirileriyle etkileşime geçmeleri sağlanmasıyla tasarlanır. Java, C++, C#, Python, PHP, JavaScript, Ruby, Perl, Smalltalk, Objective-C gibi diller başlıca nesne yönelimli programlama dilleridir. OOP teorisinde 4 temel özelliğin gerçekleştirilmesi zorunlu sayılmıştır ve biri bile eksik ise bu dil saf OOP sayılmamıştır. Bunlar: 
• Encapsulation
• Inheritance
• Polymorphism
• Abstraction’dır.

## [Class](https://github.com/Hilal-aslanboga/OOP/tree/master/Class)
OOP'da her bir object belirli bir sınıfın veya alt sınıfın metotlarını veya prosedürlerini ve veri değişkenlerini barındıran birer örneğidir.
Sınıf belli tür bir nesnenin metotlarının ve değişkenlerinin şablon tanımıdır. Yani bir nesne bir sınıfın özel bir örneğidir ve değişkenlerden ziyade gerçek değişkenler barındırır. 
## Static Class
Neseyebağlı işlemler gerçekletirmiyorsak amaç sadece belirli bir duruma hizmet eden birden fazla öğeyi barındırmak yada bir araya toplamak ise ilgili sınıfı static olarak tanımlanması olağandır. Bu bağlamda static olarak işaretlenen sınıfların üyelerine instance olamadan erişebiliriz. Static olarak işaretlenmiş bir sınıf sadece static üyeler barındırabilir. Static olarak işaretlenmiş her üye sabittir (const). Bu yüzden cosnt olark işaretlenmiş bir üye bir daha static olarak işaretlenemez.
## Encapsulation
Encapsulation (sarma) OOP’UN temel kavramlarından biridir. Genel tanımıyla kullanıcı tarafından verilerin, sınıfların ve metotların ne kadarının görüntülenebileceği ve değiştirilebileceğinin sınırlarının konulmasını sağlar. Public (herkese açık), private (özel) ve protected (koruma altında) olmak üzere üç adet access modifier’dan (erişim dönüştürücüsü) bahsedilebilir. Public olanlar herkes tarafından görülebilir ve değiştirilebilir yani en güvensiz sınıf çeşididir. Bir program yazılırken programın iç yapısını değiştirecek metotların Public olması önerilmez. Public modifier dış kullanıcı tarafından eklenmesi veya değiştirilmesi istenen veriler için kullanılır. Protected modifier, public modifier’dan daha güvenli bir access modifier’dır. Aynı sınıf içinde görüntülenebilir veya erişilebilirler. Aynı zamanda üst sınıflar, ondan türetilmiş sınıflar ve aynı paket içinde bulunan sınıflar tarafından görüntülenebilir veya erişebilirler. Private en güvenli access modifier’dır. Private olanlar yalnızca içinde olduğu sınıf tarafından görülebilir veya erişilebilirler. Sınıflar private olabileceği gibi özellikleri ve üstünde tuttuğu veriler de private olabilir.
## Inheritance
Inheritance (kalıtım) bir sınıftan başka bir sınıf türetirken aralarında bir alt-üst ilişkisi oluşturmayı ve bu sınıflar üzerinde ortak metotlar ve özellikler kullanılmasını sağlayan bir mekanizmadır. OOP'UN temel kavramlarından biridir. Hali hazırda var olan sınıfların üzerine başka sınıfların inşa edilmesini sağlar.
## Abstraction
Abstraction (soyutlama) OOP'UN temel kavramlarından biridir. Alt sınıfların ortak özelliklerini ve işlevlerini taşıyan ancak henüz bir nesnesi olmayan bir üst sınıf oluşturmak istenirse bir soyut (abstract) üst sınıf oluşturulur. Soyut sınıfın yöntemleri alt sınıfları tarafından üzerine yazılmak üzere şablon olarak tanımlanabilir veya soyut metot olarak oluşturulabilir. Soyut metota sahip bir sınıf otomatik olarak kendisi de soyut hale gelir ve soyut sınıflardan nesne oluşturulmaz. 
## Interface
Interface sözdizimi (syntax) olarak classlara benzemesine rağmen farklı bir yapıdır. Interface, bir classın sağlaması gereken yeteneklerin beyanıdır. İçerisinde yanlızca metodlar ve propertyler tanımlanır, field tanımlanamaz. Üyeleri herhangi bir access modifier’ a sahip değillerdir , implement edilen class tarafından bütün üyeler erişilebilir.

## Polymorphism
Polymorphism (çok biçimlilik)OOP'DA programlama dilinin farklı tip verileri ve sınıfları farklı şekilde işleme yeteneğini belirten özelliğidir. Daha belirgin olmak gerekirse, metotları ve türetilmiş sınıfları yeniden tanımlama yeteneğidir.
