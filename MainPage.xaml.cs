using Windows.ApplicationModel.DataTransfer;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using System;
using Windows.Storage;
using Windows.Foundation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Copy_Emoticons
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }




        // String com os emoticons
        public void setEmoticons()
        {
            string[] emoticonsHappy = new string[]
            { @"( ͡° ͜ʖ ͡°)", @"¯\_(ツ)_/¯", @"(◡ ‿ ◡ ✿)", @"ʕ •ᴥ•ʔ", @"(◕‿◕✿)", @"(ᵔᴥᵔ)",
            @"( ˘ ³˘)♥", @"ʕノ•ᴥ•ʔノ ︵ ┻━┻", @"(=^ェ^=)", @"♥‿♥", @"(●‿●✿)", @"ლ(╹◡╹ლ)",
            @"˙ ͜ʟ˙", @"(❍ᴥ❍ʋ)", @"◕‿◕", @"(｡◕‿‿◕｡)", @"ヾ(⌐■_■)ノ♪", @"(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧", @"(⌐■_■)", @"◉‿◉",
            @"┬┴┬┴┤ʕ•ᴥ├┬┴┬┴", @"╮ (. ❛ ᴗ ❛.) ╭", @"ヽ༼ຈل͜ຈ༽ﾉ", @"♪┏(・o･)┛♪", @"ʘ‿ʘ", @"(/) (°,,°) (/)", @"~(˘▾˘~)", @"ˁ˚ᴥ˚ˀ", @"(◠◡◠)", @"（╹ェ╹）",
            @"(｡◕‿◕｡)", @"•ᴥ•", @"(◑‿◐)", @"( ° ͜ʖ °)" , @"✖‿✖", @"(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧", @"ᕙ( ͡° ͜ʖ ͡°)ᕗ",
            @"\(-ㅂ-)/ ♥ ♥ ♥", @"◦°˚\(*❛‿❛)/˚°◦", @"( ・∀・)っ旦", @"(ღ˘⌣˘ღ)", @"(⊃｡•́‿•̀｡)⊃━☆ﾟ.*･｡ﾟ", @"ლ(o◡oლ)﻿﻿",
            @"=＾● ⋏ ●＾=", @"┻━┻ ︵ ლ(⌒-⌒ლ)", @"♡＾▽＾♡", @"(~^.^)~", @"( Ո‿Ո)", @"☢◡☢",
            @"(◞ิᴗ◟ิ*)", @"¯\_(シ)_/¯", @"¯\_◉‿◉_/¯", @"(^_^ '')", @"(⚈᷀᷁ᴗ⚈᷀᷁⁎)", @"ก็็็็็็็็็็็็็ʕ•͡ᴥ•ʔ ก้้้้้้้้้้้", @"☆.' `. ☽¸.☆
(๏̯͡๏)(๏̯͡๏)
( , ,)( , ,).
¯**'¯**'¯`", "(◠‿◠✿) ", "(◠﹏◠✿)", "（＊＾Ｕ＾）人（≧Ｖ≦＊）/", @"( ͡°ᴥ ͡° ʋ)", "ôヮô", "∧( ‘Θ’ )∧",
                "(¤﹏¤)", "●‿●", "ʕ·ᴥ·ʔ", "＼（＾○＾）人（＾○＾）／", "ヾ(＠⌒▽⌒＠)ﾉ", "(°∀°)", "ヾ｜￣ー￣｜ﾉ",
                " (☉‿☉✿)", "┏(＾0＾)┛┗(＾0＾) ┓", " (◡‿◡✿)", "✿◕ ‿ ◕✿ ", "ヽ(‘ ∇‘ )ノ", " ☆(❁‿❁)☆ ",
                "❀◕ ‿ ◕❀", "ヽ(^◇^*)/", "(•⊙ω⊙•)", "!⑈ˆ~ˆ!⑈", "(*^ -^*)", "(⊙‿⊙✿)", "◕3◕ ", "(ﾟヮﾟ)", "¢‿¢",
                "ヅ", "●ᴥ●", "(∪ ◡ ∪)", "≖‿≖", "≧◡≦", "٩◔‿◔۶", "｡◕ ‿ ◕｡", "ヾ(＠＾▽＾＠)ﾉ", "◃┆◉◡◉┆▷",
                "(✿◠‿◠)", "(￣ｰ￣)", "╰(◡‿◡✿╰) ", "~,~", " (ﾉ◕ヮ◕)ﾉ*:･ﾟ✧", "(*~▽~)", "❀‿❀", "◕‿◕",
                "(^L^)", "(^▽^)", " ◕ ◡ ◕", "(◕‿◕✿)", "（ ；´Д｀）", "⊙﹏⊙", " ✿｡✿", "ヽ(゜∇゜)ノ",
                " ｡(✿‿✿)｡", "(´ー｀)", "ツ", "q(❂‿❂)p", "( ◕◞ε◟◕`)", "☆(◒‿◒)☆", "(∩▂∩)", "(¬‿¬)",
                "(^Ｏ^)", "ʘ‿ʘ", "（’◎’）", "(◜௰◝)", "(^ｰ^)", "(o´ω｀o) ", " (^з^)-☆", "(◕ω◕✿)",
                "(づ｡◕‿‿◕｡)づ", "(ﾟ▽^*)", @"✌(◕‿-)✌", @"✌(-‿-)✌","(⌒o⌒)", " (｡◕‿◕｡) ", "ت", "(. ﾟーﾟ)", "१˚◡˚५", "＼(●~▽~●)",
                "(*˘︶˘*)", "(✪㉨✪)", "(ᅌᴗᅌ* )", "^L^", "(\\/) (°„°) (\\/)", "＼(*^▽^*)/", "(◠△◠✿)",
                "( ಠ◡ಠ )", "(〃^∇^)ﾉ", "^^", "|◔◡◉|", "(●⌒∇⌒●)", "⊂◉‿◉つ", ".ʕʘ‿ʘʔ.", "(*・∀・*)人(*・∀・*)",
                "＼(^-^)／", "∩(︶▽︶)∩", "（☉∀☉）", "(´ω｀)", "●﹏●", "（ ´∀｀）☆", "•ᴥ•", "✿◕ ‿ ◕✿", "(≧◡≦)",
                "(◡‿◡✿)", "(･ｪ-)", "^‿^", "٩(̾●̮̮̃̾•̃̾)۶", "≖‿≖", "(⊙ω⊙✿)", "٩(-̮̮̃•̃)", " (´･ω･`)", "◤(¬‿¬)◥", "^.^", "(•‿•)",
                "（＾⊆＾）", "^( '‿' )^", "☆d(o⌒∇⌒o)b", "∑(゜Д゜;)", "(▰˘◡˘▰)", "(• ε •)", " ( ° ʖ °)",
                "(\\/) (°,,°) (\\/)", "(￣(エ)￣)", "{◕ ◡ ◕}", "(>‘o’)>", "シ", "(❀‿❀)", "< (^^,) >",
                "ヾ(●⌒∇⌒●)ﾉ", "（ ´∀｀）", "☾˙❀‿❀˙☽", "°٢°", "^o^", "(=ﾟωﾟ)ﾉ", "٩(●̮̮̃•̃)۶",
                "(☞ﾟ∀ﾟ)☞", "(=゜ω゜)", " (｡✿‿✿｡)", "ó‿ó", "◎[‿]◎", "(▰˘◡˘▰) ", "(︶ω︶)",
                "(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧", "(◠ω◠✿)", "٩(^‿^)۶", "(●*∩_∩*●)", "٩(-̮̮̃-̃)۶", "<丶´Д｀>", " (✿◠‿◠) ",
                "ヽ(´▽｀)ノ", "(°⌣°)", "☆(❁‿❁)☆", "(० ०)", "٩(-̮̮̃•̃)۶", "（╹ェ╹）", "ᵔᴥᵔ", "•(_)•",
                "ヽ( ´ ∇ ｀ )ノ", "（ミ￣ー￣ミ）", "(─‿‿─)", " ~(^з^)- ", "(*≗*)", "⊙ω⊙ ", "(´･ω･`)",
                "(｡◕‿◕｡)", ".=^.^=", "(◠︿◠✿)", "ッ", "(`･ω･´)", "´ ▽ ` )ﾉ", "(´∀｀)", "(◑‿◐)",
                "ヽ(ﾟｰﾟ*ヽ)ヽ(*ﾟｰﾟ*)ﾉ(ﾉ*ﾟｰﾟ)ﾉ", "˚ᆺ˚", "ヽ(〃＾▽＾〃)ﾉ", "｡◕‿◕｡", " ❀◕ ‿ ◕❀",
                "( °٢° )", "Ü", "(●´ω｀●)", "<('o'<)", "◕‿◕", " ᵔᴥᵔ", "◙‿◙"};

            string[] emoticonsSad = new string[]
            { @"( ͡° ʖ̯ ͡°)", @"┌∩┐(◣_◢)┌∩┐", @"t(-.-t)", @"(╯°□°)╯︵ ┻━┻", @"( ︶︿︶)_╭∩╮",
            @"┬─┬﻿ ︵ /(.□. \）", @"(¬_¬)", @"ಠ╭╮ಠ", @"(ง'̀-'́)ง", @"(ÒДÓױ)", @"⊙﹏⊙", @"(._.)",
            @"( ˘︹˘ )", @"●︿●", @"ლ(ಠ益ಠლ)", @"(◞‸◟；)", @"(●´⌓`●)",
            @"(ㆆ▃ㆆ)", @"(っ˘̩╭╮˘̩)っ", @"(ᗒᗩᗕ)՞", @"（　ﾟ Дﾟ)ノ", @"o͡͡͡╮༼ • ʖ̯ • ༽╭o͡͡͡", @"(>°-°)>",
            @"ლ(ಥ Д ಥ )ლ", @"┏༼ •́ ╭╮ •̀ ༽┓", @"໒( ͡; 益 ͡; )७┌∩┐", @"(╯°□°）╯︵ ( . 0 .)", @"( ◔ ʖ̯ ◔ )",
            @"(◔ д◔)", @"(-_-｡)", @"( ͡° ʖ̯ ͡°)", @"¯\_| ಠ ∧ ಠ |_/¯", @"୧( ಠ Д ಠ )୨", @"༼ •̀ ₒ •́ ༽",
            @"─=≡Σ(((༼つಠ益ಠ༽つ", @"ლ(ಠ益ಠლ)", @"凸( •̀ 3 •́ )凸", @"୧ʕ•̀ᴥ•́ʔ୨", @"(╯°□°）╯︵ ( . 0 .)",
            @"୧༼ ͡◕ д ◕͡ ༽୨", @"ヽ(ಠ▃ಠ)ﾉ", @"(ಥ﹏ಥ)", @"༼つ☯﹏☯༽つ", @"╰[ ⁰﹏⁰ ]╯", @"ʕ⊙ᴥ⊙ʔ",
            @"╰(”◕﹏◕”)つ", @"〳 ͡° Ĺ̯ ͡° 〵", @"(っ ºДº)っ ︵ ⌨", @"( ⊙ ʖ̯ ⊙ )", @"▐ ∗ ᵒ̌ 〜 ᵒ̌ ∗ ▐",
            @"༼    ಠ   ͟ʖ  ಠ   ༽", @"( ཀ͝ ∧ ཀ͝ )", @"(ノಠ益ಠ)ノ彡┻━┻"};

            string[] emoticonsNeutral = new string[]
            { @"◉_◉", @"┐( ˘_˘)┌", @"(⊙＿⊙')", @"(⊙⊙)", @"(  ⚆ _ ⚆ )", @"(♥_♥)",
            @"L(・o・)」", @"ಠ_ಠ", @"ಠ_ರೃ", @"(◔_◔)", @"¯\_ಠ_ಠ_/¯", @"[+..••]", @"[¬º-°]¬",
            @"(•_•)", @"▘▂▝", @"⚆ _ ⚆", @"(/❛o❛\)", @"ヘ(◕。◕ヘ)", @"༼ つ ◕_◕ ༽つ",
            @"¯\(º_o)/¯", @"┬─┬﻿ ノ( ゜-゜ノ)", @"(✪㉨✪)", @"\( •_•)_†", @"( •_•)>⌐■-■", @"[̲̅$̲̅(̲̅5̲̅)̲̅$̲̅]", @"△",
            @"ⅽ[ː̠̈ː̠̈ː̠̈] ͌", @"o()xxxx[{::::::::::::::::::::::::::::::::::>"};


            createButtons(emoticonsHappy, "happy");
            createButtons(emoticonsSad, "sad");
            createButtons(emoticonsNeutral, "neutral");


            getFavourites();
        }

        void createButtons(string[] emoticons, string tab)
        {
            int buttonNum = 0;
            foreach (string item in emoticons)
            {
                Button button = new Button();

                button.Content = emoticons[buttonNum];
                button.Name = tab + "Btn" + buttonNum.ToString();
                button.Height = 40;
                button.HorizontalAlignment = HorizontalAlignment.Left;
                button.VerticalAlignment = VerticalAlignment.Top;
                button.Click += new RoutedEventHandler(tapOnButtonAction);
                button.DoubleTapped += Button_DoubleTapped;
                button.Tag = tab;
                button.Style = Application.Current.Resources["ButtonStyle1"] as Style;



                buttonNum++;

                switch (tab)
                {
                    case "happy":
                        ButtonPanelHappy.Children.Add(button);
                        break;
                    case "sad":
                        ButtonPanelSad.Children.Add(button);
                        break;
                    case "neutral":
                        ButtonPanelNeutral.Children.Add(button);
                        break;
                    case "favourites":
                        ButtonPanelFav.Children.Add(button);
                        break;
                }
            }

        }

        // Usuário clica em qualquer dos botões
        void tapOnButtonAction(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                CopyTextToClipboard((string)button.Content);
            }
        }

        // Copia a string para a área de transferencia
        public void CopyTextToClipboard(string textToCopy)
        {
            var dataPackage = new DataPackage();
            dataPackage.SetText(textToCopy);
            Clipboard.SetContent(dataPackage);

            PivotTabButton6.Content = "";
            DelayAction(1000, new Action(() => {
                PivotTabButton6.Content = "";
            }));

        }

        public static void DelayAction(int millisecond, Action action)
        {
            var timer = new DispatcherTimer();
            timer.Tick += delegate

            {
                action.Invoke();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromMilliseconds(millisecond);
            timer.Start();
        }

        // Navegação das páginas
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;


            if (settings.Containers.ContainsKey("Favoritos"))
            {
                if (settings.Containers["Favoritos"].Values.Count > 0)
                {
                    MainPivot.SelectedIndex = 3;
                }
            }

            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;

            ButtonPanelFav.Children.Clear();
            ButtonPanelHappy.Children.Clear();
            ButtonPanelSad.Children.Clear();
            ButtonPanelNeutral.Children.Clear();
            setEmoticons();
            updateLayout();
        }

        // aplica cor na barra de status do windows


        // converte string HEX para Cor
        public Color ConvertStringToColor(String hex)
        {
            // Tira o # do codigo hex
            hex = hex.Replace("#", "");

            byte a = 255;
            byte r = 255;
            byte g = 255;
            byte b = 255;

            int start = 0;

            if (hex.Length == 8)
            {
                a = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                start = 2;
            }

            // Converte os caracteres RGB para bytes
            r = byte.Parse(hex.Substring(start, 2), System.Globalization.NumberStyles.HexNumber);
            g = byte.Parse(hex.Substring(start + 2, 2), System.Globalization.NumberStyles.HexNumber);
            b = byte.Parse(hex.Substring(start + 4, 2), System.Globalization.NumberStyles.HexNumber);

            return Color.FromArgb(a, r, g, b);
        }

        public static Brush ColorToBrush(string color) // color = "#E7E44D"
        {
            color = color.Replace("#", "");
            if (color.Length == 6)
            {
                return new SolidColorBrush(ColorHelper.FromArgb(255,
                    byte.Parse(color.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                    byte.Parse(color.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                    byte.Parse(color.Substring(4, 2), System.Globalization.NumberStyles.HexNumber)));
            }
            else
            {
                return null;
            }
        }

        // Pivot tabs
        private void PivotTabButton1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainPivot.SelectedIndex = 0;
        }
        private void PivotTabButton2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainPivot.SelectedIndex = 1;
        }
        private void PivotTabButton3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainPivot.SelectedIndex = 2;
        }
        private void PivotTabButton4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainPivot.SelectedIndex = 3;
        }
        private void PivotTabButton5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainPivot.SelectedIndex = 4;
        }
        private void PivotTabButton6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Settings));
        }
        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((Pivot)sender).SelectedIndex)
            {
                case 0:
                    PivotTabButton1.Opacity = 1;
                    PivotTabButton2.Opacity = 0.4;
                    PivotTabButton3.Opacity = 0.4;
                    PivotTabButton4.Opacity = 0.4;
                    PivotTabButton5.Opacity = 0.4;
                    break;
                case 1:
                    PivotTabButton1.Opacity = 0.4;
                    PivotTabButton2.Opacity = 1;
                    PivotTabButton3.Opacity = 0.4;
                    PivotTabButton4.Opacity = 0.4;
                    PivotTabButton5.Opacity = 0.4;
                    break;
                case 2:
                    PivotTabButton1.Opacity = 0.4;
                    PivotTabButton2.Opacity = 0.4;
                    PivotTabButton3.Opacity = 1;
                    PivotTabButton4.Opacity = 0.4;
                    PivotTabButton5.Opacity = 0.4;
                    break;
                case 3:
                    PivotTabButton1.Opacity = 0.4;
                    PivotTabButton2.Opacity = 0.4;
                    PivotTabButton3.Opacity = 0.4;
                    PivotTabButton4.Opacity = 1;
                    PivotTabButton5.Opacity = 0.4;
                    PivotTabButton4.Content = "";
                    break;
                case 4:
                    PivotTabButton1.Opacity = 0.4;
                    PivotTabButton2.Opacity = 0.4;
                    PivotTabButton3.Opacity = 0.4;
                    PivotTabButton4.Opacity = 0.4;
                    PivotTabButton5.Opacity = 1;
                    break;
            }

        }

        private void LayoutRoot_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            updateLayout();
        }

        public void setFavourites(string emoticon)
        {
            ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;


            ApplicationDataContainer container =
               settings.CreateContainer("Favoritos", ApplicationDataCreateDisposition.Always);

            var favourites = emoticon;
            int numberOfFavs = settings.Values.Count;
            Random random = new Random();
            string settingName = "favorite" + (numberOfFavs + random.Next());
            settings.Containers["Favoritos"].Values[settingName] = favourites;

        }

        public void getFavourites()
        {
            ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;


            if (settings.Containers.ContainsKey("Favoritos"))
                foreach (var favourites in settings.Containers["Favoritos"].Values)
                {

                    Button button = new Button();

                    button.Content = favourites.Value.ToString();
                    button.Name = "favourites" + "Btn" + favourites.ToString();
                    button.Height = 40;
                    button.HorizontalAlignment = HorizontalAlignment.Left;
                    button.VerticalAlignment = VerticalAlignment.Top;
                    button.Click += new RoutedEventHandler(tapOnButtonAction);
                    button.Tag = "favourites";
                    button.Style = Application.Current.Resources["ButtonStyle1"] as Style;
                    button.DoubleTapped += Button_DoubleTapped1;
                    ButtonPanelFav.Children.Add(button);

                }

            updateLayout();
        }


        private void Button_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                CopyTextToClipboard((string)button.Content);
                if (favExists((string)button.Content) == false)
                {
                    setFavourites((string)button.Content);
                    ButtonPanelFav.Children.Clear();
                    getFavourites();
                    PivotTabButton4.Content = "";
                    PivotTabButton4.Opacity = 1;

                }
            }
        }

        private void Button_DoubleTapped1(object sender, DoubleTappedRoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {

                ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;


                if (settings.Containers.ContainsKey("Favoritos"))
                {
                    if (settings.Containers["Favoritos"].Values != null)
                    {
                        foreach (var favourites in settings.Containers["Favoritos"].Values)
                        {
                            if ((string)button.Content == favourites.Value.ToString())
                            {
                                settings.Containers["Favoritos"].Values.Remove(favourites.Key);
                            }
                        }
                    }

                }
                ButtonPanelFav.Children.Clear();
                ButtonPanelHappy.Children.Clear();
                ButtonPanelSad.Children.Clear();
                ButtonPanelNeutral.Children.Clear();
                setEmoticons();
                updateLayout();
            }
        }


        private bool favExists(string emoticon)
        {
            int foundEqual = 0;
            ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;
            if (settings.Containers.ContainsKey("Favoritos"))
            {
                foreach (var favourites in settings.Containers["Favoritos"].Values)
                {
                    if (emoticon == favourites.Value.ToString())
                    {
                        foundEqual = 1;
                    }
                }
                if (foundEqual == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        // Alinha os botões de acordo com o layout da janela
        private void updateLayout()
        {
            LayoutRoot.Measure(new Size(double.PositiveInfinity,
                                        double.PositiveInfinity));
            int windowWidth = Convert.ToInt32(LayoutRoot.DesiredSize.Width);

            if (windowWidth > 0)
            {


                int newButtonNumber = ((windowWidth - 10) / 110);

                if (newButtonNumber < 3)
                {
                    newButtonNumber = 3;
                }

                int indexBtn = 0;
                int rowIndex = 0;

                foreach (Button button in ButtonPanelHappy.Children)
                {
                    if (((string)button.Content).Length < 12 || indexBtn >= newButtonNumber - 1)
                    {
                        int buttonWidth = (windowWidth - 10) / newButtonNumber;
                        button.Width = buttonWidth - 10;
                        TranslateTransform posTransform = new TranslateTransform();
                        posTransform.X = 5 + (indexBtn * (windowWidth - 10) / newButtonNumber);
                        posTransform.Y = rowIndex;
                        button.RenderTransform = posTransform;
                    }
                    else
                    {
                        int buttonWidth = 2 * (windowWidth - 10) / newButtonNumber;
                        button.Width = buttonWidth - 10;
                        TranslateTransform posTransform = new TranslateTransform();
                        posTransform.X = 5 + (indexBtn * (windowWidth - 10) / newButtonNumber);
                        posTransform.Y = rowIndex;
                        button.RenderTransform = posTransform;
                        indexBtn++;
                    }

                    if (indexBtn >= newButtonNumber - 1)
                    {
                        indexBtn = 0;
                        rowIndex = rowIndex + 50;
                        ButtonPanelHappy.Height = rowIndex + 50;
                    }
                    else
                    {
                        indexBtn++;
                    }
                }

                indexBtn = 0;
                rowIndex = 0;

                foreach (Button button in ButtonPanelSad.Children)
                {
                    if (((string)button.Content).Length < 12 || indexBtn >= newButtonNumber - 2)
                    {
                        int buttonWidth = (windowWidth - 10) / newButtonNumber;
                        button.Width = buttonWidth - 10;
                        TranslateTransform posTransform = new TranslateTransform();
                        posTransform.X = 5 + (indexBtn * (windowWidth - 10) / newButtonNumber);
                        posTransform.Y = rowIndex;
                        button.RenderTransform = posTransform;
                    }
                    else
                    {
                        int buttonWidth = 2 * (windowWidth - 10) / newButtonNumber;
                        button.Width = buttonWidth - 10;
                        TranslateTransform posTransform = new TranslateTransform();
                        posTransform.X = 5 + (indexBtn * (windowWidth - 10) / newButtonNumber);
                        posTransform.Y = rowIndex;
                        button.RenderTransform = posTransform;
                        indexBtn++;
                    }

                    if (indexBtn >= newButtonNumber - 1)
                    {
                        indexBtn = 0;
                        rowIndex = rowIndex + 50;
                        ButtonPanelSad.Height = rowIndex + 50;
                    }
                    else
                    {
                        indexBtn++;
                    }
                }

                indexBtn = 0;
                rowIndex = 0;

                foreach (Button button in ButtonPanelNeutral.Children)
                {
                    if (((string)button.Content).Length < 13 || indexBtn >= newButtonNumber - 2)
                    {
                        int buttonWidth = (windowWidth - 10) / newButtonNumber;
                        button.Width = buttonWidth - 10;
                        TranslateTransform posTransform = new TranslateTransform();
                        posTransform.X = 5 + (indexBtn * (windowWidth - 10) / newButtonNumber);
                        posTransform.Y = rowIndex;
                        button.RenderTransform = posTransform;
                    }
                    else
                    {
                        int buttonWidth = 2 * (windowWidth - 10) / newButtonNumber;
                        button.Width = buttonWidth - 10;
                        TranslateTransform posTransform = new TranslateTransform();
                        posTransform.X = 5 + (indexBtn * (windowWidth - 10) / newButtonNumber);
                        posTransform.Y = rowIndex;
                        button.RenderTransform = posTransform;
                        indexBtn++;
                    }
                    if (indexBtn >= newButtonNumber - 1)
                    {
                        indexBtn = 0;
                        rowIndex = rowIndex + 50;
                        ButtonPanelNeutral.Height = rowIndex + 50;
                    }
                    else
                    {
                        indexBtn++;
                    }
                }

                indexBtn = 0;
                rowIndex = 0;

                if (ButtonPanelFav.Children != null)
                {


                    foreach (Button button in ButtonPanelFav.Children)
                    {
                        if (((string)button.Content).Length < 12 || indexBtn >= newButtonNumber - 1)
                        {
                            int buttonWidth = (windowWidth - 10) / newButtonNumber;
                            button.Width = buttonWidth - 10;
                            TranslateTransform posTransform = new TranslateTransform();
                            posTransform.X = 5 + (indexBtn * (windowWidth - 10) / newButtonNumber);
                            posTransform.Y = rowIndex;
                            button.RenderTransform = posTransform;
                        }
                        else
                        {
                            int buttonWidth = 2 * (windowWidth - 10) / newButtonNumber;
                            button.Width = buttonWidth - 10;
                            TranslateTransform posTransform = new TranslateTransform();
                            posTransform.X = 5 + (indexBtn * (windowWidth - 10) / newButtonNumber);
                            posTransform.Y = rowIndex;
                            button.RenderTransform = posTransform;
                            indexBtn++;
                        }

                        if (indexBtn >= newButtonNumber - 1)
                        {
                            indexBtn = 0;
                            rowIndex = rowIndex + 50;
                            ButtonPanelFav.Height = rowIndex + 50;
                        }
                        else
                        {
                            indexBtn++;
                        }
                    }

                    indexBtn = 0;
                    rowIndex = 0;

                }
            }
        }

    }


}
