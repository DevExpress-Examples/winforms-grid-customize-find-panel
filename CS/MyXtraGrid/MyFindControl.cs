using System;
using DevExpress.XtraGrid.Controls;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.Utils;

namespace MyXtraGrid
{
    public class MyFindControl : FindControl
    {
        public MyFindControl(ColumnView view, object properties)
            : base(view, properties)
        {
            CustomizeControl();
        }


        private void CustomizeControl()
        {
            CustomizeButtons();
            CustomizeEditor();
            CustomizeLayoutControl();
        }
        private Control FindControl(string controlName)
        {
            return layoutControl1.GetControlByName(controlName);
        }
        private void CustomizeButtons()
        {
            FindControl("btClear").MinimumSize = new Size(100, 0);
            FindControl("btClear").Font = new Font(AppearanceObject.DefaultFont, FontStyle.Strikeout);
            FindControl("btFind").MinimumSize = new Size(100, 0);
            FindControl("btFind").Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
        }
        private void CustomizeEditor()
        {
            ButtonEdit be = FindControl("teFind") as ButtonEdit;
            be.Properties.Buttons.Add(new EditorButton(ButtonPredefines.Ellipsis));
            be.ButtonClick += be_ButtonClick;
            be.Properties.NullValuePrompt = "MyCustomPanel";
            be.Properties.NullValuePromptShowForEmptyValue = true;
        }

        void be_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
                using (Form form = new Form())
                {
                    form.ShowDialog();
                }
        }
        private void CustomizeLayoutControl()
        {
            layoutControl1.AllowCustomizationMenu = true;
        }
    }
}
