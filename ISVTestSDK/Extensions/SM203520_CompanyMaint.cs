﻿
using Controls.Uploader;

namespace ISVTestSDK.Extensions
{
    public partial class CompanyMaint : SM203520_CompanyMaint
    {
        public c_snapshots_gridsnapshots Snapshots => Snapshots_gridSnapshots;
        public c_screen_upload cUploadSnapshotPackage => UploadSnapshotPackage;

        public c_importsnapshotpanel_ftmimportsnapshot RestoreSnapshotSettings => ImportSnapshotPanel_ftmImportSnapshot;


    }
}
