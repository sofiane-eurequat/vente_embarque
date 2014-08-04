using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using vente_embarque.DataLayer;
using vente_embarque.Model;
using vente_embarque.presenter.Secteur;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class FrmEditAgentTerrain : RibbonForm
    {
        private readonly EditAgentTerrainPresenterPage _editAgentTerrainPresenter;
        private ModelViewAgentTerrain SourceAgentTerrain { get; set; }
        public IEnumerable<Sector> Secteurs { get; set; }
        public Guid IdAgentTerrain { get; set; }
        readonly bool _newAgentTerrain = true;
        public bool IsAgentTerrainModified;

        public FrmEditAgentTerrain()
        {
            InitializeComponent();
        }

        public FrmEditAgentTerrain(ModelViewAgentTerrain agentTerrain, bool newAgentTerrain)
        {
            InitializeComponent();

            var repositoryAgentTerrain = new RepositoryAgentTerrain();
            var repositorySecteur = new RepositorySector();
            _editAgentTerrainPresenter = new EditAgentTerrainPresenterPage(this, repositoryAgentTerrain, repositorySecteur);
            _editAgentTerrainPresenter.Display();

            if (!newAgentTerrain)
            {
                IdAgentTerrain = agentTerrain.Id;
                textEditNameAgentTerrain.Text = agentTerrain.Name;
            }

            _newAgentTerrain = newAgentTerrain;
            IsAgentTerrainModified = false;
            SourceAgentTerrain = agentTerrain;
        }

        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiEffacer_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditNameAgentTerrain.Text = "";
        }

        private void bbiFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbiNouveau_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }
}