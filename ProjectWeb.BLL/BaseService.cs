using ProjectWeb.IBLL;
using ProjectWeb.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeb.BLL
{
    /// <summary>
    /// 服务基类
    /// <remarks>创建：2017.03.14</remarks>
    /// </summary>
    public abstract class BaseService<T> : IBaseService<T> where T : class
    {
        protected IBaseRepository<T> CurrentRepository { get; set; }

        public BaseService(IBaseRepository<T> currentRepository) { CurrentRepository = currentRepository; }

        public T Add(T entity) { return CurrentRepository.Add(entity); }

        public bool Update(T entity) { return CurrentRepository.Update(entity); }

        public bool Delete(T entity) { return CurrentRepository.Delete(entity); }
    }
}
