
namespace lb3
{
    partial class MainView
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
            this.lManager = new System.Windows.Forms.Label();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.lbComputers = new System.Windows.Forms.ListBox();
            this.btAddTask = new System.Windows.Forms.Button();
            this.btAddComputer = new System.Windows.Forms.Button();
            this.dgActiveTasks = new System.Windows.Forms.DataGridView();
            this.btExecute = new System.Windows.Forms.Button();
            this.lamountComputers = new System.Windows.Forms.Label();
            this.lamountWorkPlaces = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.numComputers = new System.Windows.Forms.NumericUpDown();
            this.numWorkPlaces = new System.Windows.Forms.NumericUpDown();
            this.lManagerOut = new System.Windows.Forms.Label();
            this.chbRouter = new System.Windows.Forms.CheckBox();
            this.lPasswordOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgActiveTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lManager
            // 
            this.lManager.AutoSize = true;
            this.lManager.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lManager.Location = new System.Drawing.Point(921, 51);
            this.lManager.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lManager.Name = "lManager";
            this.lManager.Size = new System.Drawing.Size(177, 34);
            this.lManager.TabIndex = 1;
            this.lManager.Text = "Менеджер:";
            // 
            // lbTasks
            // 
            this.lbTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 25;
            this.lbTasks.Location = new System.Drawing.Point(436, 430);
            this.lbTasks.Margin = new System.Windows.Forms.Padding(6);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(296, 204);
            this.lbTasks.TabIndex = 2;
            this.lbTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTasks_MouseDoubleClick);
            // 
            // lbComputers
            // 
            this.lbComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbComputers.BackColor = System.Drawing.SystemColors.Info;
            this.lbComputers.FormattingEnabled = true;
            this.lbComputers.ItemHeight = 25;
            this.lbComputers.Location = new System.Drawing.Point(78, 430);
            this.lbComputers.Margin = new System.Windows.Forms.Padding(6);
            this.lbComputers.Name = "lbComputers";
            this.lbComputers.Size = new System.Drawing.Size(296, 204);
            this.lbComputers.TabIndex = 2;
            this.lbComputers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbComputers_MouseDoubleClick);
            // 
            // btAddTask
            // 
            this.btAddTask.Location = new System.Drawing.Point(898, 460);
            this.btAddTask.Margin = new System.Windows.Forms.Padding(6);
            this.btAddTask.Name = "btAddTask";
            this.btAddTask.Size = new System.Drawing.Size(200, 83);
            this.btAddTask.TabIndex = 3;
            this.btAddTask.Text = "Додати задачу";
            this.btAddTask.UseVisualStyleBackColor = true;
            this.btAddTask.Click += new System.EventHandler(this.btAddTask_Click);
            // 
            // btAddComputer
            // 
            this.btAddComputer.Location = new System.Drawing.Point(1130, 460);
            this.btAddComputer.Margin = new System.Windows.Forms.Padding(6);
            this.btAddComputer.Name = "btAddComputer";
            this.btAddComputer.Size = new System.Drawing.Size(200, 83);
            this.btAddComputer.TabIndex = 3;
            this.btAddComputer.Text = "Додати комп\'ютер";
            this.btAddComputer.UseVisualStyleBackColor = true;
            this.btAddComputer.Click += new System.EventHandler(this.btAddComputer_Click);
            // 
            // dgActiveTasks
            // 
            this.dgActiveTasks.AllowUserToAddRows = false;
            this.dgActiveTasks.AllowUserToDeleteRows = false;
            this.dgActiveTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgActiveTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgActiveTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActiveTasks.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgActiveTasks.Location = new System.Drawing.Point(78, 34);
            this.dgActiveTasks.Margin = new System.Windows.Forms.Padding(6);
            this.dgActiveTasks.Name = "dgActiveTasks";
            this.dgActiveTasks.ReadOnly = true;
            this.dgActiveTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgActiveTasks.Size = new System.Drawing.Size(654, 374);
            this.dgActiveTasks.TabIndex = 6;
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(898, 576);
            this.btExecute.Margin = new System.Windows.Forms.Padding(6);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(432, 58);
            this.btExecute.TabIndex = 4;
            this.btExecute.Text = "Виконати";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // lamountComputers
            // 
            this.lamountComputers.AutoSize = true;
            this.lamountComputers.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lamountComputers.Location = new System.Drawing.Point(937, 128);
            this.lamountComputers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lamountComputers.Name = "lamountComputers";
            this.lamountComputers.Size = new System.Drawing.Size(199, 34);
            this.lamountComputers.TabIndex = 1;
            this.lamountComputers.Text = "Комп\'ютери:";
            // 
            // lamountWorkPlaces
            // 
            this.lamountWorkPlaces.AutoSize = true;
            this.lamountWorkPlaces.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lamountWorkPlaces.Location = new System.Drawing.Point(925, 197);
            this.lamountWorkPlaces.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lamountWorkPlaces.Name = "lamountWorkPlaces";
            this.lamountWorkPlaces.Size = new System.Drawing.Size(211, 34);
            this.lamountWorkPlaces.TabIndex = 1;
            this.lamountWorkPlaces.Text = "Робочі місця:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPassword.Location = new System.Drawing.Point(962, 341);
            this.lPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(115, 29);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Пароль:";
            // 
            // numComputers
            // 
            this.numComputers.BackColor = System.Drawing.SystemColors.Info;
            this.numComputers.Location = new System.Drawing.Point(1148, 128);
            this.numComputers.Margin = new System.Windows.Forms.Padding(6);
            this.numComputers.Name = "numComputers";
            this.numComputers.Size = new System.Drawing.Size(89, 32);
            this.numComputers.TabIndex = 8;
            this.numComputers.ValueChanged += new System.EventHandler(this.numComputers_ValueChanged);
            // 
            // numWorkPlaces
            // 
            this.numWorkPlaces.BackColor = System.Drawing.SystemColors.Info;
            this.numWorkPlaces.Location = new System.Drawing.Point(1148, 201);
            this.numWorkPlaces.Margin = new System.Windows.Forms.Padding(6);
            this.numWorkPlaces.Name = "numWorkPlaces";
            this.numWorkPlaces.Size = new System.Drawing.Size(89, 32);
            this.numWorkPlaces.TabIndex = 8;
            this.numWorkPlaces.ValueChanged += new System.EventHandler(this.numWorkPlaces_ValueChanged);
            // 
            // lManagerOut
            // 
            this.lManagerOut.AutoSize = true;
            this.lManagerOut.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lManagerOut.Location = new System.Drawing.Point(1097, 51);
            this.lManagerOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lManagerOut.Name = "lManagerOut";
            this.lManagerOut.Size = new System.Drawing.Size(25, 34);
            this.lManagerOut.TabIndex = 9;
            this.lManagerOut.Text = " ";
            // 
            // chbRouter
            // 
            this.chbRouter.AutoSize = true;
            this.chbRouter.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbRouter.Location = new System.Drawing.Point(1046, 280);
            this.chbRouter.Margin = new System.Windows.Forms.Padding(6);
            this.chbRouter.Name = "chbRouter";
            this.chbRouter.Size = new System.Drawing.Size(119, 33);
            this.chbRouter.TabIndex = 10;
            this.chbRouter.Text = "Роутер";
            this.chbRouter.UseVisualStyleBackColor = true;
            this.chbRouter.CheckedChanged += new System.EventHandler(this.chbRouter_CheckedChanged);
            // 
            // lPasswordOut
            // 
            this.lPasswordOut.AutoSize = true;
            this.lPasswordOut.Enabled = false;
            this.lPasswordOut.Location = new System.Drawing.Point(1089, 345);
            this.lPasswordOut.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lPasswordOut.Name = "lPasswordOut";
            this.lPasswordOut.Size = new System.Drawing.Size(19, 25);
            this.lPasswordOut.TabIndex = 11;
            this.lPasswordOut.Text = " ";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1428, 716);
            this.Controls.Add(this.lPasswordOut);
            this.Controls.Add(this.chbRouter);
            this.Controls.Add(this.lManagerOut);
            this.Controls.Add(this.numWorkPlaces);
            this.Controls.Add(this.numComputers);
            this.Controls.Add(this.dgActiveTasks);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.btAddComputer);
            this.Controls.Add(this.btAddTask);
            this.Controls.Add(this.lbComputers);
            this.Controls.Add(this.lbTasks);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lamountWorkPlaces);
            this.Controls.Add(this.lamountComputers);
            this.Controls.Add(this.lManager);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainView";
            this.Text = "І";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgActiveTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lManager;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.ListBox lbComputers;
        private System.Windows.Forms.Button btAddTask;
        private System.Windows.Forms.Button btAddComputer;
        private System.Windows.Forms.DataGridView dgActiveTasks;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Label lamountComputers;
        private System.Windows.Forms.Label lamountWorkPlaces;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.NumericUpDown numComputers;
        private System.Windows.Forms.NumericUpDown numWorkPlaces;
        private System.Windows.Forms.Label lManagerOut;
        private System.Windows.Forms.CheckBox chbRouter;
        private System.Windows.Forms.Label lPasswordOut;
    }
}