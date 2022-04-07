namespace TecTip_SWVariable
{
    partial class Form1
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
            this.TextBox_Create_Variable = new System.Windows.Forms.TextBox();
            this.Button_Create = new System.Windows.Forms.Button();
            this.Button_Read = new System.Windows.Forms.Button();
            this.TextBox_Read_Variable = new System.Windows.Forms.TextBox();
            this.Label_Read_Value = new System.Windows.Forms.Label();
            this.TextBox_Update_Variable = new System.Windows.Forms.TextBox();
            this.Button_Update = new System.Windows.Forms.Button();
            this.TextBox_Update_Value = new System.Windows.Forms.TextBox();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.TextBox_Delete_Variable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox_Create_Variable
            // 
            this.TextBox_Create_Variable.Location = new System.Drawing.Point(13, 13);
            this.TextBox_Create_Variable.Name = "TextBox_Create_Variable";
            this.TextBox_Create_Variable.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Create_Variable.TabIndex = 0;
            // 
            // Button_Create
            // 
            this.Button_Create.Location = new System.Drawing.Point(119, 10);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(121, 23);
            this.Button_Create.TabIndex = 1;
            this.Button_Create.Text = "Create";
            this.Button_Create.UseVisualStyleBackColor = true;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // Button_Read
            // 
            this.Button_Read.Location = new System.Drawing.Point(119, 39);
            this.Button_Read.Name = "Button_Read";
            this.Button_Read.Size = new System.Drawing.Size(121, 23);
            this.Button_Read.TabIndex = 3;
            this.Button_Read.Text = "Read";
            this.Button_Read.UseVisualStyleBackColor = true;
            this.Button_Read.Click += new System.EventHandler(this.Button_Read_Click);
            // 
            // TextBox_Read_Variable
            // 
            this.TextBox_Read_Variable.Location = new System.Drawing.Point(13, 42);
            this.TextBox_Read_Variable.Name = "TextBox_Read_Variable";
            this.TextBox_Read_Variable.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Read_Variable.TabIndex = 2;
            // 
            // Label_Read_Value
            // 
            this.Label_Read_Value.AutoSize = true;
            this.Label_Read_Value.Location = new System.Drawing.Point(246, 45);
            this.Label_Read_Value.Name = "Label_Read_Value";
            this.Label_Read_Value.Size = new System.Drawing.Size(75, 13);
            this.Label_Read_Value.TabIndex = 4;
            this.Label_Read_Value.Text = "Variable Value";
            // 
            // TextBox_Update_Variable
            // 
            this.TextBox_Update_Variable.Location = new System.Drawing.Point(13, 71);
            this.TextBox_Update_Variable.Name = "TextBox_Update_Variable";
            this.TextBox_Update_Variable.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Update_Variable.TabIndex = 5;
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point(228, 68);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(121, 23);
            this.Button_Update.TabIndex = 7;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // TextBox_Update_Value
            // 
            this.TextBox_Update_Value.Location = new System.Drawing.Point(122, 71);
            this.TextBox_Update_Value.Name = "TextBox_Update_Value";
            this.TextBox_Update_Value.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Update_Value.TabIndex = 6;
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(119, 97);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(121, 23);
            this.Button_Delete.TabIndex = 9;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // TextBox_Delete_Variable
            // 
            this.TextBox_Delete_Variable.Location = new System.Drawing.Point(13, 100);
            this.TextBox_Delete_Variable.Name = "TextBox_Delete_Variable";
            this.TextBox_Delete_Variable.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Delete_Variable.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 138);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.TextBox_Delete_Variable);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.TextBox_Update_Value);
            this.Controls.Add(this.TextBox_Update_Variable);
            this.Controls.Add(this.Label_Read_Value);
            this.Controls.Add(this.Button_Read);
            this.Controls.Add(this.TextBox_Read_Variable);
            this.Controls.Add(this.Button_Create);
            this.Controls.Add(this.TextBox_Create_Variable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Create_Variable;
        private System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.Button Button_Read;
        private System.Windows.Forms.TextBox TextBox_Read_Variable;
        private System.Windows.Forms.Label Label_Read_Value;
        private System.Windows.Forms.TextBox TextBox_Update_Variable;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.TextBox TextBox_Update_Value;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.TextBox TextBox_Delete_Variable;
    }
}

