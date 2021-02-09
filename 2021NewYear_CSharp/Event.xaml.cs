using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _2021NewYear_CSharp
{
    /// <summary>
    /// Event.xaml 的交互逻辑
    /// </summary>
    public partial class Event : Window
    {
        private string[] Text = new string[] {
            "  2020年1月末，澳大利亚燃烧了数月的山火继续肆虐，并且受热浪天气影响，山火开始渐渐逼近首都堪培拉，" +
            "澳大利亚首都特区也在近20年来首次宣布进入紧急状态。据悉，2020年1月11日，本次山火季澳大利亚遇难人数上升到28人，" +
            "其中消防员人数已达4人，虽然现场有3000多名消防战士在努力参与灭火，但新南威尔士州与维多利亚州仍有80多处有大火在燃烧。",

            "  新型冠状病毒肺炎，简称“新冠肺炎”，世界卫生组织命名为“2019冠状病毒病”，是指2019新型冠状病毒感染导致的肺炎。" +
            "新冠疫情几乎肆虐了全球所有国家整个2020年。" +
            "根据一直追踪全球新冠肺炎疫情数据的worldometer发布的实时统计数据显示，截至北京时间2021年1月26日7时，" +
            "全球新冠肺炎累计确诊病例已经超过1亿例，达到100203700例，累计死亡病例超过214万例，达到2147411例。",

            "  2020年1月9日，英国下议院以330票赞成、231票反对的投票结果通过脱欧法。" +
            "2020年1月24日，欧洲理事会、欧盟委员会主席签署英国“脱欧”协议。2020年1月29日，欧洲议会全会以 621票赞成、49票否定、" +
            "13票弃权的投票结果通过英国“脱欧”协议。2020年1月30日，欧盟正式批准了英国脱欧，这是英国1月31日离开欧盟前内部程序的最后一步",

            "  东非地区蝗灾肆虐，蝗虫数量之多几十年未见，且这种现象未来可能会更加普遍。肯尼亚、埃塞俄比亚和索马里境内的东非地区，‘" +
            "多达3600亿只沙漠蝗虫大量出现，这也是东非近25年来最严重的一次蝗灾。据悉，沙漠蝗虫作为最危险的蝗虫种类，" +
            "一平方公里规模的蝗虫一天进食量就相当于3.5万人的进食量，逾十万公顷的庄稼被毁，这无疑对本就有着食物危机的非洲造成了巨大的威胁。" +
            "为此欧盟调动了1500万欧元支持联合国抗击东非几十年来最严重的沙漠蝗灾。",

            "  美股历史上总共发生过五次熔断。第1次熔断：1997年10月27日；第2次熔断：020年3月9日；第3次熔断：2020年3月12日；" +
            "第4次熔断：2020年3月16日，第5次熔断：2020年3月19日。由于2020年新冠肺炎影响导致美股在3月份短短十天内发生了四次熔断。" +
            "所谓的熔断机制，是指由于极端下跌导致交易所停止或关闭市场交易的门槛，这些等级是根据标普1987年“" +
            "熔断500指数在美国东部时间早上30分到下午25分之间下跌“第一级13%，则将触发”停盘，同样持续20%，当日交易将停止。",

            "  5月26日，一段长达10分钟的手机拍摄视频在社交网络上被点击播放了数百万次，视频中一位白人警察用膝盖死死压住弗洛伊德的脖子，" +
            "弗洛伊德趴在地上从抗争到哀求，不到8分钟时间，他最终失去了呼吸。当日，在明尼阿波利斯市，数百人聚集在事发地路口，" +
            "抗议警方的行为。5月29日，这场源于非裔男子之死的抗议已经蔓延至美国多地，持续4天。美国CNN总部遭示威者丢掷爆炸物。" +
            "6月3日发布了非裔美国人弗洛伊德的最终尸检报告，显示弗洛伊德的死亡是由于心肺骤停所致。",

            "  2020年11月4日，美国在特朗普的领导下正式退出了《巴黎协定》。实际上，早在2017年6月份，美国特朗普就在白宫宣布将要退出《巴黎协定》，" +
            "但在真正退出的这一刻，还是在全球引起了热议。迄今为止，全球超过190个签署《巴黎协定》的国家中，美国是首个、" +
            "也是唯一一个宣布退出的国家。据不完全统计，特朗普政府在2017年至2019年间，放弃了至少128项环保法规。特朗普执政以来，" +
            "带领美国频繁退出一些多边组织，在2020年7月9日，美国正式提交退出世界卫生组织的申请。",

            "  美国时间2020年8月18日，约瑟夫·拜登正式成为2020年美国民主党总统候选 。8月24日下午，" +
            "唐纳德·特朗普正式被提名为2020年美国共和党总统候选人。北京时间11月3日13点左右（美国东部时间3日凌晨），" +
            "2020年美国大选选举日投票正式开始。北京时间11月8日凌晨（美国时间11月7日），据美国媒体测算，" +
            "民主党总统候选人约瑟夫·拜登已获得超过270张选举人票 。2021年1月20日，拜登宣誓就任美国第46任总统。"
        };

        private string[] Image = new string[] {
            "pack://application:,,,/resources/event/event1.jpg",
            "pack://application:,,,/resources/event/event2.jpg",
            "pack://application:,,,/resources/event/event3.jpg",
            "pack://application:,,,/resources/event/event4.jpg",
            "pack://application:,,,/resources/event/event5.jpg",
            "pack://application:,,,/resources/event/event6.jpg",
            "pack://application:,,,/resources/event/event7.jpg",
            "pack://application:,,,/resources/event/event8.jpg",
        };

        private string[] Url = new string[]
        {
            "https://baike.baidu.com/item/%E6%BE%B3%E5%A4%A7%E5%88%A9%E4%BA%9A%E4%B8%9B%E6%9E%97%E5%A4%A7%E7%81%AB/15571010?fr=aladdin",
            "https://baike.baidu.com/item/%E6%96%B0%E5%9E%8B%E5%86%A0%E7%8A%B6%E7%97%85%E6%AF%92%E8%82%BA%E7%82%8E/24282529?fromtitle=%E6%96%B0%E5%86%A0%E8%82%BA%E7%82%8E&fromid=55661602&fr=aladdin#10",
            "https://baike.baidu.com/item/%E8%8B%B1%E5%9B%BD%E8%84%B1%E6%AC%A7/15850385?fr=aladdin",
            "https://baike.baidu.com/item/2020%E5%B9%B4%E4%B8%9C%E9%9D%9E%E8%9D%97%E7%81%BE/24393811?fr=aladdin",
            "https://baike.baidu.com/item/%E7%86%94%E6%96%AD%E6%9C%BA%E5%88%B6/1200831?fr=aladdin",
            "https://www.sohu.com/a/398533404_132930",
            "https://www.chinanews.com/gj/2020/07-11/9235352.shtml",
            "https://baike.baidu.com/item/2020%E5%B9%B4%E7%BE%8E%E5%9B%BD%E6%80%BB%E7%BB%9F%E9%80%89%E4%B8%BE/23292450?fr=aladdin"
        };

        private int num = 0;
        public Event()
        {
            InitializeComponent();
            image2.Source = new BitmapImage(new Uri(Image[0]));
            textBox.Text = Text[0];

            textBox1.Text = (num + 1).ToString();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        private void Image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Image4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            num--;
            if (num >= 0)
            {
                image2.Source = new BitmapImage(new Uri(Image[num]));
                textBox.Text = Text[num];
                textBox1.Text = (num + 1).ToString();
            }
            else
            {
                num = 7;
                image2.Source = new BitmapImage(new Uri(Image[7]));
                textBox.Text = Text[7];
                textBox1.Text = (num + 1).ToString();
            }
        }

        private void Image5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            num++;
            if (num <= 7)
            {
                image2.Source = new BitmapImage(new Uri(Image[num]));
                textBox.Text = Text[num];
                textBox1.Text = (num + 1).ToString();
            }
            else
            {
                num = 0;
                image2.Source = new BitmapImage(new Uri(Image[0]));
                textBox.Text = Text[0];
                textBox1.Text = (num+1).ToString();
            }
        }

        private void Image6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (num >= 0 && num <= 7)
                {
                    System.Diagnostics.Process.Start(Url[num]);
                }
                else
                {
                    MessageBox.Show("An array out of bounds error occurred for some reason");
                }
            }
            catch
            {
                MessageBox.Show("There are some unknown errors, will go to Baidu to get the content you need");
                System.Diagnostics.Process.Start("https://www.baidu.com");
                
            }
        }
    }
}
