using System;

namespace MyXtraGrid {

    [System.ComponentModel.DesignerCategory("")]
	public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView {
		public MyGridView() : this(null) {}
		public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) {
			// put your initialization code here
		}
		protected override string ViewName { get { return "MyGridView"; } }

        protected override DevExpress.XtraGrid.Controls.FindControl CreateFindPanel(object findPanelProperties)
        {
            return new MyFindControl(this, findPanelProperties);
        }
	}
}
