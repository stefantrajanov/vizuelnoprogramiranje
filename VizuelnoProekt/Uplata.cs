using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizuelnoProekt
{
    public partial class Uplata : Form
    {

        public List<int> brojcinja { get; set; }
        public int pari { get; set; }
        public int parnost { get; set; }
        public Uplata()
        {
            InitializeComponent();
            brojcinja = new List<int>();
            pari = 0;
            parnost = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void proveriDaliETaman()
        {

            if (tbCombo.Text.Length > 0)
            {
                this.brojcinja.Clear();
                cbNeparni.Visible = false;
                cbParni.Visible = false;
                this.parnost = -1;

                if (!tbCombo.Text.Contains(','))
                {
                    errorProvider1.SetError(tbCombo, "Мора да внесете бројки разделени со запирка");
                    btnOk.Enabled = false;
                    return;
                }

                String[] trimmedText = tbCombo.Text.Split(',');



                // 11,22,33,44,55,66
                int counter = 0;
                
                for (int i = 0; i < trimmedText.Length; i++)
                {
                    if (int.TryParse(trimmedText[i].Trim(), out _))
                    {
                        int temp = int.Parse(trimmedText[i].Trim());

                        if (this.brojcinja.Contains(temp))
                        {
                            counter++;
                            continue;
                        }

                        this.brojcinja.Add(int.Parse(trimmedText[i].Trim()));
                        counter++;
                    }
                }

                if (brojcinja.Count < 6 || counter != 6)
                {
                    errorProvider1.SetError(tbCombo, "Мора да внесете точно 6 различни бројки");
                    btnOk.Enabled = false;
                }
                else
                {
                    btnOk.Enabled = true;
                    errorProvider1.Clear();
                }
            }
            else
            {
                btnOk.Enabled = true;
                cbNeparni.Visible = true;
                cbParni.Visible = true;
                errorProvider1.Clear();
            }
        }

        private void cbParni_CheckedChanged(object sender, EventArgs e)
        {
            cbNeparni.Checked = false;
            tbCombo.Enabled = false;
            this.parnost = 0;
            if (!cbParni.Checked)
            {
                tbCombo.Enabled = true;
            }
        }

        private void cbNeparni_CheckedChanged(object sender, EventArgs e)
        {
            cbParni.Checked = false;
            tbCombo.Enabled = false;
            this.parnost = 1;
            if (!cbNeparni.Checked)
            {
                tbCombo.Enabled = true;
            }
        }
        public string ResultText { get;  set; }
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool parity = false;
            List<int> brojcinja = null;
            if (cbNeparni.Checked || cbParni.Checked)
            {
                parity = true;
            }
           if(tbCombo.Text.Length > 6)
            {
                brojcinja = this.brojcinja;
            }

            Livce livce = new Livce(brojcinja, parity);


            if (brojcinja != null && brojcinja.Count > 0 && !parity)
            {
                ResultText = $"Numbers: {string.Join(", ", this.brojcinja)}";
            }
            else
            {
                ResultText = parity ? "Chosen: Even Numbers" : "Chosen: Odd Numbers";
            }


            pari = (int)this.nudPARI.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void tbCombo_TextChanged(object sender, EventArgs e)
        {
            proveriDaliETaman();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
