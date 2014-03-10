using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;
using vente_embarque.Model;

namespace vente_embarque.presenter.Secteur
{
    public class EditSecteurPresenterPage : IEditSecteurPagePresenter
    {
        private readonly IEditSecteurView _EditSecteurView;
        private IRepository<Wilaya, Guid> _repositoryWilaya;
        public EditSecteurPresenterPage(IEditSecteurView editSecteurView,IRepository<Wilaya,Guid> repository)
        {
            _EditSecteurView = editSecteurView;
            _repositoryWilaya = repository;
        }

        public void Display()
        {
            _EditSecteurView.Wilayas = _repositoryWilaya.FindAll();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IEditSecteurPagePresenter
    {
        void Display();
        void Write();
    }
}
