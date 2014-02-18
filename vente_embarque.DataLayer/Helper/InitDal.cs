using vente_embarque.DataLayer.Entities.Orders;
using vente_embarque.DataLayer.Entities.Stock;

namespace vente_embarque.DataLayer.Helper
{
    public  static class InitDal
    {
        public static void Init()
        {
            var connectionString = @"data source=SOFIANE-PC\EUREQUAT;integrated security=true;initial catalog=Inventaire";

            DevExpress.Xpo.Metadata.XPDictionary dict =
            new DevExpress.Xpo.Metadata.ReflectionDictionary();
            // Initialize the XPO dictionary.
            dict.GetDataStoreSchema(typeof(XpoStock), typeof(XpoProductLine), typeof(XpoProduct), typeof(XpoSector), typeof(XpoClient), typeof(XpoOrder), typeof(XpoOrderLine), typeof(XpoWilaya), typeof(XpoCommune));


            DevExpress.Xpo.DB.IDataStore store = DevExpress.Xpo.XpoDefault.GetConnectionProvider(connectionString,
                DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            DevExpress.Xpo.XpoDefault.DataLayer = new DevExpress.Xpo.ThreadSafeDataLayer(dict, store);
            DevExpress.Xpo.XpoDefault.Session = null;

            

        }
    }
}
