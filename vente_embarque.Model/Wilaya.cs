using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vente_embarque.Core.Domain;

namespace vente_embarque.Model
{
    public class Wilaya:EntityBase<Guid>,IAggregateRoot
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public List<Commune> Communes { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
