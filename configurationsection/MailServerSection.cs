using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configurationsection
{
    /// <summary>  
    /// Class MailServerSection 为入口：  
    /// </summary>  
    /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 21:41:02</remarks>  
    public class MailServerSection : ConfigurationSection   //继承配置文件中节  
    {
        /// <summary>  
        /// Gets the provider.：映射mailServerGroup节点的provider  
        /// </summary>  
        /// <value>The provider.</value>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:05:59</remarks>  
        [ConfigurationProperty("provider", IsKey = true)]
        public string provider { get { return this["provider"] as string; } }

        /// <summary>  
        /// Gets or sets the mail servers.：映射新添加的节点mailServers节点；这个节点下还包含了若干个mailServer节点，因此它是一个集合类  
        /// </summary>  
        /// <value>The mail servers.</value>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:05:56</remarks>  
        [ConfigurationProperty("mailServers", IsDefaultCollection = false)]
        public MailServerCollection MailServers
        {
            get
            {
                return this["mailServers"] as MailServerCollection;
            }
            set
            {
                this["mailServers"] = value;
            }

        }
    }
}
