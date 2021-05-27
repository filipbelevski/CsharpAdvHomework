using SEDC.TimeTracker.Data.BaseModels;
using SEDC.TimeTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTracker.Data.DataBase
{
    public abstract class GenericRepository<T>
        where T : BaseEntity
    {
        protected List<T> Db { get; set; }
        protected int LastId { get; set; }
        public GenericRepository(List<T> db, int lastId)
        {
            Db = db;
            LastId = lastId;
        }
        //CRUD
        public List<T> GetAll()
        {
            return Db;
        }
        public T GetById(int id)
        {
            return Db.FirstOrDefault(x => x.Id == id);
        }
        public int Insert(T entity)
        {
            entity.Id = ++LastId;
            Db.Add(entity);
            return entity.Id;
        }
        public void Update(T entity)
        {
            var dBentity = Db.FirstOrDefault(x => x.Id == entity.Id);
            if(dBentity != null)
            {
                dBentity = entity;
            }
        }
        public bool Remove(T entity)
        {
            var prevCount = Db.Count;
            Db.Remove(entity);
            return prevCount != Db.Count;
        }
    }
}
