using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configurationsection
{
    public sealed class MailServerElement : ConfigurationElement //配置文件中的配置元素  
    {




        /// <summary>  
        /// Gets or sets the client.  
        /// </summary>  
        /// <value>The client.</value>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:05:40</remarks>  
        [ConfigurationProperty("client", IsKey = true,IsRequired = true)] 
        //client是必须的key属性，有点儿主键的意思，例如，如果定义多个client相同的节点，循环读取的话就只读取到最后一个值  
        public string Client
        {
            get { return this["client"] as string; }
            set { this["client"] = value; }

        }

        /// <summary>  
        /// Gets or sets the address.  
        /// </summary>  
        /// <value>The address.</value>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:05:38</remarks>  
        [ConfigurationProperty("address")]
        public string Address
        {
            get { return this["address"] as string; }
            set { this["address"] = value; }

        }

        /// <summary>  
        /// Gets or sets the name of the user.  
        /// </summary>  
        /// <value>The name of the user.</value>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:05:35</remarks>  
        [ConfigurationProperty("userName")]
        public string UserName
        {

            get { return this["userName"] as string; }
            set { this["userName"] = value; }

        }

        /// <summary>  
        /// Gets or sets the password.  
        /// </summary>  
        /// <value>The password.</value>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:05:33</remarks>  
        [ConfigurationProperty("password")]
        public string Password
        {

            get { return this["password"] as string; }
            set { this["password"] = value; }

        }

    }
}
