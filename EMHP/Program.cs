using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Linq;
using System.Globalization;
namespace EMHP
{
    #region Components
    public class site
    {
        public List<string> sitename = new List<string>();
        public string ip = "";
        public bool banned = false;
    }
    public class hosts
    {
        public static site[] getsite()
        {
            string[] input = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts");

            int i = 0;

            foreach (string str in input)
            {
                if (!str.StartsWith("#"))
                {
                    i++;
                }

                site[] output = new site[i];

                for (int I = 0; I < i; I++)
                {
                    if (!str.StartsWith("#"))
                    {
                        output[I] = new site();
                    }
                }


            }








            return null;
        }

    }
    /*public static  class translator
    {
        public static string Language = "builtin";
        static List<string> langs = new List<string>();
        static Dictionary<string, Dictionary<string, string>> translationdictionary = new Dictionary<string, Dictionary<string, string>>();
        static void parse(string[] input, string lang)
        {
            foreach (string str in input)
            {
                if (!str.StartsWith("#"))
                {
                    translationdictionary[lang].Add(str.Substring(0, str.IndexOf(' ')), str.Substring(str.IndexOf(' ') + 1));
                }
            }
        }
        static void create(string langname)
        {
            if (!langs.Contains(langname))
            {
                try
                {
                    parse(File.ReadAllLines(Environment.CurrentDirectory + "\\translations\\" + langname + "\\hostspatcher.mo"), langname);
                    langs.Add(langname);
                }
                catch (System.Exception) { }
            }
        }
        public static string _(string expr)
        {
            if (Language == "builtin")
            {
                return expr.Replace("%space%", " "); ;
            }
            if (!langs.Contains(Language))
            {
                create(Language);
            }
            if (!String.IsNullOrEmpty(translationdictionary[Language][expr.Replace("%space%", " ")]))
            {
                return translationdictionary[Language][expr.Replace("%space%", " ")];
            }
            else
            {
                return expr;
            }
        }
    }*/
#endregion
    static class Program
    {
        public static bool m = false;
        public static bool developer;
        public static CultureInfo culture = CultureInfo.CurrentUICulture;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                m = args.Count<string>(x => (x == "-m")) > 0;
            }
            catch { }
            #if DEBUG
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            developer = args.Count<string>(x => (x == "--developer")) > 0;
            try
            {
                string c = args.First<string>(x => (x.StartsWith("--culture="))).Substring("--culture=".Length);
                culture = string.IsNullOrEmpty(c) ? CultureInfo.CurrentUICulture : new CultureInfo(c);
            }
            catch { }
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            #endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_main());
        }
    }


}