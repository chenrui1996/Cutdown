using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cutdown
{
    public partial class SettingView : Form
    {
        public SettingView()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            targetDateTimePicker.Format = DateTimePickerFormat.Custom;
            targetDateTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            targetDateTimePicker.ShowUpDown = true;
        }

        private void SettingView_Load(object sender, EventArgs e)
        {
            try
            {
                var setting = FileHelper.GetSetting();
                descriptionTextBox.Text = setting.description;
                targetDateTimePicker.Value = setting.targetDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.DialogResult == DialogResult.None)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                var targetDateTime = targetDateTimePicker.Value;
                if (targetDateTime <= DateTime.Now)
                {
                    MessageBox.Show("目标时间不能小于当前时间");
                    return;
                }
                var description = descriptionTextBox.Text.ToString().Trim();
                if (description.Length > 20)
                {
                    MessageBox.Show("描述不能超过20个字符");
                    return;
                }
                FileHelper.UpdateSetting(description, targetDateTime);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
