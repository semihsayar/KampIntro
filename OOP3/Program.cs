using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
IKrediManager esnafKrediManager = new EsnafKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggers = new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService(), new SmsLoggerService() };

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(esnafKrediManager,loggers);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,konutKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

