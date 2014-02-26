﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using vente_embarque.Core.Domain;
using vente_embarque.Core.Domain.Query;
using vente_embarque.DataLayer.Entities.Stock;
using vente_embarque.DataLayer.Helper;
using vente_embarque.Model;

namespace vente_embarque.DataLayer
{
    public class RepositoryStock: IRepository<Model.Stock,Guid>
    {
        public Model.Stock FindBy(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Stock> FindAll()
        {
            AppSettingsReader config = new AppSettingsReader();
            var listestoks = new List<Model.Stock>();
            using (
                var uow = new UnitOfWork()
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var stocks = new XPCollection<XpoStock>(uow);
                listestoks.AddRange(stocks.Select(xpoStock => Map.MapInverse.MapStock(xpoStock)));
            }
            return listestoks;
        }

        public IEnumerable<Model.Stock> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Stock> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<Model.Stock> entities)
        {
            throw new NotImplementedException();
        }

        public List<Model.Stock> FindAll(List<Query> entities)
        {
            throw new NotImplementedException();
        }

        public void Save(Model.Stock entity)
        {
            AppSettingsReader config=new AppSettingsReader();
            
            using (
                var uow = new UnitOfWork()
                    {
                        ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                    })
            {
                Map.Map.MapStock(entity,uow);
                uow.CommitChanges();
            }

        }

        public void Add(Model.Stock entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Model.Stock entity)
        {
            throw new NotImplementedException();
        }
    }
}
