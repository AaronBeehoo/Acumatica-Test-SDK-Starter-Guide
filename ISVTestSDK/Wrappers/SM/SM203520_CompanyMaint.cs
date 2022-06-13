using Api;
using Controls.Alert;
using Controls.Button;
using Controls.CheckBox;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.DropDown;
using Controls.Editors.Selector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.GroupBox;
using Controls.Input;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Controls.Uploader;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using Core.Wait;
using System;


namespace ISVTestSDK.Extensions
{
    
    
    public class SM203520_CompanyMaint : Wrapper
    {
        
        public PxToolBar ToolBar;
        
        protected c_companies_form Companies_form { get; } = new c_companies_form("ctl00_phF_form", "Companies_form");
        protected c_parameters_gridwizard Parameters_gridWizard { get; } = new c_parameters_gridwizard("ctl00_usrCaption_shareColumnsDlg_gridWizard", "Parameters_gridWizard");
        protected c_profilerinfoview_formprofiler ProfilerInfoView_formProfiler { get; } = new c_profilerinfoview_formprofiler("ctl00_usrCaption_pnlProfiler_formProfiler", "ProfilerInfoView_formProfiler");
        protected c_firstselect_formactions FirstSelect_FormActions { get; } = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions");
        protected c_comboboxvalues_gridcombos ComboBoxValues_gridCombos { get; } = new c_comboboxvalues_gridcombos("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos", "ComboBoxValues_gridCombos");
        protected c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo { get; } = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo");
        protected c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject { get; } = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject");
        protected c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject { get; } = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject");
        protected c_gridlist_gridgrid GridList_gridGrid { get; } = new c_gridlist_gridgrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid", "GridList_gridGrid");
        protected c_userlist_usergrid UserList_userGrid { get; } = new c_userlist_usergrid("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid", "UserList_userGrid");
        protected c_userlist_lv0 UserList_lv0 { get; } = new c_userlist_lv0("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0", "UserList_lv0");
        protected c_companycurrent_tab CompanyCurrent_tab { get; } = new c_companycurrent_tab("ctl00_phG_tab", "CompanyCurrent_tab");
        protected c_snapshots_gridsnapshots Snapshots_gridSnapshots { get; } = new c_snapshots_gridsnapshots("ctl00_phG_tab_t0_gridSnapshots", "Snapshots_gridSnapshots");
        protected c_snapshots_lv0 Snapshots_lv0 { get; } = new c_snapshots_lv0("ctl00_phG_tab_t0_gridSnapshots_lv0", "Snapshots_lv0");
        protected c_snapshotshistory_gridhistory SnapshotsHistory_gridHistory { get; } = new c_snapshotshistory_gridhistory("ctl00_phG_tab_t1_gridHistory", "SnapshotsHistory_gridHistory");
        protected c_snapshotshistory_lv0 SnapshotsHistory_lv0 { get; } = new c_snapshotshistory_lv0("ctl00_phG_tab_t1_gridHistory_lv0", "SnapshotsHistory_lv0");
        protected c_users_gridusers Users_gridUsers { get; } = new c_users_gridusers("ctl00_phG_tab_t2_gridUsers", "Users_gridUsers");
        protected c_users_lv0 Users_lv0 { get; } = new c_users_lv0("ctl00_phG_tab_t2_gridUsers_lv0", "Users_lv0");
        protected c_copycompanypanel_frmcopycompany CopyCompanyPanel_frmCopyCompany { get; } = new c_copycompanypanel_frmcopycompany("ctl00_phF_pnlCopyCompany_frmCopyCompany", "CopyCompanyPanel_frmCopyCompany");
        protected c_exportsnapshotpanel_frmexportsnapshot ExportSnapshotPanel_frmExportSnapshot { get; } = new c_exportsnapshotpanel_frmexportsnapshot("ctl00_phF_pnlExportSnapshot_frmExportSnapshot", "ExportSnapshotPanel_frmExportSnapshot");
        protected c_reloadsnapshotpanel_frmreloadsnapshot ReloadSnapshotPanel_frmReloadSnapshot { get; } = new c_reloadsnapshotpanel_frmreloadsnapshot("ctl00_phF_pnlReloadSnapshot_frmReloadSnapshot", "ReloadSnapshotPanel_frmReloadSnapshot");
        protected c_importsnapshotpanel_ftmimportsnapshot ImportSnapshotPanel_ftmImportSnapshot { get; } = new c_importsnapshotpanel_ftmimportsnapshot("ctl00_phF_pnlImportSnapshot_ftmImportSnapshot", "ImportSnapshotPanel_ftmImportSnapshot");
        protected c_filterpreview_formpreview FilterPreview_FormPreview { get; } = new c_filterpreview_formpreview("ctl00_usrCaption_PanelDynamicForm_FormPreview", "FilterPreview_FormPreview");
        protected c_screen_upload UploadSnapshotPackage { get; } = new c_screen_upload("ctl00_phF_dlgUploadFile", "UploadSnapshotPackage");
        
        public SM203520_CompanyMaint()
        {
            ScreenId = "SM203520";
            ScreenUrl = "/Pages/SM/SM203520.aspx";
            ToolBar = new PxToolBar(null);
        }
        
        public virtual SM203520_CompanyMaint ReadOne(Gate gate, string CompanyID)
        {
            new BiObject<SM203520_CompanyMaint>(gate).ReadOne(this, CompanyID);
            return this;
        }
        
        public virtual SM203520_CompanyMaint ReadOne(string CompanyID)
        {
            return this.ReadOne(ApiConnection.Source, CompanyID);
        }
        
        public virtual void SyncTOC()
        {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Custom()
        {
            ToolBar.Custom.Click();
        }
        
        public virtual void ActionSelectWorkingProject()
        {
            ToolBar.ActionSelectWorkingProject.Click();
        }
        
        public virtual void InspectElementCtrlAltClick()
        {
            ToolBar.InspectElementCtrlAltClick.Click();
        }
        
        public virtual void MenuEditProj()
        {
            ToolBar.MenuEditProj.Click();
        }
        
        public virtual void ManageCustomizations()
        {
            ToolBar.ManageCustomizations.Click();
        }
        
        public virtual void KeyBtnRefresh()
        {
            ToolBar.KeyBtnRefresh.Click();
        }
        
        public virtual void Help()
        {
            ToolBar.Help.Click();
        }
        
        public virtual void MenuOpener()
        {
            ToolBar.MenuOpener.Click();
        }
        
        public virtual void SaveCompanyCommand()
        {
            ToolBar.SaveCompanyCommand.Click();
        }
        
        public virtual void Cancel()
        {
            ToolBar.Cancel.Click();
        }
        
        public virtual void InsertCompanyCommand()
        {
            ToolBar.InsertCompanyCommand.Click();
        }
        
        public virtual void DeleteCompanyCommand()
        {
            ToolBar.DeleteCompanyCommand.Click();
        }
        
        public virtual void DeleteCompanyCommand(bool status, string message = null)
        {
            ToolBar.DeleteCompanyCommand.WaitActionOverride = () => Wait.WaitForLongOperationToComplete(status, message);
            ToolBar.DeleteCompanyCommand.Click();
        }
        
        public virtual void Previous()
        {
            ToolBar.Previous.Click();
        }
        
        public virtual void Next()
        {
            ToolBar.Next.Click();
        }
        
        public virtual void CopyCompanyCommand()
        {
            ToolBar.CopyCompanyCommand.Click();
        }
        
        public virtual void ExportSnapshotCommand()
        {
            ToolBar.ExportSnapshotCommand.Click();
        }
        
        public virtual void ReloadSnapshotCommand()
        {
            ToolBar.ReloadSnapshotCommand.Click();
        }
        
        public virtual void PrepareXmlSnapshotCommand()
        {
            ToolBar.PrepareXmlSnapshotCommand.Click();
        }
        
        public virtual void PrepareAdbSnapshotCommand()
        {
            ToolBar.PrepareAdbSnapshotCommand.Click();
        }
        
        public virtual void ImportSnapshotCommand()
        {
            ToolBar.ImportSnapshotCommand.Click();
        }
        
        public virtual void TrialCompanyCommand()
        {
            ToolBar.TrialCompanyCommand.Click();
        }
        
        public virtual void DeleteOrphanedRows()
        {
            ToolBar.DeleteOrphanedRows.Click();
        }
        
        public virtual void DismissedUnsafeSnapshotCommand()
        {
            ToolBar.DismissedUnsafeSnapshotCommand.Click();
        }
        
        public virtual void SpaceUsageCommand()
        {
            ToolBar.SpaceUsageCommand.Click();
        }
        
        public virtual void LongRun()
        {
            ToolBar.LongRun.Click();
        }
        
        public virtual void LongrunCancel()
        {
            ToolBar.LongrunCancel.Click();
        }
        
        public virtual void LongrunTimer()
        {
            ToolBar.LongrunTimer.Click();
        }
        
        public class PxToolBar : PxControlCollection
        {
            
			public ToolBarButton SyncTOC { get; }
			public ToolBarButton Custom { get; }
			public ToolBarButton ActionSelectWorkingProject { get; }
			public ToolBarButton InspectElementCtrlAltClick { get; }
			public ToolBarButton MenuEditProj { get; }
			public ToolBarButton ManageCustomizations { get; }
			public ToolBarButton KeyBtnRefresh { get; }
			public ToolBarButton Help { get; }
			public ToolBarButton MenuOpener { get; }
			public ToolBarButton SaveCompanyCommand { get; }
			public ToolBarButton Cancel { get; }
			public ToolBarButton InsertCompanyCommand { get; }
			public ToolBarButton DeleteCompanyCommand { get; }
			public ToolBarButton Previous { get; }
			public ToolBarButton Next { get; }
			public ToolBarButton CopyCompanyCommand { get; }
			public ToolBarButton ExportSnapshotCommand { get; }
			public ToolBarButton ReloadSnapshotCommand { get; }
			public ToolBarButton PrepareXmlSnapshotCommand { get; }
			public ToolBarButton PrepareAdbSnapshotCommand { get; }
			public ToolBarButton ImportSnapshotCommand { get; }
			public ToolBarButton TrialCompanyCommand { get; }
			public ToolBarButton DeleteOrphanedRows { get; }
			public ToolBarButton DismissedUnsafeSnapshotCommand { get; }
			public ToolBarButton SpaceUsageCommand { get; }
			public ToolBarButton LongRun { get; }
			public ToolBarButton LongrunCancel { get; }
			public ToolBarButton LongrunTimer { get; }
            
            public PxToolBar(string locator)
            {
                SyncTOC = new ToolBarButton("css=#ctl00_usrCaption_tlbPath div[data-cmd=\'syncTOC\']", "Sync Navigation Pane", locator, null);
                Custom = new ToolBarButton("css=#ctl00_usrCaption_CustomizationDialogs_PXToolBar1 div[data-cmd=\'Custom\']", "Customization", locator, null);
                ActionSelectWorkingProject = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "ActionSelectWorkingProject\']", "Select Project...", locator, Custom);
                InspectElementCtrlAltClick = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Inspect Element (Ctrl+Alt+Click)\")", "Inspect Element (Ctrl+Alt+Click)", locator, Custom);
                MenuEditProj = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd=\'" +
                        "menuEditProj\']", "Edit Project...", locator, Custom);
                ManageCustomizations = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem d" +
                        "iv:textEqual(\"Manage Customizations...\")", "Manage Customizations...", locator, Custom);
                KeyBtnRefresh = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'keyBtnRefresh\']", "Click to refresh page.", locator, null);
                Help = new ToolBarButton("css=#ctl00_usrCaption_tlbTools div[data-cmd=\'help\']", "View Tools", locator, null);
                MenuOpener = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_MenuOpener", "Menu", locator, null);
                SaveCompanyCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_saveCompanyCommand", "Save (Ctrl+S).", locator, null);
                Cancel = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Cancel", "Cancel (Esc)", locator, null);
                Cancel.ConfirmAction = () => Alert.AlertToException("Any unsaved changes will be discarded.");
                InsertCompanyCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_insertCompanyCommand", "Add New Record (Ctrl+Ins)", locator, null);
                DeleteCompanyCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_deleteCompanyCommand", "Delete (Ctrl+Del).", locator, null);
                DeleteCompanyCommand.WaitAction = Wait.WaitForLongOperationToComplete;
                DeleteCompanyCommand.ConfirmAction = () => Alert.AlertToException("WARNING: This action will completely delete all data in the selected tenant. Are you sure you want to continue?");
                Previous = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Previous", "Go to Previous Record (PgUp)", locator, null);
                Next = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_Next", "Go to Next Record (PgDn)", locator, null);
                CopyCompanyCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_copyCompanyCommand,#ctl00_phDS_ds_ToolBar_copyCompanyC" +
                        "ommand_item", "Copy the current tenant into another tenant.", locator, MenuOpener);
                ExportSnapshotCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_exportSnapshotCommand", "Create a snapshot of the current tenant.", locator, null);
                ReloadSnapshotCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_reloadSnapshotCommand,#ctl00_phDS_ds_ToolBar_reloadSna" +
                        "pshotCommand_item", "Reset the data of the current tenant.", locator, MenuOpener);
                PrepareXmlSnapshotCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_prepareXmlSnapshotCommand,#ctl00_phDS_ds_ToolBar_prepa" +
                        "reXmlSnapshotCommand_item", "Prepare the selected snapshot for export.", locator, MenuOpener);
                PrepareAdbSnapshotCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_prepareAdbSnapshotCommand,#ctl00_phDS_ds_ToolBar_prepa" +
                        "reAdbSnapshotCommand_item", "Prepare the selected snapshot for export.", locator, MenuOpener);
                ImportSnapshotCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_importSnapshotCommand", "Restore the selected snapshot to the current tenant.", locator, null);
                TrialCompanyCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_trialCompanyCommand,#ctl00_phDS_ds_ToolBar_trialCompan" +
                        "yCommand_item", "Change to the test tenant.", locator, MenuOpener);
                DeleteOrphanedRows = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_deleteOrphanedRows,#ctl00_phDS_ds_ToolBar_deleteOrphan" +
                        "edRows_item", "Validate the database and delete orphaned records.", locator, MenuOpener);
                DismissedUnsafeSnapshotCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_dismissedUnsafeSnapshotCommand,#ctl00_phDS_ds_ToolBar_" +
                        "dismissedUnsafeSnapshotCommand_item", "Hide the warning about the unsafe snapshot in the Help > About window.", locator, MenuOpener);
                SpaceUsageCommand = new ToolBarButton("css=#ctl00_phDS_ds_ToolBar_spaceUsageCommand,#ctl00_phDS_ds_ToolBar_spaceUsageCom" +
                        "mand_item", "View Space Usage", locator, MenuOpener);
                LongRun = new ToolBarButton("css=qp-long-run", "Nothing in progress", locator, null);
                LongrunCancel = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_cancel", "Cancel", locator, null);
                LongrunTimer = new ToolBarButton("css=#ctl00_phDS_ds_LongRun_timer", "Elapsed Time", locator, null);
            }
        }
        
        public class c_companies_form : Container
        {
            
			public Selector CompanyID { get; }
			public Label CompanyIDLabel { get; }
			public PXTextEdit CompanyCD { get; }
			public Label CompanyCDLabel { get; }
			public PXTextEdit LoginName { get; }
			public Label LoginNameLabel { get; }
			public PXTextEdit CloudTenantID { get; }
			public Label CloudTenantIDLabel { get; }
			public DropDown Status { get; }
			public Label StatusLabel { get; }
            
            public c_companies_form(string locator, string name) : 
                    base(locator, name)
            {
                CompanyID = new Selector("ctl00_phF_form_edCompanyID", "Tenant ID", locator, null);
                CompanyIDLabel = new Label(CompanyID);
                CompanyID.DataField = "CompanyID";
                CompanyCD = new PXTextEdit("ctl00_phF_form_edCompanyCD", "Tenant Name", locator, null);
                CompanyCDLabel = new Label(CompanyCD);
                CompanyCD.DataField = "CompanyCD";
                LoginName = new PXTextEdit("ctl00_phF_form_edLoginName", "Login Name", locator, null);
                LoginNameLabel = new Label(LoginName);
                LoginName.DataField = "LoginName";
                CloudTenantID = new PXTextEdit("ctl00_phF_form_edCloudTenantID", "Cloud Tenant ID", locator, null);
                CloudTenantIDLabel = new Label(CloudTenantID);
                CloudTenantID.DataField = "CloudTenantID";
                Status = new DropDown("ctl00_phF_form_ddStatus", "Status", locator, null);
                StatusLabel = new Label(Status);
                Status.DataField = "Status";
                Status.Items.Add("Active", "Active");
                Status.Items.Add("Trial", "Test Tenant");
                Status.Items.Add("Unlicensed", "Unlicensed");
                DataMemberName = "Companies";
            }
        }
        
        public class c_parameters_gridwizard : Container
        {
            
            public PxButtonCollection Buttons;
            
			public CheckBox IsDefault { get; }
			public Label IsDefaultLabel { get; }
			public CheckBox Override { get; }
			public Label OverrideLabel { get; }
			public Selector RoleName { get; }
			public Label RoleNameLabel { get; }
            
            public c_parameters_gridwizard(string locator, string name) : 
                    base(locator, name)
            {
                IsDefault = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_defaultCkbx", "Is Default", locator, null);
                IsDefaultLabel = new Label(IsDefault);
                IsDefault.DataField = "IsDefault";
                Override = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_overrideCkbx", "Override", locator, null);
                OverrideLabel = new Label(Override);
                Override.DataField = "Override";
                RoleName = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_edRole", "Role Name", locator, null);
                RoleNameLabel = new Label(RoleName);
                RoleName.DataField = "RoleName";
                DataMemberName = "Parameters";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void Prev()
            {
                Buttons.Prev.Click();
            }
            
            public virtual void Next()
            {
                Buttons.Next.Click();
            }
            
            public virtual void Finish()
            {
                Buttons.Finish.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Cancel { get; }
			public Button Prev { get; }
			public Button Next { get; }
			public Button Finish { get; }
                
                public PxButtonCollection()
                {
                    Cancel = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_cancel", "Cancel", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Prev = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_prev", "Prev", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Next = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_next", "Next", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                    Finish = new Button("ctl00_usrCaption_shareColumnsDlg_gridWizard_save", "Finish", "ctl00_usrCaption_shareColumnsDlg_gridWizard");
                }
            }
        }
        
        public class c_profilerinfoview_formprofiler : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit StartText { get; }
			public Label StartTextLabel { get; }
			public PXTextEdit Started { get; }
			public Label StartedLabel { get; }
			public PXTextEdit RequestsLogged { get; }
			public Label RequestsLoggedLabel { get; }
			public Label LblPlace_ { get; }
            
            public c_profilerinfoview_formprofiler(string locator, string name) : 
                    base(locator, name)
            {
                StartText = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblStartText", "Start Text", locator, null);
                StartTextLabel = new Label(StartText);
                StartText.DataField = "StartText";
                Started = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblStartedAt", "Started", locator, null);
                StartedLabel = new Label(Started);
                Started.DataField = "Started";
                RequestsLogged = new PXTextEdit("ctl00_usrCaption_pnlProfiler_formProfiler_lblRequestsLogged", "Requests Logged", locator, null);
                RequestsLoggedLabel = new Label(RequestsLogged);
                RequestsLogged.DataField = "RequestsLogged";
                LblPlace_ = new Label("ctl00_usrCaption_pnlProfiler_formProfiler_lblPlace", "Lbl Place _", locator, null);
                DataMemberName = "ProfilerInfoView";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void BtnStartProfiler()
            {
                Buttons.BtnStartProfiler.Click();
            }
            
            public virtual void BtnStopProfiler()
            {
                Buttons.BtnStopProfiler.Click();
            }
            
            public virtual void BtnMainProfiler()
            {
                Buttons.BtnMainProfiler.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button BtnStartProfiler { get; }
			public Button BtnStopProfiler { get; }
			public Button BtnMainProfiler { get; }
                
                public PxButtonCollection()
                {
                    BtnStartProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStartProfiler", "btnStartProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnStopProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnStopProfiler", "btnStopProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                    BtnMainProfiler = new Button("ctl00_usrCaption_pnlProfiler_formProfiler_btnMainProfiler", "btnMainProfiler", "ctl00_usrCaption_pnlProfiler_formProfiler");
                }
            }
        }
        
        public class c_firstselect_formactions : Container
        {
            
			public PXTextEdit Key { get; }
			public Label KeyLabel { get; }
            
            public c_firstselect_formactions(string locator, string name) : 
                    base(locator, name)
            {
                Key = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions_edKey", "Key", locator, null);
                KeyLabel = new Label(Key);
                Key.DataField = "Key";
                DataMemberName = "FirstSelect";
            }
        }
        
        public class c_comboboxvalues_gridcombos : Grid<c_comboboxvalues_gridcombos.c_grid_row, c_comboboxvalues_gridcombos.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
            public PxButtonCollection Buttons;
            
			public c_grid_filter FilterForm { get; }
            
            public c_comboboxvalues_gridcombos(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos");
                DataMemberName = "ComboBoxValues";
                Buttons = new PxButtonCollection();
                FilterForm = new c_grid_filter("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_fe_gf", "FilterForm");
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void Close()
            {
                Buttons.Close.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ab" +
                            "_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Close { get; }
                
                public PxButtonCollection()
                {
                    Close = new Button("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_PXButton5", "Close", "ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos");
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit Value { get; }
			public PXTextEdit Description { get; }
                
                public c_grid_row(c_comboboxvalues_gridcombos grid) : 
                        base(grid)
                {
                    Value = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ei", "Value", grid.Locator, "Value");
                    Value.DataField = "Value";
                    Description = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_ComboBoxValuesDictDialog_gridCombos_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter Value { get; }
				public PXTextEditColumnFilter Description { get; }
                
                public c_grid_header(c_comboboxvalues_gridcombos grid) : 
                        base(grid)
                {
                    Value = new PXTextEditColumnFilter(grid.Row.Value);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                }
            }
        }
        
        public class c_vieweleminfo_formeleminfo : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AspxControl { get; }
			public Label AspxControlLabel { get; }
			public GroupBox IsComboBox { get; }
			public Label IsComboBoxLabel { get; }
			public PXTextEdit CacheType { get; }
			public Label CacheTypeLabel { get; }
			public PXTextEdit FieldName { get; }
			public Label FieldNameLabel { get; }
			public PXTextEdit ViewName { get; }
			public Label ViewNameLabel { get; }
			public PXTextEdit GraphName { get; }
			public Label GraphNameLabel { get; }
			public PXTextEdit ActionName { get; }
			public Label ActionNameLabel { get; }
            
            public c_vieweleminfo_formeleminfo(string locator, string name) : 
                    base(locator, name)
            {
                AspxControl = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_edAspxControl", "Control Type", locator, null);
                AspxControlLabel = new Label(AspxControl);
                AspxControl.DataField = "AspxControl";
                IsComboBox = new GroupBox("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_panelPXBUtton1", "Is Combo Box", locator, null);
                IsComboBoxLabel = new Label(IsComboBox);
                IsComboBox.DataField = "IsComboBox";
                CacheType = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_CacheType", "Data Class", locator, null);
                CacheTypeLabel = new Label(CacheType);
                CacheType.DataField = "CacheType";
                FieldName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_FieldName", "Data Field", locator, null);
                FieldNameLabel = new Label(FieldName);
                FieldName.DataField = "FieldName";
                ViewName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ViewName", "View Name", locator, null);
                ViewNameLabel = new Label(ViewName);
                ViewName.DataField = "ViewName";
                GraphName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_GraphName", "Business Logic", locator, null);
                GraphNameLabel = new Label(GraphName);
                GraphName.DataField = "GraphName";
                ActionName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_ActionName", "Action Name", locator, null);
                ActionNameLabel = new Label(ActionName);
                ActionName.DataField = "ActionName";
                DataMemberName = "ViewElemInfo";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Drop_downValues()
            {
                Buttons.Drop_downValues.Click();
            }
            
            public virtual void Customize()
            {
                Buttons.Customize.Click();
            }
            
            public virtual void Actions()
            {
                Buttons.Actions.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Drop_downValues { get; }
			public Button Customize { get; }
			public Button Actions { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Drop_downValues = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_panelPXBUtton1_P" +
                            "XButton1", "Drop-down Values", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Customize = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton3", "Customize", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Actions = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_ButtonGraphActions", "Actions", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton4", "Cancel", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo");
                }
            }
        }
        
        public class c_filterworkingproject_formnewproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NewProject { get; }
			public Label NewProjectLabel { get; }
            
            public c_filterworkingproject_formnewproject(string locator, string name) : 
                    base(locator, name)
            {
                NewProject = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject_edNewProject", "Project Name", locator, null);
                NewProjectLabel = new Label(NewProject);
                NewProject.DataField = "NewProject";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonOk", "OK", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject");
                }
            }
        }
        
        public class c_filterworkingproject_formselectproject : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector Name { get; }
			public Label NameLabel { get; }
            
            public c_filterworkingproject_formselectproject(string locator, string name) : 
                    base(locator, name)
            {
                Name = new Selector("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject_edWP", "Project Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public virtual void New()
            {
                Buttons.New.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
			public Button New { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectOk", "OK", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                    New = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_BtnNewProject", "New...", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject");
                }
            }
        }
        
        public class c_gridlist_gridgrid : Grid<c_gridlist_gridgrid.c_grid_row, c_gridlist_gridgrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_gridlist_gridgrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid");
                DataMemberName = "GridList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_fe_gf", "FilterForm");
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi { get; }
                
                public PxToolBar(string locator)
                {
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Selected { get; }
			public PXTextEdit View { get; }
			public PXTextEdit Id { get; }
                
                public c_grid_row(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ef", "Included", grid.Locator, "Selected");
                    Selected.DataField = "Selected";
                    View = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Table ID", grid.Locator, "View");
                    View.DataField = "View";
                    Id = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p0_gridGrid_ei", "Grid ID", grid.Locator, "Id");
                    Id.DataField = "Id";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Selected { get; }
				public PXTextEditColumnFilter View { get; }
				public PXTextEditColumnFilter Id { get; }
                
                public c_grid_header(c_gridlist_gridgrid grid) : 
                        base(grid)
                {
                    Selected = new CheckBoxColumnFilter(grid.Row.Selected);
                    View = new PXTextEditColumnFilter(grid.Row.View);
                    Id = new PXTextEditColumnFilter(grid.Row.Id);
                }
            }
        }
        
        public class c_userlist_usergrid : Grid<c_userlist_usergrid.c_grid_row, c_userlist_usergrid.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_userlist_usergrid(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid");
                DataMemberName = "UserList";
                FilterForm = new c_grid_filter("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New()
            {
                ToolBar.New.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid New { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Refresh\']", "Refresh", locator, null);
                    New = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AddNew\']", "Add Row", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'Delete\']", "Delete Row", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_at_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ab_tlb div[data-cmd=" +
                            "\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public CheckBox Included { get; }
			public Selector Username { get; }
			public PXTextEdit DisplayName { get; }
			public PXTextEdit Email { get; }
			public PXTextEdit Guest { get; }
			public DropDown State { get; }
                
                public c_grid_row(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBox("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Included", grid.Locator, "Included");
                    Included.DataField = "Included";
                    Username = new Selector("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Login", grid.Locator, "Username");
                    Username.DataField = "Username";
                    DisplayName = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Display Name", grid.Locator, "DisplayName");
                    DisplayName.DataField = "DisplayName";
                    Email = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Guest = new PXTextEdit("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_ef", "Guest Account", grid.Locator, "Guest");
                    Guest.DataField = "Guest";
                    State = new DropDown("_ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Status", grid.Locator, "State");
                    State.DataField = "State";
                    State.Items.Add("N", "Not Created");
                    State.Items.Add("O", "Online");
                    State.Items.Add("P", "Pending Activation");
                    State.Items.Add("D", "Disabled");
                    State.Items.Add("A", "Active");
                    State.Items.Add("L", "Temporarily Locked");
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public CheckBoxColumnFilter Included { get; }
				public SelectorColumnFilter Username { get; }
				public PXTextEditColumnFilter DisplayName { get; }
				public PXTextEditColumnFilter Email { get; }
				public PXTextEditColumnFilter Guest { get; }
				public DropDownColumnFilter State { get; }
                
                public c_grid_header(c_userlist_usergrid grid) : 
                        base(grid)
                {
                    Included = new CheckBoxColumnFilter(grid.Row.Included);
                    Username = new SelectorColumnFilter(grid.Row.Username);
                    DisplayName = new PXTextEditColumnFilter(grid.Row.DisplayName);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Guest = new PXTextEditColumnFilter(grid.Row.Guest);
                    State = new DropDownColumnFilter(grid.Row.State);
                }
            }
        }
        
        public class c_userlist_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DropDown Ec { get; }
            
            public c_userlist_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ec = new DropDown("ctl00_usrCaption_shareColumnsDlg_gridWizard_p1_userGrid_lv0_ec", "Ec", locator, null);
                DataMemberName = "UserList";
            }
        }
        
        public class c_companycurrent_tab : Container
        {
            
            public c_companycurrent_tab(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "CompanyCurrent";
            }
        }
        
        public class c_snapshots_gridsnapshots : Grid<c_snapshots_gridsnapshots.c_grid_row, c_snapshots_gridsnapshots.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_snapshots_gridsnapshots(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t0_gridSnapshots");
                DataMemberName = "Snapshots";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t0_gridSnapshots_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Delete()
            {
                ToolBar.Delete.Click();
            }
            
            public virtual void UploadSnapshotCommand()
            {
                ToolBar.UploadSnapshotCommand.Click();
            }
            
            public virtual void PrepareForExport()
            {
                ToolBar.PrepareForExport.Click();
            }
            
            public virtual void PrepareAdbSnapshotCommand()
            {
                ToolBar.PrepareAdbSnapshotCommand.Click();
            }
            
            public virtual void PrepareXmlSnapshotCommand()
            {
                ToolBar.PrepareXmlSnapshotCommand.Click();
            }
            
            public virtual void DownloadSnapshotCommand()
            {
                ToolBar.DownloadSnapshotCommand.Click();
            }
            
            public virtual void ChangeVisibilityCommand()
            {
                ToolBar.ChangeVisibilityCommand.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Delete { get; }
			public ToolBarButtonGrid UploadSnapshotCommand { get; }
			public ToolBarButtonGrid PrepareForExport { get; }
			public ToolBarButtonGrid PrepareAdbSnapshotCommand { get; }
			public ToolBarButtonGrid PrepareXmlSnapshotCommand { get; }
			public ToolBarButtonGrid DownloadSnapshotCommand { get; }
			public ToolBarButtonGrid ChangeVisibilityCommand { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Delete = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_at_tlb div[data-cmd=\'Delete\']", "Delete Row", locator, null);
                    UploadSnapshotCommand = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_at_tlb div[data-cmd=\'uploadSnapshotCommand\']", "Displays dialog to upload new data package.", locator, null);
                    PrepareForExport = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_at_tlb div:textEqual(\"Prepare for Export\") > " +
                            "div[data-type=\'drop\']", "Prepare the selected snapshot for export.", locator, null);
                    PrepareAdbSnapshotCommand = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t0_gridSnapshots_at_tlb_menu4 li[data-cmd=\'prepareSnapshotC" +
                            "ommand@prepareAdbSnapshotCommand\']", "Binary Format", locator, PrepareForExport);
                    PrepareXmlSnapshotCommand = new ToolBarButtonGrid("css=div#ctl00_phG_tab_t0_gridSnapshots_at_tlb_menu4 li[data-cmd=\'prepareSnapshotC" +
                            "ommand@prepareXmlSnapshotCommand\']", "XML Format", locator, PrepareForExport);
                    DownloadSnapshotCommand = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_at_tlb div[data-cmd=\'downloadSnapshotCommand\'" +
                            "]", "Download selected data package.", locator, null);
                    ChangeVisibilityCommand = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_at_tlb div[data-cmd=\'changeVisibilityCommand\'" +
                            "]", "Change current snapshot visibility.", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t0_gridSnapshots_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public PXTextEdit SnapshotID { get; }
			public PXTextEdit Name { get; }
			public PXTextEdit Description { get; }
			public CheckBox Prepared { get; }
			public PXNumberEdit SizePrepared { get; }
			public DateSelector Date { get; }
			public PXTextEdit Version { get; }
			public PXTextEdit ExportMode { get; }
			public Selector SourceCompany { get; }
			public PXTextEdit Customization { get; }
			public CheckBox IsSafe { get; }
                
                public c_grid_row(c_snapshots_gridsnapshots grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    SnapshotID = new PXTextEdit("ctl00_phG_tab_t0_gridSnapshots", "Snapshot ID", grid.Locator, "SnapshotID");
                    SnapshotID.DataField = "SnapshotID";
                    Name = new PXTextEdit("ctl00_phG_tab_t0_gridSnapshots_ei", "Name", grid.Locator, "Name");
                    Name.DataField = "Name";
                    Description = new PXTextEdit("ctl00_phG_tab_t0_gridSnapshots_ei", "Description", grid.Locator, "Description");
                    Description.DataField = "Description";
                    Prepared = new CheckBox("ctl00_phG_tab_t0_gridSnapshots", "Ready For Export", grid.Locator, "Prepared");
                    Prepared.DataField = "Prepared";
                    SizePrepared = new PXNumberEdit("ctl00_phG_tab_t0_gridSnapshots_en", "Size on Disk (MB)", grid.Locator, "SizePrepared");
                    SizePrepared.DataField = "SizePrepared";
                    Date = new DateSelector("_ctl00_phG_tab_t0_gridSnapshots_lv0_ed7", "Creation Date", grid.Locator, "Date");
                    Date.DataField = "Date";
                    Version = new PXTextEdit("ctl00_phG_tab_t0_gridSnapshots_ei", "Version", grid.Locator, "Version");
                    Version.DataField = "Version";
                    ExportMode = new PXTextEdit("ctl00_phG_tab_t0_gridSnapshots_ei", "Export Mode", grid.Locator, "ExportMode");
                    ExportMode.DataField = "ExportMode";
                    SourceCompany = new Selector("_ctl00_phG_tab_t0_gridSnapshots_lv0_es", "Tenant ID", grid.Locator, "SourceCompany");
                    SourceCompany.DataField = "SourceCompany";
                    Customization = new PXTextEdit("ctl00_phG_tab_t0_gridSnapshots_ei", "Customization", grid.Locator, "Customization");
                    Customization.DataField = "Customization";
                    IsSafe = new CheckBox("ctl00_phG_tab_t0_gridSnapshots", "Is Safe", grid.Locator, "IsSafe");
                    IsSafe.DataField = "IsSafe";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public PXTextEditColumnFilter SnapshotID { get; }
				public PXTextEditColumnFilter Name { get; }
				public PXTextEditColumnFilter Description { get; }
				public CheckBoxColumnFilter Prepared { get; }
				public PXNumberEditColumnFilter SizePrepared { get; }
				public DateSelectorColumnFilter Date { get; }
				public PXTextEditColumnFilter Version { get; }
				public PXTextEditColumnFilter ExportMode { get; }
				public SelectorColumnFilter SourceCompany { get; }
				public PXTextEditColumnFilter Customization { get; }
				public CheckBoxColumnFilter IsSafe { get; }
                
                public c_grid_header(c_snapshots_gridsnapshots grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    SnapshotID = new PXTextEditColumnFilter(grid.Row.SnapshotID);
                    Name = new PXTextEditColumnFilter(grid.Row.Name);
                    Description = new PXTextEditColumnFilter(grid.Row.Description);
                    Prepared = new CheckBoxColumnFilter(grid.Row.Prepared);
                    SizePrepared = new PXNumberEditColumnFilter(grid.Row.SizePrepared);
                    Date = new DateSelectorColumnFilter(grid.Row.Date);
                    Version = new PXTextEditColumnFilter(grid.Row.Version);
                    ExportMode = new PXTextEditColumnFilter(grid.Row.ExportMode);
                    SourceCompany = new SelectorColumnFilter(grid.Row.SourceCompany);
                    Customization = new PXTextEditColumnFilter(grid.Row.Customization);
                    IsSafe = new CheckBoxColumnFilter(grid.Row.IsSafe);
                }
            }
        }
        
        public class c_snapshots_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_snapshots_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t0_gridSnapshots_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t0_gridSnapshots_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "Snapshots";
            }
        }
        
        public class c_snapshotshistory_gridhistory : Grid<c_snapshotshistory_gridhistory.c_grid_row, c_snapshotshistory_gridhistory.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
            
            public c_snapshotshistory_gridhistory(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t1_gridHistory");
                DataMemberName = "SnapshotsHistory";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t1_gridHistory_fe_gf", "FilterForm");
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridHistory_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridHistory_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridHistory_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridHistory_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridHistory_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridHistory_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridHistory_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridHistory_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t1_gridHistory_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public PXTextEdit SnapshotID { get; }
			public PXTextEdit UPSnapshot__Name { get; }
			public PXTextEdit UPSnapshot__Description { get; }
			public Selector UserID { get; }
			public DateSelector CreatedDateTime { get; }
			public PXTextEdit UPSnapshot__Version { get; }
			public CheckBox IsSafe { get; }
			public CheckBox Dismissed { get; }
			public PXNumberEdit HistoryID { get; }
                
                public c_grid_row(c_snapshotshistory_gridhistory grid) : 
                        base(grid)
                {
                    SnapshotID = new PXTextEdit("ctl00_phG_tab_t1_gridHistory", "Snapshot ID", grid.Locator, "SnapshotID");
                    SnapshotID.DataField = "SnapshotID";
                    UPSnapshot__Name = new PXTextEdit("ctl00_phG_tab_t1_gridHistory_ei", "Name", grid.Locator, "UPSnapshot__Name");
                    UPSnapshot__Name.DataField = "UPSnapshot__Name";
                    UPSnapshot__Description = new PXTextEdit("ctl00_phG_tab_t1_gridHistory_ei", "Description", grid.Locator, "UPSnapshot__Description");
                    UPSnapshot__Description.DataField = "UPSnapshot__Description";
                    UserID = new Selector("_ctl00_phG_tab_t1_gridHistory_lv0_es", "User", grid.Locator, "UserID");
                    UserID.DataField = "UserID";
                    CreatedDateTime = new DateSelector("_ctl00_phG_tab_t1_gridHistory_lv0_ed4", "Restoration Date", grid.Locator, "CreatedDateTime");
                    CreatedDateTime.DataField = "CreatedDateTime";
                    UPSnapshot__Version = new PXTextEdit("ctl00_phG_tab_t1_gridHistory_ei", "Version", grid.Locator, "UPSnapshot__Version");
                    UPSnapshot__Version.DataField = "UPSnapshot__Version";
                    IsSafe = new CheckBox("ctl00_phG_tab_t1_gridHistory", "Is Safe", grid.Locator, "IsSafe");
                    IsSafe.DataField = "IsSafe";
                    Dismissed = new CheckBox("ctl00_phG_tab_t1_gridHistory", "Dismissed", grid.Locator, "Dismissed");
                    Dismissed.DataField = "Dismissed";
                    HistoryID = new PXNumberEdit("ctl00_phG_tab_t1_gridHistory_en", "History ID", grid.Locator, "HistoryID");
                    HistoryID.DataField = "HistoryID";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public PXTextEditColumnFilter SnapshotID { get; }
				public PXTextEditColumnFilter UPSnapshot__Name { get; }
				public PXTextEditColumnFilter UPSnapshot__Description { get; }
				public SelectorColumnFilter UserID { get; }
				public DateSelectorColumnFilter CreatedDateTime { get; }
				public PXTextEditColumnFilter UPSnapshot__Version { get; }
				public CheckBoxColumnFilter IsSafe { get; }
				public CheckBoxColumnFilter Dismissed { get; }
				public PXNumberEditColumnFilter HistoryID { get; }
                
                public c_grid_header(c_snapshotshistory_gridhistory grid) : 
                        base(grid)
                {
                    SnapshotID = new PXTextEditColumnFilter(grid.Row.SnapshotID);
                    UPSnapshot__Name = new PXTextEditColumnFilter(grid.Row.UPSnapshot__Name);
                    UPSnapshot__Description = new PXTextEditColumnFilter(grid.Row.UPSnapshot__Description);
                    UserID = new SelectorColumnFilter(grid.Row.UserID);
                    CreatedDateTime = new DateSelectorColumnFilter(grid.Row.CreatedDateTime);
                    UPSnapshot__Version = new PXTextEditColumnFilter(grid.Row.UPSnapshot__Version);
                    IsSafe = new CheckBoxColumnFilter(grid.Row.IsSafe);
                    Dismissed = new CheckBoxColumnFilter(grid.Row.Dismissed);
                    HistoryID = new PXNumberEditColumnFilter(grid.Row.HistoryID);
                }
            }
        }
        
        public class c_snapshotshistory_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
			public DateSelector Ed { get; }
			public Label EdLabel { get; }
            
            public c_snapshotshistory_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t1_gridHistory_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                Ed = new DateSelector("ctl00_phG_tab_t1_gridHistory_lv0_ed", "Ed", locator, null);
                EdLabel = new Label(Ed);
                DataMemberName = "SnapshotsHistory";
            }
        }
        
        public class c_users_gridusers : Grid<c_users_gridusers.c_grid_row, c_users_gridusers.c_grid_header>
        {
            
            public PxToolBar ToolBar;
            
			public c_grid_filter FilterForm { get; }
			public SmartPanel_AttachFile FilesUploadDialog { get; }
			public Note NotePanel { get; }
            
            public c_users_gridusers(string locator, string name) : 
                    base(locator, name)
            {
                ToolBar = new PxToolBar("ctl00_phG_tab_t2_gridUsers");
                DataMemberName = "Users";
                FilterForm = new c_grid_filter("ctl00_phG_tab_t2_gridUsers_fe_gf", "FilterForm");
                FilesUploadDialog = new SmartPanel_AttachFile(locator);
                NotePanel = new Note(locator);
            }
            
            public virtual void Refresh()
            {
                ToolBar.Refresh.Click();
            }
            
            public virtual void Adjust()
            {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export()
            {
                ToolBar.Export.Click();
            }
            
            public virtual void Hi()
            {
                ToolBar.Hi.Click();
            }
            
            public virtual void PageFirst()
            {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev()
            {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext()
            {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast()
            {
                ToolBar.PageLast.Click();
            }
            
            public virtual void Hi1()
            {
                ToolBar.Hi1.Click();
            }
            
            public class PxToolBar : PxControlCollection
            {
                
			public ToolBarButtonGrid Refresh { get; }
			public ToolBarButtonGrid Adjust { get; }
			public ToolBarButtonGrid Export { get; }
			public ToolBarButtonGrid Hi { get; }
			public ToolBarButtonGrid PageFirst { get; }
			public ToolBarButtonGrid PagePrev { get; }
			public ToolBarButtonGrid PageNext { get; }
			public ToolBarButtonGrid PageLast { get; }
			public ToolBarButtonGrid Hi1 { get; }
                
                public PxToolBar(string locator)
                {
                    Refresh = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridUsers_at_tlb div[data-cmd=\'Refresh\']", "Refresh", locator, null);
                    Adjust = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridUsers_at_tlb div[data-cmd=\'AdjustColumns\']", "Fit to Screen", locator, null);
                    Export = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridUsers_at_tlb div[data-cmd=\'ExportExcel\']", "Export to Excel", locator, null);
                    Hi = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridUsers_at_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                    PageFirst = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridUsers_ab_tlb div[data-cmd=\'PageFirst\']", "Go to First Page (Ctrl+PgUp)", locator, null);
                    PagePrev = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridUsers_ab_tlb div[data-cmd=\'PagePrev\']", "Go to Previous Page (PgUp)", locator, null);
                    PageNext = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridUsers_ab_tlb div[data-cmd=\'PageNext\']", "Go to Next Page (PgDn)", locator, null);
                    PageLast = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridUsers_ab_tlb div[data-cmd=\'PageLast\']", "Go to Last Page (Ctrl+PgDn)", locator, null);
                    Hi1 = new ToolBarButtonGrid("css=#ctl00_phG_tab_t2_gridUsers_ab_tlb div[data-cmd=\'hi\']", "Hi", locator, null);
                }
            }
            
            public class c_grid_row : GridRow
            {
                
			public FileColumnButton Files { get; }
			public NoteColumnButton Notes { get; }
			public Selector Username { get; }
			public CheckBox IsApproved { get; }
			public PXTextEdit FirstName { get; }
			public PXTextEdit LastName { get; }
			public PXTextEdit Email { get; }
			public PXTextEdit Phone { get; }
			public PXTextEdit Comment { get; }
			public CheckBox IsOnLine { get; }
			public CheckBox IsLockedOut { get; }
			public CheckBox PasswordChangeOnNextLogin { get; }
			public CheckBox AllowPasswordRecovery { get; }
			public CheckBox PasswordNeverExpires { get; }
                
                public c_grid_row(c_users_gridusers grid) : 
                        base(grid)
                {
                    Files = new FileColumnButton(null, "Files", grid.Locator, "Files");
                    Notes = new NoteColumnButton(null, "Notes", grid.Locator, "Notes");
                    Username = new Selector("_ctl00_phG_tab_t2_gridUsers_lv0_es", "Login", grid.Locator, "Username");
                    Username.DataField = "Username";
                    IsApproved = new CheckBox("ctl00_phG_tab_t2_gridUsers", "Activate Account", grid.Locator, "IsApproved");
                    IsApproved.DataField = "IsApproved";
                    FirstName = new PXTextEdit("ctl00_phG_tab_t2_gridUsers_ei", "First Name", grid.Locator, "FirstName");
                    FirstName.DataField = "FirstName";
                    LastName = new PXTextEdit("ctl00_phG_tab_t2_gridUsers_ei", "Last Name", grid.Locator, "LastName");
                    LastName.DataField = "LastName";
                    Email = new PXTextEdit("ctl00_phG_tab_t2_gridUsers_ei", "Email", grid.Locator, "Email");
                    Email.DataField = "Email";
                    Phone = new PXTextEdit("ctl00_phG_tab_t2_gridUsers_em", "Phone", grid.Locator, "Phone");
                    Phone.DataField = "Phone";
                    Comment = new PXTextEdit("ctl00_phG_tab_t2_gridUsers_ei", "Comment", grid.Locator, "Comment");
                    Comment.DataField = "Comment";
                    IsOnLine = new CheckBox("ctl00_phG_tab_t2_gridUsers", "Is Online", grid.Locator, "IsOnLine");
                    IsOnLine.DataField = "IsOnLine";
                    IsLockedOut = new CheckBox("ctl00_phG_tab_t2_gridUsers", "Temporarily Lock Out Account", grid.Locator, "IsLockedOut");
                    IsLockedOut.DataField = "IsLockedOut";
                    PasswordChangeOnNextLogin = new CheckBox("ctl00_phG_tab_t2_gridUsers", "Force User to Change Password on Next Login", grid.Locator, "PasswordChangeOnNextLogin");
                    PasswordChangeOnNextLogin.DataField = "PasswordChangeOnNextLogin";
                    AllowPasswordRecovery = new CheckBox("ctl00_phG_tab_t2_gridUsers", "Allow Password Recovery", grid.Locator, "AllowPasswordRecovery");
                    AllowPasswordRecovery.DataField = "AllowPasswordRecovery";
                    PasswordNeverExpires = new CheckBox("ctl00_phG_tab_t2_gridUsers", "Password Never Expires", grid.Locator, "PasswordNeverExpires");
                    PasswordNeverExpires.DataField = "PasswordNeverExpires";
                }
            }
            
            public class c_grid_header : GridHeader
            {
                
				public GridColumnHeader Files { get; }
				public GridColumnHeader Notes { get; }
				public SelectorColumnFilter Username { get; }
				public CheckBoxColumnFilter IsApproved { get; }
				public PXTextEditColumnFilter FirstName { get; }
				public PXTextEditColumnFilter LastName { get; }
				public PXTextEditColumnFilter Email { get; }
				public PXTextEditColumnFilter Phone { get; }
				public PXTextEditColumnFilter Comment { get; }
				public CheckBoxColumnFilter IsOnLine { get; }
				public CheckBoxColumnFilter IsLockedOut { get; }
				public CheckBoxColumnFilter PasswordChangeOnNextLogin { get; }
				public CheckBoxColumnFilter AllowPasswordRecovery { get; }
				public CheckBoxColumnFilter PasswordNeverExpires { get; }
                
                public c_grid_header(c_users_gridusers grid) : 
                        base(grid)
                {
                    Files = new GridColumnHeader(grid.Row.Files);
                    Notes = new GridColumnHeader(grid.Row.Notes);
                    Username = new SelectorColumnFilter(grid.Row.Username);
                    IsApproved = new CheckBoxColumnFilter(grid.Row.IsApproved);
                    FirstName = new PXTextEditColumnFilter(grid.Row.FirstName);
                    LastName = new PXTextEditColumnFilter(grid.Row.LastName);
                    Email = new PXTextEditColumnFilter(grid.Row.Email);
                    Phone = new PXTextEditColumnFilter(grid.Row.Phone);
                    Comment = new PXTextEditColumnFilter(grid.Row.Comment);
                    IsOnLine = new CheckBoxColumnFilter(grid.Row.IsOnLine);
                    IsLockedOut = new CheckBoxColumnFilter(grid.Row.IsLockedOut);
                    PasswordChangeOnNextLogin = new CheckBoxColumnFilter(grid.Row.PasswordChangeOnNextLogin);
                    AllowPasswordRecovery = new CheckBoxColumnFilter(grid.Row.AllowPasswordRecovery);
                    PasswordNeverExpires = new CheckBoxColumnFilter(grid.Row.PasswordNeverExpires);
                }
            }
        }
        
        public class c_users_lv0 : Container
        {
            
			public Selector Es { get; }
			public Label EsLabel { get; }
            
            public c_users_lv0(string locator, string name) : 
                    base(locator, name)
            {
                Es = new Selector("ctl00_phG_tab_t2_gridUsers_lv0_es", "Es", locator, null);
                EsLabel = new Label(Es);
                DataMemberName = "Users";
            }
        }
        
        public class c_copycompanypanel_frmcopycompany : Container
        {
            
            public PxButtonCollection Buttons;
            
			public Selector CompanyID { get; }
			public Label CompanyIDLabel { get; }
			public Label LblImportWarning_ { get; }
            
            public c_copycompanypanel_frmcopycompany(string locator, string name) : 
                    base(locator, name)
            {
                CompanyID = new Selector("ctl00_phF_pnlCopyCompany_frmCopyCompany_edCompanyID", "Company ID", locator, null);
                CompanyIDLabel = new Label(CompanyID);
                CompanyID.DataField = "CompanyID";
                LblImportWarning_ = new Label("ctl00_phF_pnlCopyCompany_frmCopyCompany_lblImportWarning", "WARNING: This action will overwrite all data in the destination company.", locator, null);
                DataMemberName = "CopyCompanyPanel";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phF_pnlCopyCompany_frmCopyCompany_btnCopyCompanyOK", "OK", "ctl00_phF_pnlCopyCompany_frmCopyCompany");
                    Cancel = new Button("ctl00_phF_pnlCopyCompany_frmCopyCompany_btnCopyCompanyCancel", "Cancel", "ctl00_phF_pnlCopyCompany_frmCopyCompany");
                }
            }
        }
        
        public class c_exportsnapshotpanel_frmexportsnapshot : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Company { get; }
			public Label CompanyLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public DropDown ExportMode { get; }
			public Label ExportModeLabel { get; }
			public CheckBox Prepare { get; }
			public Label PrepareLabel { get; }
			public DropDown PrepareMode { get; }
			public Label PrepareModeLabel { get; }
            
            public c_exportsnapshotpanel_frmexportsnapshot(string locator, string name) : 
                    base(locator, name)
            {
                Company = new PXTextEdit("ctl00_phF_pnlExportSnapshot_frmExportSnapshot_edCompany", "Company", locator, null);
                CompanyLabel = new Label(Company);
                Company.DataField = "Company";
                Description = new PXTextEdit("ctl00_phF_pnlExportSnapshot_frmExportSnapshot_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                ExportMode = new DropDown("ctl00_phF_pnlExportSnapshot_frmExportSnapshot_edExportMode", "Export Mode", locator, null);
                ExportModeLabel = new Label(ExportMode);
                ExportMode.DataField = "ExportMode";
                Prepare = new CheckBox("ctl00_phF_pnlExportSnapshot_frmExportSnapshot_chkPrepare", "Prepare", locator, null);
                PrepareLabel = new Label(Prepare);
                Prepare.DataField = "Prepare";
                PrepareMode = new DropDown("ctl00_phF_pnlExportSnapshot_frmExportSnapshot_edPrepareMode", "Prepare Mode", locator, null);
                PrepareModeLabel = new Label(PrepareMode);
                PrepareMode.DataField = "PrepareMode";
                DataMemberName = "ExportSnapshotPanel";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phF_pnlExportSnapshot_btnExportSnapshotOK", "OK", "ctl00_phF_pnlExportSnapshot_frmExportSnapshot");
                    Cancel = new Button("ctl00_phF_pnlExportSnapshot_btnExportSnapshotCancel", "Cancel", "ctl00_phF_pnlExportSnapshot_frmExportSnapshot");
                }
            }
        }
        
        public class c_reloadsnapshotpanel_frmreloadsnapshot : Container
        {
            
            public PxButtonCollection Buttons;
            
			public DropDown DataType { get; }
			public Label DataTypeLabel { get; }
            
            public c_reloadsnapshotpanel_frmreloadsnapshot(string locator, string name) : 
                    base(locator, name)
            {
                DataType = new DropDown("ctl00_phF_pnlReloadSnapshot_frmReloadSnapshot_edDataType", "Data Type", locator, null);
                DataTypeLabel = new Label(DataType);
                DataType.DataField = "DataType";
                DataMemberName = "ReloadSnapshotPanel";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phF_pnlReloadSnapshot_frmReloadSnapshot_btnReloadSnapshotOK", "OK", "ctl00_phF_pnlReloadSnapshot_frmReloadSnapshot");
                    Cancel = new Button("ctl00_phF_pnlReloadSnapshot_frmReloadSnapshot_btnReloadSnapshotCancel", "Cancel", "ctl00_phF_pnlReloadSnapshot_frmReloadSnapshot");
                }
            }
        }
        
        public class c_importsnapshotpanel_ftmimportsnapshot : Container
        {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit Company { get; }
			public Label CompanyLabel { get; }
			public PXTextEdit Name { get; }
			public Label NameLabel { get; }
			public PXTextEdit Description { get; }
			public Label DescriptionLabel { get; }
			public Label LblImportWarning_ { get; }
            
            public c_importsnapshotpanel_ftmimportsnapshot(string locator, string name) : 
                    base(locator, name)
            {
                Company = new PXTextEdit("ctl00_phF_pnlImportSnapshot_ftmImportSnapshot_edCompany", "Company", locator, null);
                CompanyLabel = new Label(Company);
                Company.DataField = "Company";
                Name = new PXTextEdit("ctl00_phF_pnlImportSnapshot_ftmImportSnapshot_edName", "Name", locator, null);
                NameLabel = new Label(Name);
                Name.DataField = "Name";
                Description = new PXTextEdit("ctl00_phF_pnlImportSnapshot_ftmImportSnapshot_edDescription", "Description", locator, null);
                DescriptionLabel = new Label(Description);
                Description.DataField = "Description";
                LblImportWarning_ = new Label("ctl00_phF_pnlImportSnapshot_ftmImportSnapshot_lblImportWarning", "WARNING: This action will overwrite all data in this company.", locator, null);
                DataMemberName = "ImportSnapshotPanel";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_phF_pnlImportSnapshot_btnImportSnapshotOK", "OK", "ctl00_phF_pnlImportSnapshot_ftmImportSnapshot");
                    Cancel = new Button("ctl00_phF_pnlImportSnapshot_btnImportSnapshotCancel", "Cancel", "ctl00_phF_pnlImportSnapshot_ftmImportSnapshot");
                }
            }
        }
        
        public class c_filterpreview_formpreview : Container
        {
            
            public PxButtonCollection Buttons;
            
            public c_filterpreview_formpreview(string locator, string name) : 
                    base(locator, name)
            {
                DataMemberName = "FilterPreview";
                Buttons = new PxButtonCollection();
            }
            
            public virtual void Ok()
            {
                Buttons.Ok.Click();
            }
            
            public virtual void Cancel()
            {
                Buttons.Cancel.Click();
            }
            
            public class PxButtonCollection : PxControlCollection
            {
                
			public Button Ok { get; }
			public Button Cancel { get; }
                
                public PxButtonCollection()
                {
                    Ok = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonOK", "OK", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                    Cancel = new Button("ctl00_usrCaption_PanelDynamicForm_PXButtonCancel", "Cancel", "ctl00_usrCaption_PanelDynamicForm_FormPreview");
                }
            }
        }
    }
}
