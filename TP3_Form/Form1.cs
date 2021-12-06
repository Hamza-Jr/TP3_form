
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Form
{
    public partial class Form1 : Form
    {
        #region CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region button methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vouler vous annuler l'evenement ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Vider(this);
               
                
                ID_Box.Enabled = false;
                bnt_Add.Enabled = true;
                btn_Save.Enabled = false;
                btn_cancel.Enabled = false;
                input_nom.Enabled = false;
                input_prenom.Enabled = false;
                input_adresse.Enabled = false;
                input_tele.Enabled = false;
            }
        }

        private void btn_Delet_Click(object sender, EventArgs e)
        {
            Supprimer();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Modifier();
        }

        private void bnt_Add_Click(object sender, EventArgs e)
        {
            bnt_Add.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            input_nom.Enabled = true;
            input_prenom.Enabled = true;
            input_adresse.Enabled = true;
            input_tele.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Ajouter();
            dropdownlist.Items.Clear();
            adapter.Fill(ds, "DATAUSER");
            for (int i = 0; i < ds.Tables["DATAUSER"].Rows.Count; i++)
            {
                dropdownlist.Items.Add(ds.Tables["datauser"].Rows[i][0]);
            }
        }
        #endregion

        #region input user
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ID_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < ds.Tables["DATAUSER"].Rows.Count; i++)
            {
                if (dropdownlist.SelectedItem.Equals(ds.Tables["datauser"].Rows[i][0]))
                {
                    nomInput.Text = ds.Tables["datauser"].Rows[i][1].ToString();
                    prenomInput.Text = ds.Tables["datauser"].Rows[i][2].ToString();
                    adresseInput.Text = ds.Tables["datauser"].Rows[i][3].ToString();
                    break;
                }
            }
            //SelectData();

            AjouterBtn.Enabled = false;
            ModifierBtn.Enabled = true;
            SupprimerBtn.Enabled = true;
            nomInput.Enabled = false;
            prenomInput.Enabled = false;
            adresseInput.Enabled = false;
        }
        private void input_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_tele_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods de traitment
        /// <summary>
        ///  pour vider les champs utiliser method Vider
        /// </summary>
        /// <param name="test"></param>
        public void Vider(Control test)
        {
            foreach (Control ct in test.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.Controls.Count != 0)
                    Vider(ct);
            }
        }

        /// <summary>
        /// function pour confirmer les differents types des events
        /// </summary>
        private void Confirmer()
        {
            DialogResult confirm = MessageBox.Show("Confirm to close ?", "Confirmation", MessageBoxButtons.YesNo);
            DialogResult message = MessageBox.Show("Donnees enregistrees", "Succes", MessageBoxButtons.OK);
            if (confirm == DialogResult.Yes)
            {
                if (message == DialogResult.OK)
                {
                    Vider(this);
                    ID_Box.Enabled = true;
                    bnt_Add.Enabled = true;
                    btn_Save.Enabled = false;
                    btn_Delet.Enabled = false;
                    btn_Edit.Enabled = false;
                    btn_cancel.Enabled = false;
                    input_nom.Enabled = false;
                    input_prenom.Enabled = false;
                    input_adresse.Enabled = false;
                    input_tele.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erreur", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Ajouter utilisateur avec verification de champs sont pas vide
        /// </summary>
        private void Ajouter()
        {
            if (input_nom.Text == "" || input_prenom.Text == "" || input_adresse.Text == "" || input_tele.Text == "")
            {
                MessageBox.Show("Voulez vous remplir les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //switch between func============================>>
                UpdateData();
                //InsertData();
                Confirmer();

            }
        }

        private void Modifier()
        {
            bnt_Add.Enabled = false;
            btn_Delet.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Save.Enabled = true;
            btn_cancel.Enabled = true;
            ID_Box.Enabled = false;
            input_nom.Enabled = true;
            input_prenom.Enabled = true;
            input_adresse.Enabled = true;
            input_tele.Enabled = true;
        }

        private void Supprimer()
        {
            ID_Box.Enabled = true;
            bnt_Add.Enabled = false;
            btn_Delet.Enabled = false;
            btn_Save.Enabled = false;
            btn_Edit.Enabled = false;
            btn_cancel.Enabled = false;
            input_nom.Enabled = false;
            input_prenom.Enabled = false;
            input_adresse.Enabled = false;
            input_tele.Enabled = false;
            DialogResult deletperson = MessageBox.Show("Vouler vous supprimer ?", "Confirmation", MessageBoxButtons.YesNo);
            if (deletperson == DialogResult.Yes )
            {
                DeleteData();
                //dropdownlist.Items.Remove(dropdownlist.SelectedItem);
                bnt_Add.Enabled = true;
                btn_Delet.Enabled = false;
                btn_Save.Enabled = false;
                btn_cancel.Enabled = false;
                ID_Box.Enabled = true;
                input_nom.Enabled = false;
                input_prenom.Enabled = false;
                input_tele.Enabled = false;
            }


        }



        #endregion

        #region SqlMethods
        /// <summary>
        /// inserer les donnees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InsertData()
        {
            try
            {
                cnx.Open();
                OracleCommand cmd = new OracleCommand("insertUser", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("nom", OracleDbType.Varchar2).Value = nomInput.Text;
                cmd.Parameters.Add("prenom", OracleDbType.Varchar2).Value = prenomInput.Text;
                cmd.Parameters.Add("adresse", OracleDbType.Varchar2).Value = adresseInput.Text;
                cmd.ExecuteNonQuery();
                // MessageBox.Show("donnee inseree");        
            }
            catch
            {
                MessageBox.Show("ERREUR");
            }
            cnx.Close();
        }
        /// <summary>
        /// modifier donnees
        /// </summary>
        public void UpdateData()
        {
            cnx.Open();
            OracleCommand cmd = new OracleCommand("updateUser", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id_user", OracleDbType.Int32).Value = Convert.ToInt32(dropdownlist.SelectedItem);
            cmd.Parameters.Add("nom", OracleDbType.Varchar2).Value = nomInput.Text;
            cmd.Parameters.Add("prenom", OracleDbType.Varchar2).Value = prenomInput.Text;
            cmd.Parameters.Add("adresse", OracleDbType.Varchar2).Value = adresseInput.Text;
            cmd.ExecuteNonQuery();
            //MessageBox.Show("donnee est modifiee");
            cnx.Close();
        }
        /// <summary>
        /// supprimer les donnees
        /// </summary>
        public void DeleteData()
        {
            cnx.Open();
            OracleCommand cmd = new OracleCommand("deleteUser", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id_user", OracleDbType.Int32).Value = Convert.ToInt32(dropdownlist.SelectedItem);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("person est supprime");
            cnx.Close();
        }
        #endregion
    }
}
