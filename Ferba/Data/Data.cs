using Ferba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Ferba.Data
{
    internal static class Data
    {
        public static List<Items> GetData()
        {
            return new()
            {
                //Animals
                new(){Name= "باز", Description = "هەڵۆ یاخود باز باڵدارێکی گۆشتخۆرە، خاوەن چاوێکی تیژە", Sound = Properties.Resources.Baz, Image = new(new Uri("./Assets/Images/Objects/Baz.jpg",UriKind.Relative))},
                new(){Name="قاز", Description="قاز باڵدارێکی ئاوییە، ڕەنگیان سپییە.", Sound = Properties.Resources.Qaz, Image = new(new Uri("./Assets/Images/Objects/Qaz.jpg",UriKind.Relative))},
                new(){Name=" كۆندەپەپۆ", Description="کۆندەپەپۆ باڵدارێکە حەز بە شوێنی چۆڵ و وێران ئەکا", Sound = Properties.Resources.Papo, Image = new(new Uri("./Assets/Images/Objects/Papo.jpg",UriKind.Relative))},
                new(){Name=" قەلەڕەش", Description="قەلەڕەش گیاندارێکی باڵدارە، حەز بە شتی بریقەدار ئەکا", Sound = Properties.Resources.QalaRash, Image = new(new Uri("./Assets/Images/Objects/QalaRash.jpg",UriKind.Relative))},
                new(){Name=" پشیلە", Description="پشیلە گیاندارێکی توکنە", Sound = Properties.Resources.Pshela, Image = new(new Uri("./Assets/Images/Objects/Pshela.jpg",UriKind.Relative))},
                new(){Name=" ماسی", Description="ماسی گیاندارێکی ئاویە، لە دەریا دەژی", Sound = Properties.Resources.Mase, Image = new(new Uri("./Assets/Images/Objects/Masi.jpg",UriKind.Relative))},
                new(){Name=" پەپولە", Description="پەپولە باڵدارێکی بەهاریە، خاوەن باڵێکی جوانە", Sound = Properties.Resources.Papula, Image = new(new Uri("./Assets/Images/Objects/Papula.jpg",UriKind.Relative))},
                new(){Name=" مریشک", Description="مریشک باڵدارێکی ماڵییە، مریشک ‌هێلکە ئەکا", Sound = Properties.Resources.Mreshk, Image = new(new Uri("./Assets/Images/Objects/Mreshk.jpg",UriKind.Relative))},
                new(){Name=" مەیموون", Description="مەیموون گیاندارێکی بڕبڕەدارە، مەیوومن مۆز دەخوا", Sound = Properties.Resources.Maymun, Image = new(new Uri("./Assets/Images/Objects/Maymun.jpg",UriKind.Relative))},
                //Clothes
                new(){Name="پانتۆڵ", Description="پانتۆڵ قوماشێکە لە قاچەکان هەڵدەکێشرێ", Sound = Properties.Resources.Pantol, Image = new(new Uri("./Assets/Images/Objects/Clothes/Pantol.jpg",UriKind.Relative))},
                new(){Name="فانیلە", Description="فانیلە، جۆرە تەنراوێکی دەزوو یا خورییە لەبەر دەکرێ", Sound = Properties.Resources.Fanila, Image = new(new Uri("./Assets/Images/Objects/Clothes/Fanila.jpg",UriKind.Relative))},
                new(){Name="كڵاوو", Description="کڵاو،شتێکی تەنکی گردە دەکرێتە سەر و هەندێ جار سەرپێچی لەسەر دەبەسترێ", Sound = Properties.Resources.Kllaw, Image = new(new Uri("./Assets/Images/Objects/Clothes/Kllaw.png",UriKind.Relative))},
                new(){Name="گۆرەوی", Description="گۆرەوی، شتێکی چنراوە لە بەن یا دەزوو دەکرێتە پێ", Sound = Properties.Resources.Gorya, Image = new(new Uri("./Assets/Images/Objects/Clothes/Gorya.jpg",UriKind.Relative))},
                new(){Name="پێڵاو", Description="پێڵاو، شتێکە لە ڕۆیندا لە پێ دەکرێ", Sound = Properties.Resources.Pellaw, Image = new(new Uri("./Assets/Images/Objects/Clothes/Pellaw.jpg",UriKind.Relative))},
                new(){Name="چاکەت", Description="جۆرە کاڵایەکی قۆڵدارە لەسەر پانتۆڵ یا کەواوە لەبەر دەکرێ", Sound = Properties.Resources.Chakat, Image = new(new Uri("./Assets/Images/Objects/Clothes/Chakat.jpg",UriKind.Relative))},
                new(){Name="تەنوورە", Description="تەنوورە تنراوێکی کچانەیە", Sound = Properties.Resources.Tanura, Image = new(new Uri("./Assets/Images/Objects/Clothes/Tanura.jpg",UriKind.Relative))},
                //Numbers
                new(){Name="یەك", Sound = Properties.Resources.Yak, Image = new(new Uri("./Assets/Images/Objects/Number/Yak.jpg",UriKind.Relative))},
                new(){Name="دوو", Sound = Properties.Resources.Dw, Image = new(new Uri("./Assets/Images/Objects/Number/Dw.jpg",UriKind.Relative))},
                new(){Name="سێ", Sound = Properties.Resources.Se, Image = new(new Uri("./Assets/Images/Objects/Number/Se.jpg",UriKind.Relative))},
                new(){Name="چوار", Sound = Properties.Resources.Char, Image = new(new Uri("./Assets/Images/Objects/Number/Char.jpg",UriKind.Relative))},
                new(){Name="پێنچ", Sound = Properties.Resources.Pench, Image = new(new Uri("./Assets/Images/Objects/Number/Pench.jpg",UriKind.Relative))},
                new(){Name="شەش", Sound = Properties.Resources.Shash, Image = new(new Uri("./Assets/Images/Objects/Number/Shash.jpg",UriKind.Relative))},
                new(){Name="حەفت", Sound = Properties.Resources.Haft, Image = new(new Uri("./Assets/Images/Objects/Number/Haft.jpg",UriKind.Relative))},
                new(){Name="هەشت", Sound = Properties.Resources.Hasht, Image = new(new Uri("./Assets/Images/Objects/Number/Hasht.jpg",UriKind.Relative))},
                new(){Name="نۆ", Sound = Properties.Resources.No, Image = new(new Uri("./Assets/Images/Objects/Number/No.jpg",UriKind.Relative))},
                new(){Name="دە", Sound = Properties.Resources.Da, Image = new(new Uri("./Assets/Images/Objects/Number/Da.jpg",UriKind.Relative))},
                //Nature
                new(){Name="چییا", Description="تاوێرێکی بەردینە", Sound = Properties.Resources.Chya, Image = new(new Uri("./Assets/Images/Objects/Nature/Chya.jpg",UriKind.Relative))},
                new(){Name="بەرد", Description="دانەی تاوێرە", Sound = Properties.Resources.Bard, Image = new(new Uri("./Assets/Images/Objects/Nature/Bard.jpg",UriKind.Relative))},
                new(){Name="ئاسمان", Description="ئاسۆی سەرووی زەمین", Sound = Properties.Resources.Asman, Image = new(new Uri("./Assets/Images/Objects/Nature/Asman.jpg",UriKind.Relative))},
                new(){Name="دار", Description="گیانلەبەرێکی سرووشتی تایبەتە", Sound = Properties.Resources.Dar, Image = new(new Uri("./Assets/Images/Objects/Nature/Dar.jpg",UriKind.Relative))},
                new(){Name="دەشت", Description="ئاسۆی پانتایی زەوییە", Sound = Properties.Resources.Dasht, Image = new(new Uri("./Assets/Images/Objects/Nature/Dasht.jpg",UriKind.Relative))},
                new(){Name="رۆژ", Description="ئەستێرەیەکی گەرمی سیستەمی ئێمەیە", Sound = Properties.Resources.Rozh, Image = new(new Uri("./Assets/Images/Objects/Nature/Rozh.jpg",UriKind.Relative))},
                new(){Name="مانگ", Description="تاوێرێکی بەردینی وەک زەویە و بەدەوری خول دەخوا", Sound = Properties.Resources.Mang, Image = new(new Uri("./Assets/Images/Objects/Nature/Mang.jpg",UriKind.Relative))},
                new(){Name="دارستان", Description="کۆمەڵەی دار", Sound = Properties.Resources.Darstan, Image = new(new Uri("./Assets/Images/Objects/Nature/Darstan.jpg",UriKind.Relative))},
                new(){Name="هەور", Description="ئاوی چڕاوە لە لە ژێر پاڵەپەستۆی هەوادا", Sound = Properties.Resources.Hawr, Image = new(new Uri("./Assets/Images/Objects/Nature/Hawr.jpg",UriKind.Relative))},
                //Colors
                 new(){Name="سوور", Sound = Properties.Resources.sur, Image = new(new Uri("./Assets/Images/Objects/Colors/swr.jpg",UriKind.Relative))},
                new(){Name="سەوز", Sound = Properties.Resources.sawz, Image = new(new Uri("./Assets/Images/Objects/Colors/kesk.jpg",UriKind.Relative))},
                new(){Name="شین", Sound = Properties.Resources.shin, Image = new(new Uri("./Assets/Images/Objects/Colors/shin.jpg",UriKind.Relative))},
                new(){Name="زەرد", Sound = Properties.Resources.zard, Image = new(new Uri("./Assets/Images/Objects/Colors/zerd.jpg",UriKind.Relative))},
                new(){Name="ڕەش", Sound = Properties.Resources.rash, Image = new(new Uri("./Assets/Images/Objects/Colors/rash.jpg",UriKind.Relative))},
                //Body
                new(){Name="دەست", Description="بە هۆی دەستەکانت دەتوانی شتەکان بگری و هەستیان پێ بکەی", Sound = Properties.Resources.hand, Image = new(new Uri("./Assets/Images/Objects/Body/dest.jpg",UriKind.Relative))},
                new(){Name="گوێ", Description="بە هۆی گوێکانت هەست بە دەنگەکانی دەورووبەر دەکەی", Sound = Properties.Resources.ear, Image = new(new Uri("./Assets/Images/Objects/Body/gwe.jpg",UriKind.Relative))},
                new(){Name="سەر", Description="سەرت بەشێکی گرنگی لەشن و مێشکیان تێدایە", Sound = Properties.Resources.head, Image = new(new Uri("./Assets/Images/Objects/Body/sar.jpg",UriKind.Relative))},
                new(){Name="ددان", Description="ددانەکانت یارمەتیت دەن لە خواردنی خۆراک", Sound = Properties.Resources.teeth, Image = new(new Uri("./Assets/Images/Objects/Body/ddan.jpg",UriKind.Relative))},
                new(){Name="لووت", Description="لوتەکانت یەرمەتیت دەدەن لە بۆن کردنی بۆنەکان", Sound = Properties.Resources.nose, Image = new(new Uri("./Assets/Images/Objects/Body/kapu.jpg",UriKind.Relative))},
            }; 
        }
    }
}


