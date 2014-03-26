using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Model;
using vente_embarque.Model.Enum;

namespace vente_embarque.presenter.Bdc
{
    class BdcPresenterPage:IBdcPagePresenter
    {
        public void Diplay()
        {
            throw new NotImplementedException();
        }
    }

    public interface IBdcPagePresenter
    {
        void Diplay();
    }

    public class ModelViewBdc
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public Priorite Priorite { get; set; }
    }
}
