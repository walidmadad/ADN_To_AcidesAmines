using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADN_To_AcidesAmines
{
    public partial class ADN : Form
    {
        public ADN()
        {
            InitializeComponent();
        }

        private void convert_adn_Click(object sender, EventArgs e)
        {
            string adn_ntr = this.adn_ntr.Text.ToUpper();
            this.adn_ntr.Text = adn_ntr;
            string adn_tr = null;
            for (int x = 0; x < this.adn_ntr.Text.Length; x++)
            {
                string chara = adn_ntr.Substring(x, 1);
                switch (chara.ToUpper())
                {
                    case "A":
                        adn_tr += "T";
                        break;
                    case "T":
                        adn_tr += "A";
                        break;
                    case "G":
                        adn_tr += "C";
                        break;
                    case "C":
                        adn_tr += "G";
                        break;
                    case "-":
                        chara += " ";
                        break;
                    case " ":
                        adn_tr += " ";
                        break;
                    default:
                        erreur_adn_ntr.Text = "Erreur : Veuillez saisir une séquence d'ADN ";
                        adn_tr = null;
                        this.adn_tr.Text = null;
                        this.arn_m.Text = null;
                        if (adn_tr == null) { break; }
                        break;
                }
                if (adn_tr == null) { break; }
            }
            if (adn_tr != null)
            {
                this.adn_tr.Text = adn_tr;
                erreur_adn_ntr.Text = null;
            }
            else if (adn_tr == null) { erreur_adn_ntr.Text = "Erreur : Veuillez saisir une séquence d'ADN "; }
        }

        private void convert_arn_Click(object sender, EventArgs e)
        {
            string adn_tr = this.adn_tr.Text.ToUpper();
            this.adn_tr.Text = adn_tr;
            string arn = null;
            for (int x = 0; x < adn_tr.Length; x++)
            {
                string chara = adn_tr.Substring(x, 1);
                switch (chara)
                {
                    case "A":
                        arn += "U";
                        break;
                    case "T":
                        arn += "A";
                        break;
                    case "G":
                        arn += "C";
                        break;
                    case "C":
                        arn += "G";
                        break;
                    case "-":
                        arn += " ";
                        break;
                    case " ":
                        arn += " ";
                        break;
                    default:
                        erreur_adn_tr.Text = " Erreur : Veuillez saisir une séquence d'ADN ";
                        arn = null;
                        this.arn_m.Text = null;
                        if (arn == null) { break; }
                        break;
                }
                if (arn == null) { break; }
            }
            if (arn != null)
            {
                this.arn_m.Text = arn;
                erreur_adn_tr.Text = null;
            }
            else if (arn == null) { erreur_adn_tr.Text = "Erreur : Veuillez saisir une séquence d'ADN "; }
        }

        private void convert_acides_Click(object sender, EventArgs e)
        {
            this.erreur_arn.Text = null;
            this.acides.Text = null;
            string arn_m = this.arn_m.Text.ToUpper();
            this.arn_m.Text = arn_m;
            string acides = null;
            string chara = null;
            int x = 0;
            while (x < arn_m.Length)
            {
                string cha = arn_m.Substring(x, 1);
                switch (cha)
                {
                    case "-":
                        chara += null;
                        break;
                    case " ":
                        chara += null;
                        break;
                    case "U":
                        chara += cha;
                        break;
                    case "G":
                        chara += cha;
                        break;
                    case "C":
                        chara += cha;
                        break;
                    case "A":
                        chara += cha;
                        break;
                    default:
                        this.erreur_arn.Text = " Erreur : Veuillez saisir une séquence d'ARN ";
                        chara = "";
                        acides = null;
                        x = arn_m.Length;
                        break;
                }
                if (chara.Length == 3)
                {

                    if (chara == "UUU" || chara == "UUC")
                    {
                        acides += "Phe-";
                    }
                    else if (chara == "UUA" || chara == "UUG" || chara == "CUU" || chara == "CUC" || chara == "CUA" || chara == "CUG")
                    {
                        acides += "Leu-";
                    }
                    else if (chara == "AUU" || chara == "AUC" || chara == "AUA")
                    {
                        acides += "Ile-";
                    }
                    else if (chara == "AUG")
                    {
                        acides += "Met-";
                    }
                    else if (chara == "GUU" || chara == "GUC" || chara == "GUA" || chara == "GUG")
                    {
                        acides += "Val-";
                    }
                    else if (chara == "UCA" || chara == "UCG" || chara == "UCU" || chara == "UCC" || chara == "AGU" || chara == "AGC")
                    {
                        acides += "Ser-";
                    }
                    else if (chara == "CCU" || chara == "CCC" || chara == "CCG" || chara == "CCA")
                    {
                        acides += "Pro-";
                    }
                    else if (chara == "ACU" || chara == "ACG" || chara == "ACA" || chara == "ACC")
                    {
                        acides += "Thr-";
                    }
                    else if (chara == "GCU" || chara == "GCA" || chara == "GCC" || chara == "GCG")
                    {
                        acides += "Ala-";
                    }
                    else if (chara == "UAU" || chara == "UAC")
                    {
                        acides += "Tyr-";
                    }
                    else if (chara == "CAU" || chara == "CAC")
                    {
                        acides += "His-";
                    }
                    else if (chara == "CAA" || chara == "CAG")
                    {
                        acides += "Gln-";
                    }
                    else if (chara == "AAU" || chara == "AAC")
                    {
                        acides += "Asn-";
                    }
                    else if (chara == "AAA" || chara == "AAG")
                    {
                        acides += "Lys-";
                    }
                    else if (chara == "GAU" || chara == "GAC")
                    {
                        acides += "Asp-";
                    }
                    else if (chara == "GAA" || chara == "GAG")
                    {
                        acides += "Glu-";
                    }                    
                    else if (chara == "UGU" || chara == "UGC")
                    {
                        acides += "Cys-";
                    }
                    else if (chara == "UGG")
                    {
                        acides += "Trp-";
                    }
                    else if (chara == "CGU" || chara == "CGC" || chara == "CGA" || chara == "CGG" || chara == "AGA" || chara == "AGG")
                    {
                        acides += "Arg-";
                    }
                    else if (chara == "GGU" || chara == "GGC" || chara == "GGA" || chara == "GGG")
                    {
                        acides += "Gly-";
                    }
                    else if (chara == "UAA" || chara == "UAG" || chara == "UGA")
                    {
                        acides += "STOP";
                    }
                    else
                    {
                        this.erreur_arn.Text = " Erreur : Veuillez saisir une séquence d'ARN ";
                        acides = null;
                    }
                    chara = null;
                }
                x++;
            }
            if (acides != null)
            {
                acides = acides.Remove(acides.Length - 1);
                this.acides.Text = acides;
            }
            else { this.erreur_arn.Text = " Erreur : Veuillez saisir une séquence d'ARN "; }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            adn_ntr.Text = null;
            adn_tr.Text = null;
            arn_m.Text = null;
            acides.Text = null;
            erreur_adn_ntr.Text = null;
            erreur_adn_tr.Text = null;
            erreur_arn.Text = null;
        }
    }
}
