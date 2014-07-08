using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.DataLayer;
using vente_embarque.Model;

namespace vente_embarque.presenter.Stok
{
    public class EditStockPresenterPage:IEditStockPagePresenter
    {
        private readonly IEditStockView _editStockView;
        private readonly IRepository<Wilaya, Guid> _repositoryWilaya;
        private readonly IRepository<Stock, Guid> _repositoryStock; 

        public EditStockPresenterPage(IEditStockView editStockView,IRepository<Wilaya,Guid> repositoryWilaya, IRepository<Stock,Guid> repositoryStock)
        {
            _editStockView = editStockView;
            _repositoryWilaya = repositoryWilaya;
            _repositoryStock = repositoryStock;
        }

     

        public void Display()
        {
            _editStockView.Wilayas = _repositoryWilaya.FindAll();
        }

        public void Write(string name, Wilaya wilaya, Commune commune, string adress)
        {
            var stock = FactoryStock.CreateStock(name, wilaya, commune, adress);
            _repositoryStock.Save(stock);
        }

        public void Write(Guid id, string name, Wilaya wilaya, Commune commune, string adress)
        {
            var stock = new Stock(name)
                {
                    id = id,
                    Name = name,
                    Wilaya = wilaya,
                    Commune = commune,
                    Adress = adress
                };
            _repositoryStock.Save(stock);
        }
    }

    internal interface IEditStockPagePresenter
    {
        void Display();
        void Write(string name, Wilaya wilaya, Commune commune, string adress);
        void Write(Guid id, string name, Wilaya wilaya, Commune commune, string adress);
    }
}
