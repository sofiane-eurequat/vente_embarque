using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.MailClient.Win.Forms
{
    public partial class frmAgentTerrainAdd : RibbonForm
    {
        public frmAgentTerrainAdd()
        {
            InitializeComponent();
        }

        private void bbiSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiEffacer_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditNom.Text = "";
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