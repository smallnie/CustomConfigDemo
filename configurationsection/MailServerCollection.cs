using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace configurationsection
{




    /// <summary>  
    /// Class MailServerCollection:映射mailServers节点，为一个集合类，另外还包含了很多对节点的操作方法，大部分继承自ConfigurationElementCollection  
    /// </summary>  
    /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 21:52:00</remarks>  
    public sealed class MailServerCollection : ConfigurationElementCollection
    {
        /// <summary>  
        /// 获取 <see cref="T:System.Configuration.ConfigurationElementCollection" /> 的类型。  
        /// </summary>  
        /// <value>The type of the collection.</value>  
        /// <returns>此集合的 <see cref="T:System.Configuration.ConfigurationElementCollectionType" />。</returns>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:05:08</remarks>  
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }

        }


        /// <summary>  
        /// 当在派生的类中重写时，创建一个新的 <see cref="T:System.Configuration.ConfigurationElement" />。  
        /// </summary>  
        /// <returns>新的 <see cref="T:System.Configuration.ConfigurationElement" />。</returns>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:05:03</remarks>  
        protected override ConfigurationElement CreateNewElement()
        {
            return new MailServerElement();
        }

        /// <summary>  
        /// 在派生类中重写时获取指定配置元素的元素键。  
        /// </summary>  
        /// <param name="element">要为其返回键的 <see cref="T:System.Configuration.ConfigurationElement" />。</param>  
        /// <returns>一个 <see cref="T:System.Object" />，用作指定 <see cref="T:System.Configuration.ConfigurationElement" /> 的键。</returns>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:04:51</remarks>  
        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as MailServerElement).Client;
        }

        /// <summary>  
        /// 获取在派生的类中重写时用于标识配置文件中此元素集合的名称。  
        /// </summary>  
        /// <value>The name of the element.</value>  
        /// <returns>集合的名称；否则为空字符串。默认值为空字符串。</returns>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 23:41:40</remarks>  
        protected override string ElementName
        {
            get
            {
                return "mailServer";
            }
        }


        /// <summary>  
        /// 获取集合中的元素数。  
        /// </summary>  
        /// <value>The count.</value>  
        /// <returns>集合中的元素数。</returns>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:08:24</remarks>  
        public new int Count
        {
            get { return base.Count; }
        }

        /// <summary>  
        /// 获取或设置此配置元素的属性、特性或子元素。  
        /// </summary>  
        /// <param name="index">The index.</param>  
        /// <returns>MailServerElement.</returns>  
        /// <remarks>Editor：v-liuhch</remarks>  
        public MailServerElement this[int index]
        {

            get { return BaseGet(index) as MailServerElement; }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }

        }

        /// <summary>  
        /// 获取或设置此配置元素的属性、特性或子元素。  
        /// </summary>  
        /// <param name="Name">The name.</param>  
        /// <returns>MailServerElement.</returns>  
        /// <remarks>Editor：v-liuhch</remarks>  
        public  new  MailServerElement this[string Name]
        {
            get { return BaseGet(Name) as MailServerElement; }
        }

        /// <summary>  
        /// Indexes the of.  
        /// </summary>  
        /// <param name="element">The element.</param>  
        /// <returns>System.Int32.</returns>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:24:16</remarks>  
        public int IndexOf(MailServerElement element)
        {

            return BaseIndexOf(element);
        }

        /// <summary>  
        /// Adds the specified element.  
        /// </summary>  
        /// <param name="element">The element.</param>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:26:06</remarks>  
        public void Add(MailServerElement element)
        {
            BaseAdd(element);
        }

        /// <summary>  
        /// Removes the specified element.  
        /// </summary>  
        /// <param name="element">The element.</param>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:27:01</remarks>  
        public void Remove(MailServerElement element)
        {
            if (BaseIndexOf(element) > 0)
            {
                BaseRemove(element.Client);
            }
        }

        /// <summary>  
        /// Removes at.  
        /// </summary>  
        /// <param name="index">The index.</param>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:33:29</remarks>  
        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        /// <summary>  
        /// Removes the specified client.  
        /// </summary>  
        /// <param name="client">The client.</param>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:34:04</remarks>  
        public void Remove(string client)
        {
            BaseRemove(client);
        }

        /// <summary>  
        /// Clears this instance.  
        /// </summary>  
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/27 22:34:29</remarks>  
        public void Clear()
        {
            BaseClear();
        }
    }
}
