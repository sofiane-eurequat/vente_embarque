using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryCategory:IRepository<Category,Guid>
    {
        public Category FindBy(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var xpocategory = uow.GetObjectByKey<XpoCategory>(id);
                var category = Map.MapInverse.MapCategory(xpocategory);
                return category;
            }
        }

        public IEnumerable<Category> FindAll()
        {
            var listeCategory = new List<Category>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var Categorys = new XPCollection<XpoCategory>(uow);
                //TODO : verifier s il est pas null
                listeCategory.AddRange(Categorys.Select(Map.MapInverse.MapCategory));
            }
            return listeCategory;
        }

        public IEnumerable<Category> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public List<Category> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Category entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                    {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                Map.Map.MapCategory(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Category entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var category = uow.GetObjectByKey<XpoCategory>(entity.id);
                category.Delete();
                uow.CommitChanges();
            }
        }
    }
}
