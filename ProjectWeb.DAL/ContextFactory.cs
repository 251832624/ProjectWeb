using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting.Messaging;

namespace ProjectWeb.DAL
{
    public  class ContextFactory
    {

        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static ProjectWebDbContext GetCurrentContext()
        {
            ProjectWebDbContext _nContext = CallContext.GetData("ProjectWebDbContext") as ProjectWebDbContext;
            if (_nContext == null)
            {
                _nContext = new ProjectWebDbContext();
                CallContext.SetData("ProjectWebDbContext", _nContext);
            }
            return _nContext;
        }

    }
}
