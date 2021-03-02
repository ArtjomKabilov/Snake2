//using System;
//using System.Collections.Generic;
//using System.Text;
//using WMPLib;
//namespace Snake
//{
//    class Parametrs
//    {

//        private string resourcesFolder;

//        public Parametrs()
//        {
//            var ind = Directory.GetCurrentDirectory().ToString()
//                .IndexOf("bin", StringComparison.Ordinal);

//            string binFolder =
//                Directory.GetCurrentDirectory().ToString().Substring(0, ind)
//                    .ToString();

//            resourcesFolder = binFolder + "Resources\\";
//        }

//        public string GetResourceFolder()
//        {
//            return resourcesFolder;
//        }
//    }
//}