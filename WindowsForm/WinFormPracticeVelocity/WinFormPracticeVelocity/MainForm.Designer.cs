namespace WinFormPracticeVelocity
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCreateRegister = new System.Windows.Forms.Button();
            this.btnCreateDiagnosis = new System.Windows.Forms.Button();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnSubOne = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.lblDisRegisterStatus = new System.Windows.Forms.Label();
            this.lblDisDiagnosisStatus = new System.Windows.Forms.Label();
            this.btnLoopToMax = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegisterStatus = new System.Windows.Forms.Label();
            this.lblDiagnosisStatus = new System.Windows.Forms.Label();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.gbAddSubBtns = new System.Windows.Forms.GroupBox();
            this.gbActions.SuspendLayout();
            this.gbAddSubBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateRegister
            // 
            this.btnCreateRegister.BackColor = System.Drawing.SystemColors.Window;
            this.btnCreateRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateRegister.FlatAppearance.BorderSize = 15;
            this.btnCreateRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRegister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateRegister.Location = new System.Drawing.Point(6, 19);
            this.btnCreateRegister.Name = "btnCreateRegister";
            this.btnCreateRegister.Size = new System.Drawing.Size(170, 23);
            this.btnCreateRegister.TabIndex = 0;
            this.btnCreateRegister.Text = "Create Register";
            this.btnCreateRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateRegister.UseVisualStyleBackColor = false;
            this.btnCreateRegister.Click += new System.EventHandler(this.btnCreateRegister_Click);
            // 
            // btnCreateDiagnosis
            // 
            this.btnCreateDiagnosis.BackColor = System.Drawing.SystemColors.Window;
            this.btnCreateDiagnosis.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateDiagnosis.FlatAppearance.BorderSize = 5;
            this.btnCreateDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDiagnosis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateDiagnosis.Location = new System.Drawing.Point(6, 48);
            this.btnCreateDiagnosis.Name = "btnCreateDiagnosis";
            this.btnCreateDiagnosis.Size = new System.Drawing.Size(170, 23);
            this.btnCreateDiagnosis.TabIndex = 1;
            this.btnCreateDiagnosis.Text = "Create Diagnosis";
            this.btnCreateDiagnosis.UseVisualStyleBackColor = false;
            this.btnCreateDiagnosis.Click += new System.EventHandler(this.btnCreateDiagnosis_Click);
            // 
            // btnAddOne
            // 
            this.btnAddOne.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOne.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddOne.Location = new System.Drawing.Point(6, 43);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(170, 23);
            this.btnAddOne.TabIndex = 2;
            this.btnAddOne.Text = "Add One To Register";
            this.btnAddOne.UseVisualStyleBackColor = false;
            this.btnAddOne.Visible = false;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnSubOne
            // 
            this.btnSubOne.BackColor = System.Drawing.SystemColors.Window;
            this.btnSubOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubOne.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubOne.Location = new System.Drawing.Point(186, 43);
            this.btnSubOne.Name = "btnSubOne";
            this.btnSubOne.Size = new System.Drawing.Size(170, 23);
            this.btnSubOne.TabIndex = 3;
            this.btnSubOne.Text = "Subtract One From Register";
            this.btnSubOne.UseVisualStyleBackColor = false;
            this.btnSubOne.Visible = false;
            this.btnSubOne.Click += new System.EventHandler(this.btnSubOne_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessages.Location = new System.Drawing.Point(13, 224);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(659, 189);
            this.txtMessages.TabIndex = 4;
            this.txtMessages.Text = "Messages:";
            // 
            // lblDisRegisterStatus
            // 
            this.lblDisRegisterStatus.AutoSize = true;
            this.lblDisRegisterStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDisRegisterStatus.Location = new System.Drawing.Point(182, 19);
            this.lblDisRegisterStatus.Name = "lblDisRegisterStatus";
            this.lblDisRegisterStatus.Size = new System.Drawing.Size(102, 16);
            this.lblDisRegisterStatus.TabIndex = 5;
            this.lblDisRegisterStatus.Text = "Register Status:";
            // 
            // lblDisDiagnosisStatus
            // 
            this.lblDisDiagnosisStatus.AutoSize = true;
            this.lblDisDiagnosisStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDisDiagnosisStatus.Location = new System.Drawing.Point(182, 48);
            this.lblDisDiagnosisStatus.Name = "lblDisDiagnosisStatus";
            this.lblDisDiagnosisStatus.Size = new System.Drawing.Size(112, 16);
            this.lblDisDiagnosisStatus.TabIndex = 6;
            this.lblDisDiagnosisStatus.Text = "Diagnosis Status:";
            // 
            // btnLoopToMax
            // 
            this.btnLoopToMax.BackColor = System.Drawing.SystemColors.Window;
            this.btnLoopToMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoopToMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoopToMax.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoopToMax.Location = new System.Drawing.Point(362, 43);
            this.btnLoopToMax.Name = "btnLoopToMax";
            this.btnLoopToMax.Size = new System.Drawing.Size(170, 23);
            this.btnLoopToMax.TabIndex = 7;
            this.btnLoopToMax.Text = "Loop To Max Register Value";
            this.btnLoopToMax.UseVisualStyleBackColor = false;
            this.btnLoopToMax.Visible = false;
            this.btnLoopToMax.Click += new System.EventHandler(this.btnLoopToMax_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.BackColor = System.Drawing.SystemColors.Window;
            this.btnResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnResetAll.Location = new System.Drawing.Point(6, 77);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(170, 23);
            this.btnResetAll.TabIndex = 8;
            this.btnResetAll.Text = "Clear Messages";
            this.btnResetAll.UseVisualStyleBackColor = false;
            this.btnResetAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnResetAll_MouseClick);
            // 
            // cmbActive
            // 
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "None"});
            this.cmbActive.Location = new System.Drawing.Point(186, 16);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(170, 24);
            this.cmbActive.TabIndex = 9;
            this.cmbActive.Text = "None";
            this.cmbActive.SelectedIndexChanged += new System.EventHandler(this.cmbActive_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Active/Created Events:";
            // 
            // lblRegisterStatus
            // 
            this.lblRegisterStatus.AutoSize = true;
            this.lblRegisterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterStatus.Location = new System.Drawing.Point(300, 19);
            this.lblRegisterStatus.Name = "lblRegisterStatus";
            this.lblRegisterStatus.Size = new System.Drawing.Size(51, 16);
            this.lblRegisterStatus.TabIndex = 11;
            this.lblRegisterStatus.Text = "Empty";
            // 
            // lblDiagnosisStatus
            // 
            this.lblDiagnosisStatus.AutoSize = true;
            this.lblDiagnosisStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosisStatus.Location = new System.Drawing.Point(300, 48);
            this.lblDiagnosisStatus.Name = "lblDiagnosisStatus";
            this.lblDiagnosisStatus.Size = new System.Drawing.Size(51, 16);
            this.lblDiagnosisStatus.TabIndex = 12;
            this.lblDiagnosisStatus.Text = "Empty";
            // 
            // gbActions
            // 
            this.gbActions.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbActions.Controls.Add(this.btnCreateRegister);
            this.gbActions.Controls.Add(this.lblDiagnosisStatus);
            this.gbActions.Controls.Add(this.btnCreateDiagnosis);
            this.gbActions.Controls.Add(this.lblRegisterStatus);
            this.gbActions.Controls.Add(this.btnResetAll);
            this.gbActions.Controls.Add(this.lblDisRegisterStatus);
            this.gbActions.Controls.Add(this.lblDisDiagnosisStatus);
            this.gbActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActions.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gbActions.Location = new System.Drawing.Point(13, 12);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(659, 116);
            this.gbActions.TabIndex = 13;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // gbAddSubBtns
            // 
            this.gbAddSubBtns.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbAddSubBtns.Controls.Add(this.label3);
            this.gbAddSubBtns.Controls.Add(this.btnAddOne);
            this.gbAddSubBtns.Controls.Add(this.btnSubOne);
            this.gbAddSubBtns.Controls.Add(this.cmbActive);
            this.gbAddSubBtns.Controls.Add(this.btnLoopToMax);
            this.gbAddSubBtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddSubBtns.Location = new System.Drawing.Point(13, 134);
            this.gbAddSubBtns.Name = "gbAddSubBtns";
            this.gbAddSubBtns.Size = new System.Drawing.Size(659, 84);
            this.gbAddSubBtns.TabIndex = 14;
            this.gbAddSubBtns.TabStop = false;
            this.gbAddSubBtns.Text = "Add Subtract Functions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(684, 425);
            this.Controls.Add(this.gbAddSubBtns);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.txtMessages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kirk Rudzinski Practice Velocity WinForm";
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            this.gbAddSubBtns.ResumeLayout(false);
            this.gbAddSubBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRegister;
        private System.Windows.Forms.Button btnCreateDiagnosis;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnSubOne;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Label lblDisRegisterStatus;
        private System.Windows.Forms.Label lblDisDiagnosisStatus;
        private System.Windows.Forms.Button btnLoopToMax;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRegisterStatus;
        private System.Windows.Forms.Label lblDiagnosisStatus;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.GroupBox gbAddSubBtns;
    }
}

