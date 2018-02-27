using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace xmlComfig
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cc=new Class1();
            cc.Aaa = "gh";
            MailServerConfig mailServerConfig = (MailServerConfig)ConfigurationManager.GetSection("mailServerGroup");

            //读取节点值  
            mailServerConfig.ForEach(m =>
            {
                Console.WriteLine(m.Client + ";              " + m.Address + ";   " + m.UserName + ";    " + m.PassWord);
            });

            ////读取人名
            //NameValueCollection nvc = (NameValueCollection)ConfigurationManager.GetSection("Person");
            //foreach (string key in nvc.AllKeys)
            //{
            //    Console.WriteLine(key + ":" + nvc[key]);
            //}

            ////读取男人
            //IDictionary dict = (IDictionary)ConfigurationManager.GetSection("Man");
            //foreach (string key in dict.Keys)
            //{
            //    Console.WriteLine(key + ":" + dict[key]);
            //}

            //IDictionary dict1 = (IDictionary)ConfigurationManager.GetSection("Name");
            //foreach (string key in dict1.Keys)
            //{
            //    Console.WriteLine(key + ":" + dict1[key]);
            //}

            Console.ReadKey();
        }
    }
}
