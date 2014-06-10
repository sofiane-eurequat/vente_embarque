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

        public EditStockPresenterPage(IEditStockView editStockView,IRepository<Wilaya,Guid> repository)
        {
            _editStockView = editStockView;
            _repositoryWilaya = repository;
        }

     

        public void Display()
        {
            _editStockView.Wilayas = _repositoryWilaya.FindAll();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IEditStockPagePresenter
    {
        void Display();
        void Write();
    }
}
