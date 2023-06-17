using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Common;

namespace SALES
{
    public static class General
    {
        public static void SetControlStyle(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                SetControlFocusStyle(ctrl);
            }
        }

        private static void SetControlFocusStyle(Control ctrl)
        {
            if (ctrl.HasChildren)
            {
                foreach (Control childCtrl in ctrl.Controls)
                {
                    SetControlFocusStyle(childCtrl);
                }
            }
            else if ((ctrl) is Button | (ctrl) is RadButton)
            {
                ctrl.GotFocus += button_GotFocus;
                ctrl.LostFocus += button_LostFocus;
            }
            else if ((ctrl) is TextBox | (ctrl) is RadTextBox)
            {
                ctrl.GotFocus += GotFocus;
                //ctrl.MouseEnter += GotFocus;
                ctrl.LostFocus += LostFocus;
                //ctrl.MouseLeave += LostFocus;
            }
            else if ((ctrl) is ComboBox | (ctrl) is RadDropDownList)
            {
                ctrl.GotFocus += GotFocus;
                //ctrl.MouseEnter += GotFocus;
                ctrl.LostFocus += LostFocus;
                //ctrl.MouseLeave += LostFocus;
            }
            else if ((ctrl) is CheckBox | (ctrl) is RadCheckBox)
            {
                ctrl.GotFocus += GotFocus;
                ctrl.MouseEnter += GotFocus;
                ctrl.LostFocus += LostFocus;
                ctrl.MouseLeave += LostFocus;
            }
            else if ((ctrl) is RadioButton | (ctrl) is RadRadioButton)
            {

            }
            else if ((ctrl) is DateTimePicker | (ctrl) is RadDateTimePicker)
            {
                //ctrl.KeyDown +=  DatePicker_KeyDown
            }
        }

        private static void button_GotFocus(object sender, EventArgs e)
        {
            Dictionary<object, object> dicFocus = new Dictionary<object, object>();

            Control ctrl = (Control)sender;

            dicFocus.Add("FORECOLOR", ctrl.ForeColor);
            dicFocus.Add("BACKCOLOR", ctrl.BackColor);

            ctrl.Tag = dicFocus;
            ctrl.ForeColor = Color.White;
            ctrl.BackColor = Color.LimeGreen;
        }

        private static void button_LostFocus(object sender, EventArgs e)
        {
            Dictionary<object, object> dicFocus = new Dictionary<object, object>();

            Control ctrl = (Control)sender;

            if (ctrl.Tag != null)
                dicFocus = (Dictionary<object, object>)ctrl.Tag;

            if (dicFocus != null)
            {
                if (dicFocus.ContainsKey("FORECOLOR"))
                {
                    if (dicFocus["FORECOLOR"].GetStringValue() != "")
                        ctrl.ForeColor = (Color)dicFocus["FORECOLOR"];
                }

                if (dicFocus.ContainsKey("BACKCOLOR"))
                {
                    if (dicFocus["BACKCOLOR"].GetStringValue() != "")
                        ctrl.BackColor = (Color)dicFocus["BACKCOLOR"];
                }
            }
        }

        private static void GotFocus(object sender, EventArgs e)
        {
            Dictionary<object, object> dicFocus = new Dictionary<object, object>();

            Control ctrl = (Control)sender;

            dicFocus.Add("FORECOLOR", ctrl.ForeColor);
            dicFocus.Add("BACKCOLOR", ctrl.BackColor);

            ctrl.Tag = dicFocus;
            ctrl.BackColor = Color.Azure;

        }

        private static void LostFocus(object sender, EventArgs e)
        {
            Dictionary<object, object> dicFocus = new Dictionary<object, object>();

            Control ctrl = (Control)sender;

            if (ctrl.Tag != null)
                dicFocus = (Dictionary<object, object>)ctrl.Tag;

            if (dicFocus != null)
            {
                if (dicFocus.ContainsKey("FORECOLOR"))
                {
                    if (dicFocus["FORECOLOR"].GetStringValue() != "")
                        ctrl.ForeColor = (Color)dicFocus["FORECOLOR"];
                }

                if (dicFocus.ContainsKey("BACKCOLOR"))
                {
                    if (dicFocus["BACKCOLOR"].GetStringValue() != "")
                        ctrl.BackColor = (Color)dicFocus["BACKCOLOR"];
                }
            }
        }

        public static void CustomRadGridBehaviour(ICustomForm parentForm)
        {
            //parentForm.GotFocus += parentForm_GotFocus;
            UserSession.ActiveForm = parentForm;

            foreach (RadGridView rgv in GetAll((Form)parentForm, typeof(RadGridView)))
            {
                //register the custom row  behavior
                BaseGridBehavior gridBehavior = (BaseGridBehavior)(rgv).GridBehavior;
                gridBehavior.UnregisterBehavior(typeof(GridViewDataRowInfo));
                gridBehavior.RegisterBehavior(typeof(GridViewDataRowInfo), new CustomGridDataRowBehavior());
            }
        }

        //private static void parentForm_GotFocus(object sender, EventArgs e)
        //{
        //    UserSession.ActiveForm = (ICustomForm)sender;
        //}

        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public static T GetEnumVal<T>(string value)
        {
            if (value == "")
            {
                return GetEnumVal<T>(0);
            }
            else
            {
                return (T)Enum.Parse(typeof(T), value, true);
            }
        }

        public static T GetEnumVal<T>(int value)
        {
            return (T)Enum.GetValues(typeof(T)).GetValue(value);
        }

        public class CustomGridDataRowBehavior : GridDataRowBehavior
        {
            protected override bool ProcessEscapeKey(KeyEventArgs keys)
            {
                if (UserSession.ActiveForm != null)
                {
                    UserSession.ActiveForm.CancelEdit = true;
                }

                return base.ProcessEscapeKey(keys);
            }
            protected override bool ProcessTabKey(KeyEventArgs keys)
            {
                if (UserSession.ActiveForm != null)
                {
                    UserSession.ActiveForm.CancelEdit = true;
                }

                return base.ProcessTabKey(keys);
            }
        }

        public static int GetExcelColumnNumber(string columnName)
        {
            if (string.IsNullOrEmpty(columnName))
                throw new ArgumentNullException("Invalid column name parameter");

            columnName = columnName.ToUpperInvariant();

            int sum = 0;

            char ch;
            for (int i = 0; i < columnName.Length; i++)
            {
                ch = columnName[i];

                if (char.IsDigit(ch))
                    throw new ArgumentNullException("Invalid column name parameter on character " + ch);

                sum *= 26;
                sum += (ch - 'A' + 1);
                //sum += (columnName[i] - 'A');
            }

            return sum;
        }

        public static string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

    }
}
