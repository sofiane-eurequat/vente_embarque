using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraNavBar;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using DevExpress.LookAndFeel;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Skins;
using System.Diagnostics;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.Helpers;
using DevExpress.Utils;
using System.Collections;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSpellChecker;
using System.IO;
using DevExpress.Utils.Zip;
using System.Globalization;
using DevExpress.XtraRichEdit;

namespace DevExpress.MailClient.Win {
    public class MyGridView : GridView {
        protected override bool IsAllowPixelScrollingPreview {
            get {
                return true;
            }
        }
    }
    public class GridHelper {
        public static void GetChildDataRowHandles(GridView view, int rowHandle, List<Message> list) {
            for(int i = 0; i < view.GetChildRowCount(rowHandle); i++) {
                int row = view.GetChildRowHandle(rowHandle, i);
                if(row >= 0)
                    list.Add(view.GetRow(row) as Message);
                else
                    GetChildDataRowHandles(view, row, list);
            }
        }
        public static void SetFindControlImages(GridControl grid) {
            FindControl fControl = null;
            foreach(Control ctrl in grid.Controls) {
                fControl = ctrl as FindControl;
                if(fControl != null) break;
            }
            if(fControl != null) {
                fControl.FindButton.Image = global::DevExpress.MailClient.Win.Properties.Resources.Search;
                fControl.ClearButton.Image = global::DevExpress.MailClient.Win.Properties.Resources.Delete_16x16;
                fControl.CalcButtonsBestFit();
            }
        }
        public static void GridViewFocusObject(ColumnView cView, object obj) {
            if(obj == null) return;
            int oldFocusedRowHandle = cView.FocusedRowHandle;
            for(int i = 0; i < cView.DataRowCount; ++i) {
                object rowObj = cView.GetRow(i) as object;
                if(rowObj == null) continue;
                if(ReferenceEquals(obj, rowObj)) {
                    if(i == oldFocusedRowHandle)
                        cView.FocusedRowHandle = GridControl.InvalidRowHandle;
                    cView.FocusedRowHandle = i;
                    break;
                }
            }
        }
    }
    public class ImageHelper {
        public static Bitmap GetScaleImage(Image image, Size size) {
            return new Bitmap(image, size.Width, size.Height);
        }
        public static string GetFaviconIconPath(string link) {
            link = ObjectHelper.GetCorrectUrl(link);
            string[] links = link.Split('/');
            if(links.Length > 1)
                return string.Format("http://{0}/favicon.ico", links[2]);
            return null;
        }
    }
    public class ColorHelper {
        public static void UpdateColor(ImageList list, UserLookAndFeel lf) {
            for(int i = 0; i < list.Images.Count; i++)
                list.Images[i] = SetColor(list.Images[i] as Bitmap, GetHeaderForeColor(lf));
        }
        public static Color GetHeaderForeColor(UserLookAndFeel lf) {
            Color ret = SystemColors.ControlText;
            if(lf.ActiveStyle != ActiveLookAndFeelStyle.Skin) return ret;
            return GridSkins.GetSkin(lf)[GridSkins.SkinHeader].Color.GetForeColor();
        }
        static Bitmap SetColor(Bitmap bmp, Color color) {
            for(int i = 0; i < bmp.Width; i++)
                for(int j = 0; j < bmp.Height; j++)
                    if(bmp.GetPixel(i, j).Name != "0")
                        bmp.SetPixel(i, j, color);
            return bmp;
        }
        public static string HtmlHyperLinkTextColor {
            get {
                Color color = EditorsSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HyperLinkTextColor");
                return GetRGBColor(color);
            }
        }
        public static string HtmlHighlightTextColor {
            get {
                Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HighlightText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlControlTextColor {
            get {
                Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("ControlText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlControlTextColor2 {
            get {
                Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlQuestionColor {
            get {
                Color color = CommonColors.GetQuestionColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
                return GetRGBColor(color);
            }
        }
        public static string HtmlWarningColor {
            get {
                Color color = CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
                return GetRGBColor(color);
            }
        }
        public static Color DisabledTextColor {
            get {
                return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("DisabledText");
            }
        }
        public static Color CriticalColor {
            get {
                return CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
            }
        }
        public static Color WarningColor {
            get {
                return CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
            }
        }
        static string GetRGBColor(Color color) {
            return string.Format("{0},{1},{2}", color.R, color.G, color.B);
        }
    }
    public class ObjectHelper {
        static RichEditDocumentServer rich = new RichEditDocumentServer();
        public static string GetPlainText(string htmlText) {
            rich.HtmlText = htmlText;
            return rich.Text.TrimStart();
        }
        public static void ShowWebSite(string url) {
            if(url == null) return;
            string processName = GetCorrectUrl(url);
            if(processName.Length == 0) return;
            StartProcess(processName);
        }
        public static string GetCorrectUrl(string url) {
            string ret = url.Replace(" ", string.Empty);
            if(ret.Length == 0) return string.Empty;
            const string protocol = "http://";
            const string protocol2 = "https://";
            if(ret.IndexOf(protocol) != 0 && ret.IndexOf(protocol2) != 0)
                ret = protocol + ret;
            return ret;
        }
        public static void StartProcess(string processName) {
            try {
                Process.Start(processName);
            } catch(Exception ex) {
                XtraMessageBox.Show(ex.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class NavBarHelper {
        public static void DeleteEmptyGroup(NavBarControl nb) {
            for(int i = nb.Groups.Count - 1; i >= 0; i--)
                if(nb.Groups[i].ItemLinks.Count == 0)
                    nb.Groups.RemoveAt(i);
        }
        public static NavBarItemLink GetFirstItem(NavBarControl nb) {
            foreach(NavBarGroup group in nb.Groups)
                foreach(NavBarItemLink link in group.ItemLinks)
                    return link;
            return null;
        }
        public static NavBarGroup GetGroupByName(string groupName, NavBarControl navBar) {
            NavBarGroup group = null;
            foreach(NavBarGroup fGroup in navBar.Groups)
                if(fGroup.Name.Equals(groupName))
                    group = fGroup;
            if(group == null) {
                group = new NavBarGroup(groupName) {Name = groupName};
                navBar.Groups.Add(group);
            }
            return group;
        }
        public static void SetNavBarItemImage(NavBarItem item, string link) {
            var pe = new PictureEdit();
            pe.LoadAsync(ImageHelper.GetFaviconIconPath(link));
            pe.Tag = item;
            pe.LoadCompleted += new EventHandler(pe_LoadCompleted);

        }
        static void pe_LoadCompleted(object sender, EventArgs e) {
            RepositoryItemPictureEdit pe = sender as RepositoryItemPictureEdit;
            NavBarItem item = pe.OwnerEdit.Tag as NavBarItem;
            item.SmallImage = ImageHelper.GetScaleImage(((PictureEdit)pe.OwnerEdit).Image, new Size(16, 16));
            pe.OwnerEdit.Dispose();
            pe.Dispose();
        }
        public static object[] GetGroupNames(NavBarControl navBar) {
            List<string> ret = new List<string>();
            foreach(NavBarGroup group in navBar.Groups) 
                ret.Add(group.Caption);
            return ret.ToArray();
        }
        public static List<string> GetItemNames(NavBarControl navBar) {
            List<string> ret = new List<string>();
            foreach(NavBarItem item in navBar.Items) 
                ret.Add(item.Caption);
            return ret;
        }

        public static string GetUniqueItemName(string name, NavBarControl navBar) {
            List<string> names = GetItemNames(navBar);
            for(int i = 1; i < 9999; i++) {
                string ret = string.Format("{0}{1}", name, i);
                if(!names.Contains(ret)) return ret;
            }
            return string.Empty;
            
        }
    }
    public class UniqueNameValidationRule : ValidationRule {
        List<string> values;
        public UniqueNameValidationRule(List<string> values) {
            this.values = values;
        }
        public override bool Validate(Control control, object value) {
            string str = (string)value;
            foreach(string val in values)
                if(!ValidationHelper.Validate(str, ConditionOperator.NotEquals, val, null, null, false))
                    return false;
            return true;
        }
    }
    public class ValidationRulesHelper {
        static ConditionValidationRule ruleIsNotBlank = null;
        public static ConditionValidationRule RuleIsNotBlank {
            get {
                if(ruleIsNotBlank == null) {
                    ruleIsNotBlank = new ConditionValidationRule();
                    ruleIsNotBlank.ConditionOperator = ConditionOperator.IsNotBlank;
                    ruleIsNotBlank.ErrorText = Properties.Resources.RuleIsNotBlankWarning;
                    ruleIsNotBlank.ErrorType = ErrorType.Critical;
                }
                return ruleIsNotBlank;
            }
        }
    }
    public class EditorHelper {
        public static RepositoryItemImageComboBox CreateTaskStatusImageComboBox(RepositoryItemImageComboBox edit) {
            Array arr = Enum.GetValues(typeof(TaskStatus));
            edit.Items.Clear();
            foreach(TaskStatus status in arr)
                edit.Items.Add(new ImageComboBoxItem(GetStringByTaskStatus(status), status, (int)status));
            return edit;
        }
        static string GetStringByTaskStatus(TaskStatus status) {
            switch(status) {
                case TaskStatus.Completed: return Properties.Resources.TaskStatusCompleted;
                case TaskStatus.Deferred: return Properties.Resources.TaskStatusDeferred;
                case TaskStatus.InProgress: return Properties.Resources.TaskStatusInProgress;
                case TaskStatus.WaitingOnSomeoneElse: return Properties.Resources.TaskStatusWaitingOnSomeoneElse;
            }
            return Properties.Resources.TaskStatusNotStarted;
        }
        public static RepositoryItemImageComboBox CreateTaskCategoryImageComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.TaskCategoryHouseChores, TaskCategory.HouseChores, 0));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.TaskCategoryShopping, TaskCategory.Shopping, 1));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.TaskCategoryOffice, TaskCategory.Office, 2));
            return edit;
        }
        public static RepositoryItemImageComboBox CreateFlagStatusImageComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.SmallImages = CreateFlagStatusImageCollection();
            edit.GlyphAlignment = HorzAlignment.Center;
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Today, FlagStatus.Today, (int)FlagStatus.Today));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Tomorrow, FlagStatus.Tomorrow, (int)FlagStatus.Tomorrow));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.ThisWeek, FlagStatus.ThisWeek, (int)FlagStatus.ThisWeek));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.NextWeek, FlagStatus.NextWeek, (int)FlagStatus.NextWeek));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.NoDate, FlagStatus.NoDate, (int)FlagStatus.NoDate));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Custom, FlagStatus.Custom, (int)FlagStatus.Custom));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Completed, FlagStatus.Completed, (int)FlagStatus.Completed));
            return edit;
        }
        public static void InitPriorityComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityLow, 0, 0),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityMedium, 1, -1),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityHigh, 2, 1)});
        }
        public static void InitPersonComboBox(RepositoryItemImageComboBox edit) {
            ImageCollection iCollection = new ImageCollection();
            iCollection.AddImage(Properties.Resources.Mr);
            iCollection.AddImage(Properties.Resources.Ms);
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Male, ContactGender.Male, 0));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Female, ContactGender.Female, 1));
            edit.SmallImages = iCollection;
        }
        public static void InitTitleComboBox(RepositoryItemImageComboBox edit) {
            ImageCollection iCollection = new ImageCollection();
            iCollection.AddImage(Properties.Resources.Doctor);
            iCollection.AddImage(Properties.Resources.Miss);
            iCollection.AddImage(Properties.Resources.Mr);
            iCollection.AddImage(Properties.Resources.Mrs);
            iCollection.AddImage(Properties.Resources.Ms);
            iCollection.AddImage(Properties.Resources.Professor);
            edit.Items.Add(new ImageComboBoxItem(string.Empty, ContactTitle.None, -1));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Dr), ContactTitle.Dr, 0));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Miss), ContactTitle.Miss, 1));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Mr), ContactTitle.Mr, 2));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Mrs), ContactTitle.Mrs, 3));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Ms), ContactTitle.Ms, 4));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(ContactTitle.Prof), ContactTitle.Prof, 5));
            edit.SmallImages = iCollection;
        }
        public static string GetTitleNameByContactTitle(ContactTitle title) {
            switch(title) {
                case ContactTitle.Dr: return Properties.Resources.ContactTitleDr;
                case ContactTitle.Miss: return Properties.Resources.ContactTitleMiss;
                case ContactTitle.Mr: return Properties.Resources.ContactTitleMr;
                case ContactTitle.Mrs: return Properties.Resources.ContactTitleMrs;
                case ContactTitle.Ms: return Properties.Resources.ContactTitleMs;
                case ContactTitle.Prof: return Properties.Resources.ContactTitleProf;
            }
            return string.Empty;
        }
        static ImageCollection CreateFlagStatusImageCollection() {
            ImageCollection ret = new ImageCollection();
            ret.AddImage(Properties.Resources.Today_Flag);
            ret.AddImage(Properties.Resources.Tomorrow_Flag);
            ret.AddImage(Properties.Resources.ThisWeek_Flag);
            ret.AddImage(Properties.Resources.NextWeek_Flag);
            ret.AddImage(Properties.Resources.NoDate_Flag);
            ret.AddImage(Properties.Resources.Custom_Flag);
            ret.AddImage(Properties.Resources.Completed_16x16);
            return ret;
        }

        internal static List<string> GetCities() {
            IEnumerable cities = (from contact in DataHelper.Contacts select contact.City).OrderBy(s => s).Distinct();
            return cities.Cast<string>().ToList();
        }
        internal static List<string> GetStates() {
            IEnumerable states = (from contact in DataHelper.Contacts select contact.State).OrderBy(s => s).Distinct();
            return states.Cast<string>().ToList();
        }
    }
    public class DictionaryHelper {
        public static void InitDictionary(SpellChecker spellChecker) {
            if(LocalizationHelper.IsJapanese) spellChecker.SpellCheckMode = SpellCheckMode.OnDemand;
            if(spellChecker.Dictionaries.Count > 0) return;
            spellChecker.Dictionaries.Add(GetDefaultDictionary());
        }
        static ISpellCheckerDictionary GetDefaultDictionary() {
            SpellCheckerISpellDictionary dic = new SpellCheckerISpellDictionary();
            Stream zipFileStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.MailClient.Win.Dictionaries.default.zip");
            InternalZipFileCollection files = InternalZipArchive.Open(zipFileStream);
            Stream alphabetStream = GetFileStream(files, "EnglishAlphabet.txt");
            Stream dictionaryStream = GetFileStream(files, "american.xlg");
            Stream grammarStream = GetFileStream(files, "english.aff");
            try {
                dic.LoadFromStream(dictionaryStream, grammarStream, alphabetStream);
            } catch {
            } finally {
                dictionaryStream.Dispose();
                grammarStream.Dispose();
                zipFileStream.Dispose();
                alphabetStream.Dispose();
                DisposeZipFileStreams(files);
            }
            dic.Culture = new CultureInfo("en-US");
            return dic;
        }
        static Stream GetFileStream(InternalZipFileCollection files, string name) {
            Stream stream = files.Find(delegate(InternalZipFile file) {
                return file.FileName.IndexOf(name) >= 0;
            }).FileDataStream;
            try {
                return CreateMemoryStream(stream);
            } finally {
                stream.Close();
            }
        }
        static Stream CreateMemoryStream(Stream stream) {
            MemoryStream result = new MemoryStream();
            for(; ; ) {
                int readedByte = stream.ReadByte();
                if(readedByte < 0)
                    break;
                result.WriteByte((byte)readedByte);
            }
            result.Flush();
            result.Seek(0, SeekOrigin.Begin);
            return result;
        }
        static void DisposeZipFileStreams(InternalZipFileCollection files) {
            foreach(InternalZipFile file in files)
                file.FileDataStream.Dispose();
        }
    }
}
