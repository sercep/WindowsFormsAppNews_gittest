using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Железо и гаджеты", "Кино", "Игры" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem == "Железо и гаджеты")
            {
                comboBox2.Items.Add("Процессоры");
                comboBox2.Items.Add("Видеокарты");
                comboBox2.Items.Add("Ноутбуки");
                comboBox2.Items.Add("Смартфоны");
                comboBox2.Items.Add("Телевизоры");
                comboBox2.Items.Add("Наушники");
            }
            else if (comboBox1.SelectedItem == "Кино")
            {
                comboBox2.Items.Add("Анонсы");
                comboBox2.Items.Add("Трейлеры кино");
                comboBox2.Items.Add("Премии");
            }
            else if (comboBox1.SelectedItem == "Игры")
            {
                comboBox2.Items.Add("Игровая индустрия");
                comboBox2.Items.Add("Трейлеры игр");
                comboBox2.Items.Add("Разработка игр");
            }

        }
    
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            linkLabel1.Text = "";

            label2.Text = "";
            linkLabel2.Text = "";

            label3.Text = "";
            linkLabel3.Text = "";

            label4.Text = "";
            linkLabel4.Text = "";

            label5.Text = "";
            linkLabel5.Text = "";
            if (comboBox2.SelectedItem == "Процессоры")
            {
                label1.Text = "Компания Intel представила 10-нм процессор";
                linkLabel1.Text = "https://news.yandex.ru/story/Kompaniya_Intel_predstavila_10-nm_processor--ccc09a7b344ea528de8ee6d97402e466?lr=213&lang=ru&stid=YIvVZX4-Wi0N55wVEIxp&";

                label2.Text = "Компания AMD представила мобильные процессоры Ryzen нового поколения";
                linkLabel2.Text = "https://news.yandex.ru/yandsearch?lr=213&cl4url=ufatime.ru%2Fnews%2F2019%2F01%2F07%2Fkompaniya-amd-predstavila-mobilnye-processory-ryzen-novogo-pokoleniya%2F&";
            }
            else if (comboBox2.SelectedItem == "Видеокарты")
            {
                label1.Text = "Появилась первая информация о видеокарте GeForce RTX 2050/GTX 1150";
                linkLabel1.Text = "https://dtf.ru/hard/35079-poyavilas-pervaya-informaciya-o-videokarte-geforce-rtx-2050-gtx-1150";

                label2.Text = "Nvidia представила Titan RTX за 221 990 рублей";
                linkLabel2.Text = "https://dtf.ru/hard/32773-nvidia-predstavila-titan-rtx-za-221-990-rubley";

                label3.Text = "AMD пока не планирует внедрение рейтрейсинга — консоли следующего поколения могут выйти без этой технологии";
                linkLabel3.Text = "https://dtf.ru/hard/31298-amd-poka-ne-planiruet-vnedrenie-reytreysinga-konsoli-sleduyushchego-pokoleniya-mogut-vyyti-bez-etoy-tehnologii";

                label4.Text = "Стала известна цена Gigabyte GeForce RTX 2060";
                linkLabel4.Text = "https://dtf.ru/hard/35869-izvestna-cena-gigabyte-geforce-rtx-2060";
            }
            else if (comboBox2.SelectedItem == "Ноутбуки")
            {
                label1.Text = "Lenovo показала на CES 2019 игровые ноутбуки с графикой GeForce RTX";
                linkLabel1.Text = "https://news.yandex.ru/story/Lenovo_pokazala_na_CES_2019_igrovye_noutbuki_s_grafikoj_GeForce_RTX--be00248183ec72d4cbfa43e921c6114e?lr=213&lang=ru&stid=EIlw0VWFu2nC&";

                label2.Text = "CES 2019: MSI представила ультрабук с видеокартой RTX 2080";
                linkLabel2.Text = "https://dtf.ru/hard/35989-ces-2019-msi-predstavila-ultrabuk-s-videokartoy-rtx-2080";

                label3.Text = "Samsung представила свой новый игровой ноутбук Notebook Odyssey";
                linkLabel3.Text = "https://news.yandex.ru/yandsearch?lr=213&cl4url=https%3A%2F%2Fslovodel.com%2F519829-samsung-predstavila-svoi-novyi-igrovoi-noutbuk-notebook-odyssey&";

                label4.Text = "ASUS показал на CES новый игровой ноутбук ROG Mothership";
                linkLabel4.Text = "https://news.yandex.ru/yandsearch?lr=213&cl4url=runews24.ru%2Ftechnology%2F08%2F01%2F2019%2F60662e236ae32836738de0aff292f2df&";
            }
            else if (comboBox2.SelectedItem == "Смартфоны")
            {
                label1.Text = "Очень легкий смартфон Sharp Aquos Zero стал доступен для заказа";
                linkLabel1.Text = "https://news.yandex.ru/story/Ochen_legkij_smartfon_Sharp_Aquos_Zero_stal_dostupen_dlya_zakaza--4a55bdcbeaf3c951b3c68c3f4dc2b91b?lr=213&lang=ru&stid=Qx0WyWZ545yIopLJutfd&";

                label2.Text = "Компания FlexPai показала первый складной смартфон Royole";
                linkLabel2.Text = "https://news.yandex.ru/story/Kompaniya_FlexPai_pokazala_pervyj_skladnoj_smartfon_Royole--c5b6bd5ced9d8b7a20940d59edea8824?lr=213&lang=ru&stid=XZntzOke_5Euw9DpHVxO&";

                label3.Text = "Huawei представила смартфон Honor V20 — со стриминговым сервисом для запуска AAA-игр";
                linkLabel3.Text = "https://dtf.ru/hard/35195-huawei-predstavila-smartfon-honor-v20-so-strimingovym-servisom-dlya-zapuska-aaa-igr";
            }
            else if (comboBox2.SelectedItem == "Телевизоры")
            {
                label1.Text = "LG представила скручивающийся 4К-телевизор";
                linkLabel1.Text = "https://news.yandex.ru/story/LG_predstavila_skruchivayushhijsya_4K-televizor--9e5cb3bf68bc2daee0cd077fba63e811?lr=213&lang=ru&stid=E6aXufhdvki38hSTD_C6&";

                label2.Text = "Sony привезла на CES 2019 телевизоры с разрешением 8K";
                linkLabel2.Text = "https://news.yandex.ru/story/Sony_privezla_na_CES_2019_televizory_s_razresheniem_8K--48cea88930a56819e07f14cd9f342750?lr=213&lang=ru&stid=I-s_qKLsMxc_IXnl-f4l&";

                label3.Text = "Телевизоры Samsung начнут поддерживать iTunes Movies и AirPlay 2 весной 2019 года";
                linkLabel3.Text = "https://dtf.ru/hard/35942-televizory-samsung-nachnut-podderzhivat-itunes-movies-i-airplay-2-vesnoy-2019-goda";
            }
            else if (comboBox2.SelectedItem == "Наушники")
            {
                label1.Text = "Xiaomi представила аналог AirPods";
                linkLabel1.Text = "https://news.yandex.ru/story/Xiaomi_predstavila_analog_AirPods--f44dbe16e8285d47b540c17123365c98?lr=213&lang=ru&stid=oDEj002cTwZ2UnFTMNIU&";

                label2.Text = "Creative показала наушники SXFI AIR";
                linkLabel2.Text = "https://news.yandex.ru/yandsearch?lr=213&cl4url=https%3A%2F%2Fmegaobzor.com%2FCreative-pokazala-nauShniki-SXFI-AIR.html&";
            }
            else if (comboBox2.SelectedItem == "Анонсы")
            {
                label1.Text = "HBO объявил основной актёрский состав приквела «Игры престолов»";
                linkLabel1.Text = "https://dtf.ru/cinema/36058-hbo-obyavil-osnovnoy-akterskiy-sostav-prikvela-igry-prestolov";

                label2.Text = "Сериал «24 часа» получит японский ремейк";
                linkLabel2.Text = "https://dtf.ru/cinema/36052-serial-24-chasa-poluchit-yaponskiy-remeyk";

                label3.Text = "Дейв Батиста присоединился к «Дюне» Вильнёва";
                linkLabel3.Text = "https://dtf.ru/cinema/35998-deyv-batista-prisoedinilsya-k-dyune-vilneva";

                label4.Text = "Дэнни ДэВито присоединился к актёрскому составу второй части «Джуманджи: Зов джунглей»";
                linkLabel4.Text = "https://dtf.ru/cinema/35836-denni-devito-prisoedinilsya-k-akterskomu-sostavu-vtoroy-chasti-dzhumandzhi-zov-dzhungley";

                label5.Text = "Съёмки фильма про Бэтмена начнутся в ноябре";
                linkLabel5.Text = "https://dtf.ru/cinema/35826-thr-semki-filma-pro-betmena-nachnutsya-v-noyabre";
            }
            else if (comboBox2.SelectedItem == "Трейлеры кино")
            {
                label1.Text = "Постеры и расширенный трейлер «Капитана Марвел»";
                linkLabel1.Text = "https://dtf.ru/cinema/36001-postery-i-rasshirennyy-treyler-kapitana-marvel";

                label2.Text = "«Carmen Sandiego» — трейлер анимационного сериала от Netflix";
                linkLabel2.Text = "https://dtf.ru/cinema/35974-carmen-sandiego-treyler-animacionnogo-seriala-ot-netflix";

                label3.Text = "Киллер Мадс Миккельсен: трейлер боевика Polar для Netflix";
                linkLabel3.Text = "https://dtf.ru/cinema/35968-killer-mads-mikkelsen-treyler-boevika-polar-dlya-netflix";
            }
            else if (comboBox2.SelectedItem == "Премии")
            {
                label1.Text = "Итоги вручения премии «Золотой глобус 2019»";
                linkLabel1.Text = "https://dtf.ru/cinema/35933-itogi-vrucheniya-premii-zolotoy-globus-2019";

                label2.Text = "Гильдия сценаристов Америки назвала номинантов своей премии";
                linkLabel2.Text = "https://www.kinopoisk.ru/news/3309807/";
            }
            else if (comboBox2.SelectedItem == "Игровая индустрия")
            {
                label1.Text = "Глава Epic Games оказался богаче основателя Valve";
                linkLabel1.Text = "https://dtf.ru/gameindustry/36062-glava-epic-games-okazalsya-bogache-osnovatelya-valve";

                label2.Text = "Sony: PlayStation 4 разошлась тиражом больше 91,6 миллиона экземпляров, а Spider-Man — больше 9 миллионов копий";
                linkLabel2.Text = "https://dtf.ru/gameindustry/36013-sony-playstation-4-razoshlas-tirazhom-bolshe-91-6-milliona-ekzemplyarov-a-spider-man-bolshe-9-millionov-kopiy";

                label3.Text = "В первую неделю 2019 года FIFA 19 вернулась на верхнюю строчку британского розничного чарта";
                linkLabel3.Text = "https://dtf.ru/gameindustry/35961-v-pervuyu-nedelyu-2019-goda-fifa-19-vernulas-na-verhnyuyu-strochku-britanskogo-roznichnogo-charta";
            }
            else if (comboBox2.SelectedItem == "Трейлеры игр")
            {
                label1.Text = "Сюжетный трейлер Metro Exodus";
                linkLabel1.Text = "https://dtf.ru/games/36033-syuzhetnyy-treyler-metro-exodus";

                label2.Text = "Трейлер Dragon's Dogma: Dark Arisen для Switch";
                linkLabel2.Text = "https://dtf.ru/games/36031-treyler-dragon-s-dogma-dark-arisen-dlya-switch";

                label3.Text = "Трейлер третьего эпизода The Walking Dead: The Final Season";
                linkLabel3.Text = "https://dtf.ru/games/35976-treyler-tretego-epizoda-the-walking-dead-the-final-season";

                label4.Text = "Трейлер Anthem с презентации Nvidia на CES 2019";
                linkLabel4.Text = "https://dtf.ru/games/35932-treyler-anthem-s-prezentacii-nvidia-na-ces-2019";
            }
            else if (comboBox2.SelectedItem == "Разработка игр")
            {
                label1.Text = "Создатели игрового движка Corona открыли его исходный код";
                linkLabel1.Text = "https://dtf.ru/gamedev/35755-sozdateli-igrovogo-dvizhka-corona-otkryli-ego-ishodnyy-kod";

                label2.Text = "Итоги чемпионата «Одноклассников» для разработчиков HTML5-игр";
                linkLabel2.Text = "https://dtf.ru/gamedev/33903-itogi-chempionata-odnoklassnikov-dlya-razrabotchikov-html5-igr";

                label3.Text = "Nvidia сделала код физического движка PhysX открытым";
                linkLabel3.Text = "https://dtf.ru/gamedev/32789-nvidia-sdelala-kod-fizicheskogo-dvizhka-physx-otkrytym";

                label4.Text = "Nvidia показала автомобильный симулятор, графику для которого на основе видео создал ИИ";
                linkLabel4.Text = "https://dtf.ru/gamedev/32772-nvidia-pokazala-avtomobilnyy-simulyator-grafiku-dlya-kotorogo-na-osnove-video-sozdal-ii";

                label5.Text = "В России издадут книгу «Разработка игр на Unreal Engine 4 за 24 часа» при поддержке Epic Games";
                linkLabel5.Text = "https://dtf.ru/gamedev/32352-v-rossii-izdadut-knigu-razrabotka-igr-na-unreal-engine-4-za-24-chasa-pri-podderzhke-epic-games";
            }
            
        }
    }
}
