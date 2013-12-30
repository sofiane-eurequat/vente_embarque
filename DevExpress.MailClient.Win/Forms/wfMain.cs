using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace DevExpress.MailClient.Win.Forms {
    public partial class wfMain : DemoWaitForm {
        public wfMain() {
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(DataHelper.ApplicationArguments);
            InitializeComponent();
            ProgressPanel.Caption = DevExpress.MailClient.Win.Properties.Resources.ProgressPanelCaption;
            ProgressPanel.Description = DevExpress.MailClient.Win.Properties.Resources.ProgressPanelDescription;
        }
    }
}
