﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Bdc
{
    public class EditOrderLinePresenterPage:IEditOrderLinePagePresenter
    {
        private readonly IEditBdcView _editBdcView; 
        private readonly IRepository<Stock, Guid> _repositoryStock;
 
        public EditOrderLinePresenterPage(IEditBdcView editBdcView, IRepository<Stock,Guid> repository1)
        {
            _editBdcView = editBdcView;
            _repositoryStock = repository1;
        }

        public void Display()
        {
            _editBdcView.Stocks = _repositoryStock.FindAll();
        }

    }

    internal interface IEditOrderLinePagePresenter
    {
        void Display();
    }
}
