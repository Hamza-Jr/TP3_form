
namespace TP3_Form
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
            this.bnt_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Delet = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.ID_Box = new System.Windows.Forms.ComboBox();
            this.prenom_label = new System.Windows.Forms.Label();
            this.Adresse_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.tele_label = new System.Windows.Forms.Label();
            this.nom_label = new System.Windows.Forms.Label();
            this.input_nom = new System.Windows.Forms.TextBox();
            this.input_tele = new System.Windows.Forms.TextBox();
            this.input_adresse = new System.Windows.Forms.TextBox();
            this.input_prenom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bnt_Add
            // 
            this.bnt_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bnt_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bnt_Add.Location = new System.Drawing.Point(584, 482);
            this.bnt_Add.Name = "bnt_Add";
            this.bnt_Add.Size = new System.Drawing.Size(151, 73);
            this.bnt_Add.TabIndex = 0;
            this.bnt_Add.Text = "Insert";
            this.bnt_Add.UseVisualStyleBackColor = false;
            this.bnt_Add.Click += new System.EventHandler(this.bnt_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Edit.Location = new System.Drawing.Point(419, 482);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(165, 73);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(103, 482);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(165, 73);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Delet
            // 
            this.btn_Delet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Delet.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Delet.Location = new System.Drawing.Point(261, 482);
            this.btn_Delet.Name = "btn_Delet";
            this.btn_Delet.Size = new System.Drawing.Size(165, 73);
            this.btn_Delet.TabIndex = 3;
            this.btn_Delet.Text = "Delet";
            this.btn_Delet.UseVisualStyleBackColor = false;
            this.btn_Delet.Click += new System.EventHandler(this.btn_Delet_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Save.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Save.Location = new System.Drawing.Point(1027, 490);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(118, 65);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ID_Box
            // 
            this.ID_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_Box.FormattingEnabled = true;
            this.ID_Box.Location = new System.Drawing.Point(489, 63);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(393, 24);
            this.ID_Box.TabIndex = 5;
            this.ID_Box.SelectedIndexChanged += new System.EventHandler(this.ID_Box_SelectedIndexChanged);
            // 
            // prenom_label
            // 
            this.prenom_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.prenom_label.AutoSize = true;
            this.prenom_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.prenom_label.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_label.Location = new System.Drawing.Point(360, 186);
            this.prenom_label.Name = "prenom_label";
            this.prenom_label.Size = new System.Drawing.Size(103, 24);
            this.prenom_label.TabIndex = 9;
            this.prenom_label.Text = "PRENOM";
            // 
            // Adresse_label
            // 
            this.Adresse_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Adresse_label.AutoSize = true;
            this.Adresse_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Adresse_label.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse_label.Location = new System.Drawing.Point(351, 249);
            this.Adresse_label.Name = "Adresse_label";
            this.Adresse_label.Size = new System.Drawing.Size(112, 24);
            this.Adresse_label.TabIndex = 10;
            this.Adresse_label.Text = "ADRESSE";
            // 
            // ID_label
            // 
            this.ID_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_label.AutoSize = true;
            this.ID_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ID_label.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(429, 63);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(34, 24);
            this.ID_label.TabIndex = 11;
            this.ID_label.Text = "ID";
            // 
            // tele_label
            // 
            this.tele_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tele_label.AutoSize = true;
            this.tele_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tele_label.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tele_label.Location = new System.Drawing.Point(396, 319);
            this.tele_label.Name = "tele_label";
            this.tele_label.Size = new System.Drawing.Size(67, 24);
            this.tele_label.TabIndex = 12;
            this.tele_label.Text = "TELE";
            // 
            // nom_label
            // 
            this.nom_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nom_label.AutoSize = true;
            this.nom_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nom_label.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(404, 122);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(59, 24);
            this.nom_label.TabIndex = 13;
            this.nom_label.Text = "NOM";
            // 
            // input_nom
            // 
            this.input_nom.Location = new System.Drawing.Point(488, 122);
            this.input_nom.Multiline = true;
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(394, 24);
            this.input_nom.TabIndex = 14;
            this.input_nom.TextChanged += new System.EventHandler(this.input_nom_TextChanged);
            // 
            // input_tele
            // 
            this.input_tele.Location = new System.Drawing.Point(488, 319);
            this.input_tele.Multiline = true;
            this.input_tele.Name = "input_tele";
            this.input_tele.Size = new System.Drawing.Size(394, 24);
            this.input_tele.TabIndex = 15;
            this.input_tele.TextChanged += new System.EventHandler(this.input_tele_TextChanged);
            // 
            // input_adresse
            // 
            this.input_adresse.Location = new System.Drawing.Point(488, 249);
            this.input_adresse.Multiline = true;
            this.input_adresse.Name = "input_adresse";
            this.input_adresse.Size = new System.Drawing.Size(394, 24);
            this.input_adresse.TabIndex = 16;
            this.input_adresse.TextChanged += new System.EventHandler(this.input_adresse_TextChanged);
            // 
            // input_prenom
            // 
            this.input_prenom.Location = new System.Drawing.Point(488, 186);
            this.input_prenom.Multiline = true;
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(394, 24);
            this.input_prenom.TabIndex = 17;
            this.input_prenom.TextChanged += new System.EventHandler(this.input_prenom_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1173, 578);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_adresse);
            this.Controls.Add(this.input_tele);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.nom_label);
            this.Controls.Add(this.tele_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Adresse_label);
            this.Controls.Add(this.prenom_label);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delet);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.bnt_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Delet;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox ID_Box;
        private System.Windows.Forms.Label prenom_label;
        private System.Windows.Forms.Label Adresse_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label tele_label;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.TextBox input_nom;
        private System.Windows.Forms.TextBox input_tele;
        private System.Windows.Forms.TextBox input_adresse;
        private System.Windows.Forms.TextBox input_prenom;
    }
}

