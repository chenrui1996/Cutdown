namespace Cutdown
{
    partial class SettingView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            descriptionTextBox = new TextBox();
            targetDateTimePicker = new DateTimePicker();
            Confirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10F);
            label1.Location = new Point(19, 25);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 0;
            label1.Text = "描述：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F);
            label2.Location = new Point(19, 83);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 1;
            label2.Text = "目标日期：";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            descriptionTextBox.Location = new Point(102, 22);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(268, 29);
            descriptionTextBox.TabIndex = 2;
            // 
            // targetDateTimePicker
            // 
            targetDateTimePicker.Location = new Point(120, 79);
            targetDateTimePicker.Name = "targetDateTimePicker";
            targetDateTimePicker.Size = new Size(250, 27);
            targetDateTimePicker.TabIndex = 3;
            // 
            // Confirm
            // 
            Confirm.Font = new Font("Microsoft YaHei UI", 10F);
            Confirm.Location = new Point(146, 147);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(100, 30);
            Confirm.TabIndex = 4;
            Confirm.Text = "确定";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // SettingView
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 203);
            Controls.Add(Confirm);
            Controls.Add(targetDateTimePicker);
            Controls.Add(descriptionTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingView";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "设置";
            TopMost = true;
            Load += SettingView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox descriptionTextBox;
        private DateTimePicker targetDateTimePicker;
        private Button Confirm;
    }
}