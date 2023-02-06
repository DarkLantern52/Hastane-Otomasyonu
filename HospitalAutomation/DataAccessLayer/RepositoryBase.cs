using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.BusinessLogicLayer
{
    public class RepositoryBase<Entity,Context>
        where Entity : class,new()
        where Context : DbContext,new()
    {
        Context db=new Context();
        //---Ekleme-Güncelleme işlemlerinin yapıldığı kısım.
        public void AddOrUpdate(Entity entity)
        {
            db.Set<Entity>().AddOrUpdate(entity);
        }
        //---Silme işleminin yapıldığı kısım.
        public void Delete(Expression<Func<Entity,bool>> obj)
        {
            var model=db.Set<Entity>().FirstOrDefault(obj);
            db.Set<Entity>().Remove(model);
        }
        //---Listeleme işleminin yapıldığı kısım.
        //Eğer bir koşul belirtilmediyse tüm kayıtlar döndürülür, aksi halde sadece koşula uyan kayıtlar döndürülür.
        public List<Entity> GetList(Expression<Func<Entity, bool>> obj=null)
        {
            List<Entity> list;
            if (obj==null)
            {
                list=db.Set<Entity>().ToList();
            }
            else
            {
                list = db.Set<Entity>().Where(obj).ToList();
            }
            return list;
        }
        //---Belirtilen koşula uyan ilk kaydı döndüren listeleme işlemi.
        public Entity GetByFilter(Expression<Func<Entity, bool>> obj)
        {
            return db.Set<Entity>().FirstOrDefault(obj);
        }
        //---Yapılan değişiklikleri kaydeden işlem.
        public void Save()
        {
            db.SaveChanges();
        }
     
    }
}
