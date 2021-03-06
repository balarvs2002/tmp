﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UXDivers.Artina.Grial.Views.Navigation;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
    public static class SamplesDefinition
    {
        private static List<SampleCategory> _samplesCategoryList;
        private static List<SampleCategory> _riskItemList;
        private static List<SampleCategory> _drawerMenuList;
        private static List<SampleCategory> _bankingProductList;
        private static List<SampleCategory> _bankingProductTypeList;
        private static Dictionary<string, SampleCategory> _samplesCategories;
        private static List<Sample> _allSamples;
        private static List<SampleGroup> _samplesGroupedByCategory;
        public static string[] _ratingBGColors = {
            "#2eb398",
            "#ffc497",
            "#ea7882",
        };


        public static string[] _categoriesColors = {
            "#ffffff",
            "#f9f9f9",
            "#861350",
            "#473957",
            "#554666",
            "#5a5586",
            "#4d75a5",
            "#509acb",
            "#FFE2CB",
            "#B6E5DB",
            "#FFE2CB"
        };
        public static string[] _customColors = {
            "#7266ba",
            "#37bc9b",
            "#23b7e5",
            "#f05050"           
        };



        public static List<SampleCategory> CounterPartList
        {
            get
            {
                if (_riskItemList == null)
                    InitializeRiskSamples();

                return _riskItemList;
            }
        }
        public static List<SampleCategory> BankingProductList
        {
            get
            {
                if (_bankingProductList == null)
                    InitializeBankingProductSamples();

                return _bankingProductList;
            }
        }
        public static List<SampleCategory> ProductTypeList
        {
            get
            {
                if (_bankingProductTypeList == null)
                    InitializeBankingProductTypeListSamples();

                return _bankingProductTypeList;
            }
        }
        public static List<SampleCategory> DrawerMenuList
        {
            get
            {
                if (_drawerMenuList == null)
                    InitializeDrawerMenu();

                return _drawerMenuList;
            }
        }
        public static Random random;
        public static Color GetColor()
        {

            return Color.FromHex(_customColors[random.Next(4)]);

        } 

        internal static void InitializeRiskSamples()
        {
            random = new Random();
            var categories = new List<SampleCategory>();

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "ABC LTD",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[0]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[6],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "EINDHOVEN"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "XYZ PVT LTD",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[0]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[4],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "COLONGE"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "PQR LTD",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[2]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[3],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "GERMANY"
                }
            );


            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "MNO LTD",
                    BackgroundColor = GetColor(),
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[2]),
                    BackgroundImage = SampleData.DashboardImagesList[5],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "SPAIN"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "KJE LTD",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[1]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[1],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "INDIA"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "TRRYYSS LTD",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[1]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[7],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "SWIZ"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "GHJU LTD",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[0]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[8],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "FRANCE"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "HSBC Bank",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[2]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[0],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "ITALY"

                }
            );
            categories.Add(
               new SampleCategory
               {
                   IconColor = Color.FromHex(_categoriesColors[8]),
                   TileBGColor = Color.FromHex(_categoriesColors[1]),
                   Name = "ABC LTD",
                   RatingBackgroundColor = Color.FromHex(_ratingBGColors[2]),
                   BackgroundColor = GetColor(),
                   BackgroundImage = SampleData.DashboardImagesList[6],
                   Icon = '\uf19c',
                   Rating = 5,
                   Country = "EINDHOVEN"

               }
           );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "XYZ PVT LTD",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[1]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[4],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "COLONGE"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "PQR LTD",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[0]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[3],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "GERMANY"
                }


            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[8]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "ABC LTD",
                    RatingBackgroundColor = Color.FromHex(_ratingBGColors[0]),
                    BackgroundColor = GetColor(),
                    BackgroundImage = SampleData.DashboardImagesList[6],
                    Icon = '\uf19c',
                    Rating = 5,
                    Country = "EINDHOVEN"

                }
            );

            _riskItemList = new List<SampleCategory>();

            foreach (var sample in categories)
            {
                _riskItemList.Add(sample);
            }

        }
        internal static void InitializeDrawerMenu()
        {
            var categories = new Dictionary<string, SampleCategory>();

            categories.Add(
                "APP",
                new SampleCategory
                {


                    Name = "APP",
                    BackgroundColor = Color.FromHex(_categoriesColors[0]),
                    BackgroundImage = SampleData.DashboardImagesList[6],
                    Icon = '\uf0f6',
                    SamplesList = new List<Sample> {
                        new Sample("Risk Legal Counterpart", typeof(ProfilePage), SampleData.DashboardImagesList[6], '\uf19c'),
                        new Sample("Transactions", typeof(SocialPage), SampleData.DashboardImagesList[6], '\uf09d'),
                        new Sample("Pricing Calculator", typeof(SocialVariantPage), SampleData.DashboardImagesList[6], '\uf1ec'),
                    }
                }
            );

            categories.Add(
                "HELP",
                new SampleCategory
                {
                    Name = "HELP",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[4],
                    Icon = '\uf0f6',
                    SamplesList = new List<Sample> {
                        new Sample("Help", typeof(ArticlesListPage), SampleData.DashboardImagesList[4], '\uf128'),
                        new Sample("Technical Support", typeof(ArticlesListPage), SampleData.DashboardImagesList[4], '\uf0f6'),
                        new Sample("Send Feedback", typeof(ArticlesListVariantPage), SampleData.DashboardImagesList[4], '\uf0e0'),
                        new Sample("About Tomtra", typeof(ArticleViewPage), SampleData.DashboardImagesList[4], '\uf153'),
                    }
                }
            );


            _samplesCategories = categories;

            _samplesCategoryList = new List<SampleCategory>();

            foreach (var sample in _samplesCategories.Values)
            {
                _samplesCategoryList.Add(sample);
            }

            _allSamples = new List<Sample>();

            _samplesGroupedByCategory = new List<SampleGroup>();

            foreach (var sampleCategory in SamplesCategories.Values)
            {

                var sampleItem = new SampleGroup(sampleCategory.Name.ToUpper());

                foreach (var sample in sampleCategory.SamplesList)
                {
                    _allSamples.Add(sample);
                    sampleItem.Add(sample);
                }

                _samplesGroupedByCategory.Add(sampleItem);
            }

        }


        internal static void InitializeBankingProductSamples()
        {
            _bankingProductList = new List<SampleCategory>();

            var categories = new List<SampleCategory>();

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "Import LC",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[6],
                    Icon = '\uf0e6',
                    Country = "ITALY"
                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "Export LC",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[4],
                    Icon = '\uf0f6',
                    Country = "SWIZ"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "Discount",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[3],
                    Icon = '\uf009',
                    Country = "NETHERLANDS"

                }
            );


            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "Letter of Guarantee",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[2],
                    Icon = '\uf0c9',
                    Country = "FRANCE"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "Stand alone financing",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[5],
                    Icon = '\uf023',
                    Country = "SPAIN"

                }
            );


            foreach (var sample in categories)
            {
                _bankingProductList.Add(sample);
            }

        }

        internal static void InitializeBankingProductTypeListSamples()
        {
            _bankingProductTypeList = new List<SampleCategory>();

            var categories = new List<SampleCategory>();

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "Conf. and/or Discount",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[6],
                    Icon = '\uf0e6',
                    Country = "ITALY"
                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "Ducroire",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[4],
                    Icon = '\uf0f6',
                    Country = "SWIZ"

                }
            );

            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "Silent Confirmation",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[3],
                    Icon = '\uf009',
                    Country = "NETHERLANDS"

                }
            );


            categories.Add(
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    TileBGColor = Color.FromHex(_categoriesColors[1]),
                    Name = "SBLC",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[2],
                    Icon = '\uf0c9',
                    Country = "FRANCE"

                }
            );


            foreach (var sample in categories)
            {
                _bankingProductTypeList.Add(sample);
            }

        }



        public static List<SampleCategory> SamplesCategoryList
        {
            get
            {
                if (_samplesCategoryList == null)
                    InitializeSamples();

                return _samplesCategoryList;
            }
        }

        public static Dictionary<string, SampleCategory> SamplesCategories
        {
            get
            {
                if (_samplesCategories == null)
                {
                    InitializeSamples();
                }

                return _samplesCategories;
            }
        }

        public static List<Sample> AllSamples
        {
            get
            {
                if (_allSamples == null)
                {
                    InitializeSamples();
                }
                return _allSamples;
            }
        }

        public static List<SampleGroup> SamplesGroupedByCategory
        {
            get
            {
                if (_samplesGroupedByCategory == null)
                {
                    InitializeSamples();
                }

                return _samplesGroupedByCategory;
            }
        }


        internal static void InitializeSamples()
        {
            var categories = new Dictionary<string, SampleCategory>();

            categories.Add(
                "APP",
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    Name = "APP",
                    BackgroundColor = Color.FromHex(_categoriesColors[0]),
                    BackgroundImage = SampleData.DashboardImagesList[6],
                    Icon = '\uf0f6',
                    SamplesList = new List<Sample> {
                        new Sample("Risk Legal Counterpart", typeof(MainTabPage), SampleData.DashboardImagesList[6], '\uf19c'),
                        new Sample("Transactions", typeof(SocialPage), SampleData.DashboardImagesList[6], '\uf09d'),
                        new Sample("Pricing Calculator", typeof(DashboardPage), SampleData.DashboardImagesList[6], '\uf1ec'),
                    }
                }
            );

            categories.Add(
                "HELP",
                new SampleCategory
                {
                    IconColor = Color.FromHex(_categoriesColors[9]),
                    Name = "HELP",
                    BackgroundColor = Color.FromHex(_categoriesColors[1]),
                    BackgroundImage = SampleData.DashboardImagesList[4],
                    Icon = '\uf0f6',
                    SamplesList = new List<Sample> {
                        new Sample("Help", typeof(ArticlesListPage), SampleData.DashboardImagesList[4], '\uf128'),
                        new Sample("Technical Support", typeof(ArticlesListPage), SampleData.DashboardImagesList[4], '\uf0f6'),
                        new Sample("Send Feedback", typeof(ArticlesListVariantPage), SampleData.DashboardImagesList[4], '\uf0e0'),
                        new Sample("About Tomtra", typeof(ArticleViewPage), SampleData.DashboardImagesList[4], '\uf153'),
                    }
                }
            );


            _samplesCategories = categories;

            _samplesCategoryList = new List<SampleCategory>();

            foreach (var sample in _samplesCategories.Values)
            {
                _samplesCategoryList.Add(sample);
            }

            _allSamples = new List<Sample>();

            _samplesGroupedByCategory = new List<SampleGroup>();

            foreach (var sampleCategory in SamplesCategories.Values)
            {

                var sampleItem = new SampleGroup(sampleCategory.Name.ToUpper());

                foreach (var sample in sampleCategory.SamplesList)
                {
                    _allSamples.Add(sample);
                    sampleItem.Add(sample);
                }

                _samplesGroupedByCategory.Add(sampleItem);
            }
        }

        private static void RootPageCustomNavigation(INavigation navigation)
        {
            SampleCoordinator.RaisePresentMainMenuOnAppearance();
            navigation.PopToRootAsync();
        }
    }

    public class SampleGroup : List<Sample>
    {
        private readonly string _name;

        public SampleGroup(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
