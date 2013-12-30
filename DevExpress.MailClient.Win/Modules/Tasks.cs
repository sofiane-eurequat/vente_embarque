using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraNavBar;
using System.Collections;
using DevExpress.Utils;
using DevExpress.MailClient.Win.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.MailClient.Win {
    public partial class Tasks : BaseModule {
        class NavBarData {
            Contact contact;
            object data;
            public NavBarData(object data, Contact contact) {
                this.contact = contact;
                this.data = data;
            }
            public Contact Contact { get { return contact; } }
            public object Data { get { return data; } }
        }
        Dictionary<object, object> tasks = new Dictionary<object, object>();
        ContactToolTipController tooltip;
        Object currentKey = null;
        public override string ModuleName { get { return Properties.Resources.TasksName; } }
        public Tasks() {
            InitializeComponent();
        }
        internal override void InitModule(DevExpress.Utils.Menu.IDXMenuManager manager, object data) {
            base.InitModule(manager, data);
            EditorHelper.CreateTaskStatusImageComboBox(repositoryItemImageComboBox3);
            EditorHelper.CreateTaskCategoryImageComboBox(repositoryItemImageComboBox4);
            EditorHelper.CreateFlagStatusImageComboBox(repositoryItemImageComboBox5);
            EditorHelper.InitPriorityComboBox(repositoryItemImageComboBox1);
            NavBarGroup group = data as NavBarGroup;
            CreateNavBarItems(group);
            tooltip = new ContactToolTipController(group.NavBar);
            group.NavBar.MouseMove += new MouseEventHandler(NavBar_MouseMove);
        }

        void NavBar_MouseMove(object sender, MouseEventArgs e) {
            NavBarControl navBar = sender as NavBarControl;
            NavBarHitInfo info = navBar.CalcHitInfo(e.Location);
            if(info.InLink)
                tooltip.ShowHint(((NavBarData)info.Link.Item.Tag).Contact, e.Location);
            else
                tooltip.HideHint(true);
        }
        void CreateNavBarItems(NavBarGroup group) {
            group.NavBar.AllowSelectedLink = true;
            NavBarItemLink link = AddNavBarItem(group, Properties.Resources.OwnerName, global::DevExpress.MailClient.Win.Properties.Resources.Owner, GetTasksData(null), null);
            link.Item.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Underline);
            foreach(Contact contact in TaskGenerator.Customers)
                AddNavBarItem(group, contact.Name, contact.Icon, GetTasksData(contact), contact);
            //link = AddNavBarItem(group, "All tasks", null, DataHelper.Tasks, null);
            group.SelectedLink = link;
            ShowData(group.SelectedLink.Item);
        }
        object GetTasksData(Contact contact) {
            IEnumerable ret = from task in DataHelper.Tasks
                   where task.AssignTo == contact
                   select task;
            return ret.Cast<Task>().ToList();
        }
        NavBarItemLink AddNavBarItem(NavBarGroup group, string caption, Image image, object data, Contact contact) {
            NavBarItem item = new NavBarItem(caption);
            item.SmallImage = image;
            item.Tag = new NavBarData(data, contact);
            tasks.Add(item.Tag, data);
            NavBarItemLink link = group.ItemLinks.Add(item);
            item.LinkClicked += new NavBarLinkEventHandler(item_LinkClicked);
            return link;
        }
        void item_LinkClicked(object sender, NavBarLinkEventArgs e) {
            ShowData(e.Link.Item);
        }
        void ShowData(NavBarItem item) {
            currentKey = item.Tag;
            partName = item.Caption;
            gridControl1.DataSource = ((NavBarData)item.Tag).Data;
            ShowInfo(gridView1);
        }
        protected override DevExpress.XtraGrid.GridControl Grid { get { return gridControl1; } }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            if(firstShow) {
                gridControl1.ForceInitialize();
                GridHelper.SetFindControlImages(gridControl1);
                GalleryItem item = OwnerForm.TaskGallery.Groups[0].Items[0];
                item.Checked = true;
                ButtonClick(string.Format("{0}", item.Tag));
            }
        }
        protected override void LookAndFeelStyleChanged() {
            base.LookAndFeelStyleChanged();
            ColorHelper.UpdateColor(ilColumns, gridControl1.LookAndFeel);
        }
        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e) {
            if(e.Column.ColumnType == typeof(DateTime?)) {
                DateTime? value = e.Value as DateTime?;
                if(value == null || !value.HasValue)
                    e.DisplayText = Properties.Resources.None;
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            if(e.Column == colComplete) {
                Task task = gridView1.GetRow(e.RowHandle) as Task;
                if(task != null) {
                    task.Complete = !task.Complete;
                    gridView1.CloseEditor();
                    gridView1.UpdateCurrentRow();
                }
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
            if(e.Column == colPercent)
                e.RepositoryItem = repositoryItemTrackBar1;
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.RowHandle < 0) return;
            Task currentTask = gridView1.GetRow(e.RowHandle) as Task;
            if(currentTask == null) return;
            if(currentTask.Status == TaskStatus.Completed) {
                e.Appearance.Font = FontResources.StrikeoutFont;
                e.Appearance.ForeColor = ColorHelper.DisabledTextColor;
            }
            if(currentTask.Status == TaskStatus.Deferred) 
                e.Appearance.ForeColor = ColorHelper.DisabledTextColor;
            if(currentTask.Status == TaskStatus.WaitingOnSomeoneElse)
                e.Appearance.ForeColor = ColorHelper.WarningColor;
            if(currentTask.Priority == 2 && currentTask.Status != TaskStatus.Completed) 
                e.Appearance.Font = FontResources.BoldFont;
            if(currentTask.Overdue)
                e.Appearance.ForeColor = ColorHelper.CriticalColor; 
        }
        protected internal override void ButtonClick(string tag) {
            if(tag.IndexOf("Task") == 0) {
                gridView1.BeginUpdate();
                try {
                    LoadDefaultLayout();
                    switch(tag) {
                        case TagResources.TaskList:
                            colCreated.Group();
                            colCreated.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                            break;
                        case TagResources.TaskToDoList:
                            gridView1.ActiveFilterString = "[Status] <> ##Enum#DevExpress.MailClient.Win.TaskStatus,Completed# And [DueDate] Is Not Null";
                            colDueDate.Group();
                            colCompleted.Visible = false;
                            break;
                        case TagResources.TaskCompleted:
                            gridView1.ActiveFilterString = "[Status] = ##Enum#DevExpress.MailClient.Win.TaskStatus,Completed#";
                            colCompleted.Group();
                            colCompleted.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                            break;
                        case TagResources.TaskToday:
                            gridView1.ActiveFilterString = "IsOutlookIntervalToday([DueDate])";
                            colPriority.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                            colCompleted.Visible = false;
                            break;
                        case TagResources.TaskPrioritized:
                            colPriority.Group();
                            colCategory.Group();
                            colDueDate.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                            colCreated.Visible = false;
                            break;
                        case TagResources.TaskOverdue:
                            gridView1.ActiveFilterString = "[Overdue] = True";
                            colDueDate.Group();
                            colCreated.Visible = false;
                            colCompleted.Visible = false;
                            break;
                        case TagResources.TaskSimpleList:
                            colDueDate.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                            colPriority.Visible = false;
                            colCategory.Visible = false;
                            colStatus.Visible = false;
                            colPercent.Visible = false;
                            colStartDate.Visible = false;
                            colCompleted.Visible = false;
                            break;
                        case TagResources.TaskDeferred:
                            gridView1.ActiveFilterString = "[Status] = ##Enum#DevExpress.MailClient.Win.TaskStatus,Deferred# Or [Status] = ##Enum#DevExpress.MailClient.Win.TaskStatus,WaitingOnSomeoneElse#";
                            colCompleted.Group();
                            colCreated.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                            colCompleted.Visible = false;
                            break;
                    }
                } finally {
                    gridView1.FocusedRowHandle = 0;
                    gridView1.MakeRowVisible(gridView1.FocusedRowHandle);
                    gridView1.EndUpdate();
                }
            } else {
                DoFlagStatusButtonClick(tag);
                DoEditTaskButtonClick(tag);
            }
        }
        NavBarData CurrentKey { get { return currentKey as NavBarData; } }
        void DoEditTaskButtonClick(string tag) {
            switch(tag) {
                case TagResources.TaskDelete:
                    if(CurrentTask == null) return;
                    int index = gridView1.FocusedRowHandle;
                    gridView1.BeginDataUpdate();
                    try {
                        foreach(List<Task> list in tasks.Values) 
                            list.Remove(CurrentTask);
                    } finally {
                        gridView1.EndDataUpdate();
                    }
                    if(index > gridView1.DataRowCount - 1) index--;
                    gridView1.FocusedRowHandle = index;
                    ShowInfo(gridView1);
                    break;
                case TagResources.TaskNew:
                    if(CurrentKey != null) {
                        Task task = new Task(Properties.Resources.NewTaskName, TaskCategory.Office);
                        task.AssignTo = CurrentKey.Contact;
                        if(EditTask(task) == DialogResult.OK) {
                            gridControl1.MainView.BeginDataUpdate();
                            try {
                                ((List<Task>)tasks[CurrentKey]).Add(task);
                            } finally {
                                gridControl1.MainView.EndDataUpdate();
                            }
                            ColumnView view = gridControl1.MainView as ColumnView;
                            if(view != null) {
                                GridHelper.GridViewFocusObject(view, task);
                                ShowInfo(view);
                            }
                        }
                    }
                    break;
                case TagResources.TaskEdit:
                    EditTask(CurrentTask);
                    break;
            }
        }
        DialogResult EditTask(Task task) {
            if(task == null) return DialogResult.Ignore;
            DialogResult ret = DialogResult.Cancel;
            Cursor.Current = Cursors.WaitCursor;
            using(frmEditTask frm = new frmEditTask(task, OwnerForm.Ribbon)) {
                ret = frm.ShowDialog(OwnerForm);
            }
            UpdateCurrentTask();
            Cursor.Current = Cursors.Default;
            return ret;
        }
        void DoFlagStatusButtonClick(string tag) {
            if(CurrentTask == null) return;
            if(!Enum.IsDefined(typeof(FlagStatus), tag)) return;
            int day = -1;
            if(tag.Equals(FlagStatus.Today.ToString())) CurrentTask.DueDate = DateTime.Today;
            if(tag.Equals(FlagStatus.Tomorrow.ToString())) CurrentTask.DueDate = DateTime.Today.AddDays(1);
            if(tag.Equals(FlagStatus.ThisWeek.ToString())) {
                if(CurrentTask.FlagStatus != FlagStatus.ThisWeek) day = 5;
            }
            if(tag.Equals(FlagStatus.NextWeek.ToString())) {
                if(CurrentTask.FlagStatus != FlagStatus.NextWeek) day = 12;
            }
            if(day > 0)
                CurrentTask.DueDate = DevExpress.Data.Filtering.Helpers.EvalHelpers.GetWeekStart(DateTime.Today).AddDays(day);
            if(tag.Equals(FlagStatus.NoDate.ToString())) CurrentTask.DueDate = null;
            if(tag.Equals(FlagStatus.Custom.ToString())) {
                using(frmCustomDate frm = new frmCustomDate(CurrentTask)) 
                    frm.ShowDialog(OwnerForm);
            }
            CurrentTask.Complete = false;
            gridView1.LayoutChanged();
            OwnerForm.EnabledFlagButtons(true, CurrentTask.FlagStatus);
        }

        void LoadDefaultLayout() {
            gridView1.ClearGrouping();
            gridView1.ClearSorting();
            gridView1.ActiveFilterString = string.Empty;
            for(int i = 0; i < gridView1.Columns.Count; i++)
                if(gridView1.Columns[i] != colOverdue)
                    gridView1.Columns[i].VisibleIndex = i;
        }
        Task CurrentTask {
            get {
                if(gridView1.FocusedRowHandle < 0) return null;
                return gridView1.GetRow(gridView1.FocusedRowHandle) as Task;
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            UpdateCurrentTask();
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e) {
            UpdateCurrentTask();
        }

        void UpdateCurrentTask() {
            if(CurrentTask != null) 
                OwnerForm.EnabledFlagButtons(true, CurrentTask.FlagStatus);
            else OwnerForm.EnabledFlagButtons(false, FlagStatus.Completed);
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e) {
            if(CurrentTask == null) return;
            if(e.Column == colFlagStatus) {
                if(e.Button == MouseButtons.Left)
                    CurrentTask.Complete = !CurrentTask.Complete;
                if(e.Button == MouseButtons.Right) OwnerForm.FlagStatusMenu.ShowPopup(gridControl1.PointToScreen(e.Location));
                gridView1.LayoutChanged();
            }
            if(e.Button == MouseButtons.Left && e.RowHandle >= 0 && e.Clicks == 2) {
                EditTask(CurrentTask);
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Enter && gridView1.FocusedRowHandle >=0)
                EditTask(CurrentTask);
        }
    }
}
