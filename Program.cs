using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Polling;

internal class Program
{
    static ITelegramBotClient bot = new TelegramBotClient("6054862195:AAEmaYciD-HuWmbqE9EVcc55r-7hK6jGFHg\r\n");

    public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));

        String message = update.Message.Text;
        long chatId = update.Message.Chat.Id;
        Boolean isfind = false;


        if (message.Equals("/start"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                    new KeyboardButton[] {"Массаж"},
                    new KeyboardButton[] {"Депиляция"},
                    new KeyboardButton[] {"Чистка лица"}
                });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Привет! Хочешь стать еще красивее?", replyMarkup: start);
        }

        if (message.Equals("Массаж"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                    new KeyboardButton[] {"Массаж с помощью ультразвука"},
                    new KeyboardButton[] {"RF-лифтинг"},
                    new KeyboardButton[] {"Механический массаж"},
                    new KeyboardButton[] {"Главное меню"}
                });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
        }

        if (message.Equals("Депиляция"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                    new KeyboardButton[] {"Шугаринг"},
                    new KeyboardButton[] {"Выщипывание"},
                    new KeyboardButton[] {"Удаление кремом"},
                    new KeyboardButton[] {"Ваксинг"},
                    new KeyboardButton[] {"Главное меню"}
                });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
        }

        if (message.Equals("Чистка лица"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                    new KeyboardButton[] {"Механическая чистка лица"},
                    new KeyboardButton[] {"Ультразвуковая чистка лица"},
                    new KeyboardButton[] {"Лазерная чистка лица"},
                    new KeyboardButton[] {"Главное меню"}
                });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
        }

        if (message.Equals("Главное меню"))
        {
            isfind = true;
            ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
            {
                    new KeyboardButton[] {"Массаж"},
                    new KeyboardButton[] {"Депиляция"},
                    new KeyboardButton[] {"Чистка лица"}
                });
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Возврат на главное меню", replyMarkup: start);
        }
        if (message.Equals("Массаж с помощью ультразвука"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Массаж ультразвук.jpeg");
            var photo = new InputOnlineFile(sr.BaseStream, "Массаж ультразвук.jpeg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Массаж с помощью ультразвука.\n\nНаносим гель для проведения электрофореза и средство для внедрения в кожу. " +
                "Можно использовать препараты для лифтинга, омоложения, осветления и оздоровления кожи. " +
                "Медленными движениями проводим процедуру массажа и электрофореза, снизу вверх. " +
                "Также используется массажная лопатка, что помогает улучшить микроциркуляцию кожи и оказать лифтинговый эффект.");
        }

        if (message.Equals("RF-лифтинг"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\RF-лифтинг.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "RF-лифтинг.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "RF-лифтинг\n\nЕго проводят с помощью двух насадок, которые однополярной радиочастотной энергией нагревают кожу, не травмируя её." +
                "Травмируются поврежденные старые коллагеновые волокна и эластина, производится коагуляция (скручивание) коллагена, за счет уплотнения дермы. " +
                "Производится запуск каскадов, реакций, которые ведут к неоколлагеногенезу. " +
                "Повреждается ткань, и организм пытается восстановить ее. " +
                "Ярким видом является вино Шатонеф дю Пап из 13 сортов." +
                "Так продуцируются новые волокна");
        }

        if (message.Equals("Механический массаж"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Механический массаж.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "Механический массаж.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Механический массаж\n\nМассаж состоит из 4 этапов. " +
                    "\r\n\r\nПоглаживание\r\n\r\nРабота идет с поверхностными слоями кожи, эпидермисом. Сосуды подготавливаются для дальнейшего, глубокого воздействия.Массаж начинается с большого оттока, который проводится по основным массажным линиям лица и зоне декольте. После этого идет малый отток. Большой отток направлен на снятие отечности всего лица, а малый обеспечивает лимфодренаж средней части лица. " +
                    "\r\n\r\nРастирание\r\n\r\nЗадействует подушечки всех пальцев, движения производятся от себя и на себя, в зависимости от зоны проработки. Движения направлены таким образом, чтобы разглаживать морщины и приподнимать овал лица. Разглаживаются мимические и мелкие эпидермальные морщины. " +
                    "\r\n\r\nРазминание\r\n\r\nНаправлен на глубокое воздействие. Затрагиваются все слои кожи, а также места прикрепления мышц. Начинаем с волнообразного движения в области подбородка, чтобы подтянуть овал лица. На каждую сторону по четыре волны, подушечками пальцев фиксируя мышцы подбородочной области. Производятся щипки подчелюстной области кожи, с воздействием на мышцы. " +
                    "\r\n\r\nЗавершение\r\n\r\nНаправлено на проработку морщинок в области декольте, шеи и удалении второго подбородка, подтяжке овала лица.");
        }
        if (message.Equals("Шугаринг"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Шугаринг.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "Шугаринг.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Шугаринг\n\nОсновывается на применении свойства составов на основе сахаров удалять волосяной покров механическим способом." +
                "Волосы прилипают к тягучей сладкой массе, что позволяет удалить их с корнем. На сайте volosgid.ru читайте подробности." +
                "Сахара (глюкоза и фруктоза) обволакивают волосяной фолликул, поэтому процедура менее болезненна, чем восковая депиляция." +
                "Важной особенностью техники является удаление массы с поверхности кожи по направлению роста волос." +
                "В сочетании с обволакивающими свойствами сахарной основы, это снижает болевые ощущения, уменьшает вероятность травмирования дермы. На сайте volosgid.ru читайте подробности.");
        }

        if (message.Equals("Выщипывание"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Выщипывание.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "Выщипывание.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Выщипывание\n\n" +
                "Удаление волос на ногах с помощью щипцов или эликтрического эпилятора.");
        }

        if (message.Equals("Удаление кремом"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Удаление кремом.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "Удаление кремом.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Удаление кремом\n\n" +
                "Состав, в основе которого используется тиогликолят кальция, не только ослабляет волосяные фолликулы, но и обеспечивает надлежащий уход за кожей тела." +
                "Принцип действия крема очень прост. " +
                "Его наносят на нужный участок тела или лица, выдерживают указанное на упаковке время, а затем смыть либо удалить при помощи лопатки остатки состава." +
                "К основным плюсам кремов для депиляции относят низкую стоимость, бережный уход за кожей, простоту и безболезненность при использовании.");
        }

        if (message.Equals("Ваксинг"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Ваксинг.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "Ваксинг.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Ваксинг\n\n" +
                "Удаление волос на ногах при помощи воска или восковых полосок.");
        }

        if (message.Equals("Механическая чистка лица"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Механическая чистка лица.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "Механическая чистка лица.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Механическая чистка лица\n\nМеханическая (мануальная) чистка в течение длительного периода времени (до появления аппаратной косметологии) была единственно доступной. " +
                "Она основана на очищении кожи, удалении угрей и комедонов вручную и при помощи следующих металлических инструментов:" +
                "\r\n\r\nКосметическая петля. Косметолог накладывает петлю на обрабатываемый участок и слегка вдавливает его в кожу. Петли бывают разных размеров и форм, благодаря чему с помощью их можно быстро удалить как черные точки, так и милиумы (жировики, белые угри). Очень часто петли, которые отличаются по размеру и форме, являются разными наконечниками одного и того же инструмента. " +
                "\r\n\r\nЛожка Уно. Одно из самых эффективных механических приспособлений для раскрытия пор, их очищения от загрязнений, секрета сальных желез себума. " +
                "\r\n\r\nКосметологическая игла (игла Видаля). Это отличный помощник косметолога для удаления загрязнений из глубоких слоёв эпидермиса, проработки узких протоков.");
        }
        if (message.Equals("Ультразвуковая чистка лица"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Ультразвуковая чистка лица.jpg");
            var photo = new InputOnlineFile(sr.BaseStream, "Ультразвуковая чистка лица.jpg");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Ультразвуковая чистка лица\n\n" +
                "Это один из наиболее щадящих вариантов для кожи. " +
                "Процедура не требует предварительной подготовки. В отличие от механической чистки покраснение проходит очень быстро. " +
                "Хороший эффект чистка обеспечивает как сухой, так и жирной коже, в том числе, с чёрными точками. " +
                "Главное, такие точки нельзя не относить к одной проблеме с белыми угрями. В этом случае без механической чистки не обойтись.");
        }

        if (message.Equals("Лазерная чистка лица"))
        {
            isfind = true;
            StreamReader sr = new StreamReader("");
            var photo = new InputOnlineFile(sr.BaseStream, "");
            await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Лазерная чистка лица\n\n" +
                "Это косметологическая процедура с помощью лазерных импульсов. " +
                "Они хорошо поглощаются поверхностными слоями. " +
                "Поры раскрываются, но базальные клетки эпидермиса остаются интактными (нетронутыми). " +
                "Лазерные технологии позволяют нормализовать работу сосудов микроциркуляторного русла, повысить тугор, уменьшить морщины. " +
                "Такая процедура полезна при сухой увядающей коже, тусклом цвете лица, но при этом после 60-ти лет процедуру делать нежелательно.");
        }


        if (!isfind)
        {
            await botClient.SendTextMessageAsync(chatId: chatId, text: "Мне не понятно ваше сообщение");
        }
    }

    public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

        var cts = new CancellationTokenSource();
        var cancellationToken = cts.Token;
        var receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = { },
        };
        bot.StartReceiving(
            HandleUpdateAsync,
            HandleErrorAsync,
            receiverOptions,
            cancellationToken
        );
        Console.ReadLine();
    }
}
