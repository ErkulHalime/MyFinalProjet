using Entities.Asbtract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip 
    //IEntity : IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    //new : new'lenebilir olmalı 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
    }
}
