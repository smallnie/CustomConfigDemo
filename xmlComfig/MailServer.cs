using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlComfig
{
    #region Client属性值直接放在Hashtable中
    //public class MailServer
    //{
    //    //存储mailServer的子节点（<address>13232@qq.com</address><userName>lhc</userName><password>2343254</password>）的值  
    //    //以及client的值  
    //    private Hashtable serverNode;

    //    //构造函数  
    //    public MailServer()
    //    {
    //        serverNode = new Hashtable();
    //    }

    //    public Hashtable ServerNode
    //    {
    //        get { return serverNode; }
    //    }

    //    public string client
    //    {
    //        get { return serverNode["client"] as string; }
    //    }

    //    public string Address
    //    {
    //        get { return serverNode["address"] as string; }
    //    }

    //    public string UserName
    //    {
    //        get { return serverNode["userName"] as string; }
    //    }

    //    public string PassWord
    //    {
    //        get { return serverNode["password"] as string; }
    //    }

    //}


    ////对应mailServerGroup  
    //public class MailServerConfig : List<MailServer>
    //{
    //    //映射provider值  
    //    public string Provider { get; set; }

    //}

    ////自定义配置节点mailServerGroup的处理程序  
    //public class MailServerConfigurationHandler : IConfigurationSectionHandler
    //{

    //    //section为MailServerGroup节点  

    //    public object Create(object parent, object configContext, System.Xml.XmlNode section)
    //    {
    //        //设置方法返回配置对象，可以是任何类型  
    //        MailServerConfig config = new MailServerConfig();

    //        //获取节点的属性信息  
    //        config.Provider = section.Attributes["provider"] == null ? "" : section.Attributes["provider"].Value;

    //        //获取MailServer节点  
    //        foreach (System.Xml.XmlNode child in section.ChildNodes)
    //        {
    //            MailServer server = new MailServer();
    //            //添加Client属性  
    //            if (child.Attributes["client"] != null)
    //            {
    //                server.ServerNode.Add("client", child.Attributes["client"].Value);
    //            }

    //            //获取MailServer下的Name,username,password节点  
    //            foreach (System.Xml.XmlNode grandChild in child.ChildNodes)
    //            {
    //                //添加文本  
    //                server.ServerNode.Add(grandChild.Name, grandChild.InnerText);
    //            }

    //            //将server加入MailServerConfig  
    //            config.Add(server);
    //        }

    //        return config;
    //    }
    //}
    #endregion
    #region Client属性值放在单独属性中


    public class MailServer
    {
        //存储mailServer的子节点（<address>13232@qq.com</address><userName>lhc</userName><password>2343254</password>）的值  
        //以及client的值  
        private Hashtable serverNode;

        //构造函数  
        public MailServer()
        {
            serverNode = new Hashtable();
        }

        public Hashtable ServerNode
        {
            get { return serverNode; }
        }

        //Client  
        public string Client { get; set; }

        public string Address
        {
            get { return serverNode["address"] as string; }
        }

        public string UserName
        {
            get { return serverNode["userName"] as string; }
        }

        public string PassWord
        {
            get { return serverNode["password"] as string; }
        }

    }
   

    //对应mailServerGroup  
    public class MailServerConfig : List<MailServer>
    {
        //映射provider值  
        public string Provider { get; set; }

    }

    //自定义配置节点mailServerGroup的处理程序  
    public class MailServerConfigurationHandler : IConfigurationSectionHandler
    {

        //section为MailServerGroup节点  

        public object Create(object parent, object configContext, System.Xml.XmlNode section)
        {
            //设置方法返回配置对象，可以是任何类型  
            MailServerConfig config = new MailServerConfig();

            //获取节点的属性信息  
            config.Provider = section.Attributes["provider"] == null ? "" : section.Attributes["provider"].Value;

            //获取MailServer节点  
            foreach (System.Xml.XmlNode child in section.ChildNodes)
            {
                MailServer server = new MailServer();
                //添加Client属性  
                if (child.Attributes["client"] != null)
                {
                    server.Client = child.Attributes["client"] == null ? "" : child.Attributes["client"].Value;
                }

                //获取MailServer下的Name,username,password节点  
                foreach (System.Xml.XmlNode grandChild in child.ChildNodes)
                {
                    //添加文本  
                    server.ServerNode.Add(grandChild.Name, grandChild.InnerText);
                }

                //将server加入MailServerConfig  
                config.Add(server);
            }

            return config;
        }
    }



    #endregion
}
