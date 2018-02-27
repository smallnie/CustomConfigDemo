using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configurationsection
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

        }

        /// <summary>  
        /// Tests this instance.：读取节点值示例  
        /// </summary>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 23:04:53</remarks>  
        private static void Test()
        {

            MailServerSection mailSection = (MailServerSection)ConfigurationManager.GetSection("mailServerGroup");
            Console.WriteLine("MailServerSection 的provider属性值：" + mailSection.provider);
            foreach (MailServerElement config in mailSection.MailServers)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("client值为：" + config.Client);
                Console.WriteLine("address值为：" + config.Address);
                Console.WriteLine("username值为：" + config.UserName);
                Console.WriteLine("password值为：" + config.Password);
                Console.WriteLine("----------------------------------");
            }

            Console.ReadKey();

        }
    }
}
