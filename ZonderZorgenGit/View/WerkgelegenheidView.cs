using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZonderZorgenGit.Controller;

namespace ZonderZorgenGit.View
{
    public partial class WerkgelegenheidView : Form
    {
        private WerkgelegenheidController werkgelegenheidController;
        private ConnectionController mainConnection;

        public WerkgelegenheidView(WerkgelegenheidController werkgelegenheidControllerP, ConnectionController connectionControllerP)
        {
            this.werkgelegenheidController = werkgelegenheidControllerP;
            this.mainConnection = connectionControllerP;
            InitializeComponent();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardController dashboardController = new DashboardController(this.mainConnection);
            
            this.Close();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked != true && radioButton2.Checked != true && radioButton3.Checked != true && radioButton4.Checked)
            {
                MessageBox.Show("Selecteer een jaartal");
            }
            else
            {
                List<string> query = new List<string>();
                List<string> query2 = new List<string>();
                List<string> whereClause = new List<string>();

                if (radioButton1.Checked == true)
                {
                    query.Add("totaal_financieringsbronnen_2011");
                    if (checkBox1.Checked == true)
                    {
                        query.Add("Totaal_zorg_en_welzijn");
                        query2.Add("totaal_aanbieders_zorg_en_welzijn_2011");
                    };
                    if (checkBox2.Checked == true)
                    {
                        query.Add("Geneeskundige_en_angdurige_zorg");
                        query2.Add("totaal_geneeskundige_langd_zorg_2011");
                    };
                    if (checkBox3.Checked == true)
                    {
                        query.Add("Welzijn_jeugdzorg_en_kinderopvang");
                        query2.Add("totaal_welzijn_jeugdzorg_kinderop_2011");
                    };
                    if (checkBox4.Checked == true)
                    {
                        query.Add("Beleid_en_beheer");
                        query2.Add("beleids_en_beheerorganisaties_2011");
                    };
                    if (checkBox6.Checked == true)
                    {
                        whereClause.Add("artsen_en_tandartsen");
                    };
                    if (checkBox5.Checked == true)
                    {
                        whereClause.Add("verpleegkundige");
                    };
                    if (checkBox7.Checked == true)
                    {
                        whereClause.Add("overige_medische_beroepen");
                    };
                    if (checkBox8.Checked == true)
                    {
                        whereClause.Add("overige_beroepen_in_zorg_en_welzijn");
                    };

                };
                if (radioButton2.Checked == true)
                {
                    query.Add("totaal_financieringsbronnen_2012");
                    if (checkBox1.Checked == true)
                    {
                        query.Add("Totaal_zorg_en_welzijn");
                        query2.Add("totaal_aanbieders_zorg_en_welzijn_2012");
                    };
                    if (checkBox2.Checked == true)
                    {
                        query.Add("Geneeskundige_en_angdurige_zorg");
                        query2.Add("totaal_geneeskundige_langd_zorg_2012");
                    };
                    if (checkBox3.Checked == true)
                    {
                        query.Add("Welzijn_jeugdzorg_en_kinderopvang");
                        query2.Add("totaal_welzijn_jeugdzorg_kinderop_2012");
                    };
                    if (checkBox4.Checked == true)
                    {
                        query.Add("Beleid_en_beheer");
                        query2.Add("beleids_en_beheerorganisaties_2012");
                    };
                    if (checkBox6.Checked == true)
                    {
                        whereClause.Add("artsen_en_tandartsen");
                    };
                    if (checkBox5.Checked == true)
                    {
                        whereClause.Add("verpleegkundige");
                    };
                    if (checkBox7.Checked == true)
                    {
                        whereClause.Add("overige_medische_beroepen");
                    };
                    if (checkBox8.Checked == true)
                    {
                        whereClause.Add("overige_beroepen_in_zorg_en_welzijn");
                    };
                };
                if (radioButton3.Checked == true)
                {
                    query.Add("totaal_financieringsbronnen_2013");
                    if (checkBox1.Checked == true)
                    {
                        query.Add("Totaal_zorg_en_welzijn");
                        query2.Add("totaal_aanbieders_zorg_en_welzijn_2013");
                    };
                    if (checkBox2.Checked == true)
                    {
                        query.Add("Geneeskundige_en_angdurige_zorg");
                        query2.Add("totaal_geneeskundige_langd_zorg_2013");
                    };
                    if (checkBox3.Checked == true)
                    {
                        query.Add("Welzijn_jeugdzorg_en_kinderopvang");
                        query2.Add("totaal_welzijn_jeugdzorg_kinderop_2013");
                    };
                    if (checkBox4.Checked == true)
                    {
                        query.Add("Beleid_en_beheer");
                        query2.Add("beleids_en_beheerorganisaties_2013");
                    };
                    if (checkBox6.Checked == true)
                    {
                        whereClause.Add("artsen_en_tandartsen");
                    };
                    if (checkBox5.Checked == true)
                    {
                        whereClause.Add("verpleegkundige");
                    };
                    if (checkBox7.Checked == true)
                    {
                        whereClause.Add("overige_medische_beroepen");
                    };
                    if (checkBox8.Checked == true)
                    {
                        whereClause.Add("overige_beroepen_in_zorg_en_welzijn");
                    };
                    if (checkBox1.Checked != true && checkBox2.Checked != true && checkBox3.Checked != true && checkBox4.Checked != true)
                    {
                        MessageBox.Show("Kies een categorie");

                    };
                    if (checkBox5.Checked != true && checkBox6.Checked != true && checkBox7.Checked != true && checkBox8.Checked != true)
                    {
                        MessageBox.Show("Kies een beroep");

                    };
                };
                if (radioButton4.Checked == true)
                {
                    query.Add("totaal_financieringsbronnen_2014");
                    if (checkBox1.Checked == true)
                    {
                        query.Add("Totaal_zorg_en_welzijn");
                        query2.Add("totaal_aanbieders_zorg_en_welzijn_2014");
                    };
                    if (checkBox2.Checked == true)
                    {
                        query.Add("Geneeskundige_en_angdurige_zorg");
                        query2.Add("totaal_geneeskundige_langd_zorg_2014");
                    };
                    if (checkBox3.Checked == true)
                    {
                        query.Add("Welzijn_jeugdzorg_en_kinderopvang");
                        query2.Add("totaal_welzijn_jeugdzorg_kinderop_2014");
                    };
                    if (checkBox4.Checked == true)
                    {
                        query.Add("Beleid_en_beheer");
                        query2.Add("beleids_en_beheerorganisaties_2014");
                    };
                    if (checkBox6.Checked == true)
                    {
                        whereClause.Add("artsen_en_tandartsen");
                    };
                    if (checkBox5.Checked == true)
                    {
                        whereClause.Add("verpleegkundige");
                    };
                    if (checkBox7.Checked == true)
                    {
                        whereClause.Add("overige_medische_beroepen");
                    };
                    if (checkBox8.Checked == true)
                    {
                        whereClause.Add("overige_beroepen_in_zorg_en_welzijn");
                    };
                    if (checkBox4.Checked != true && checkBox1.Checked != true && checkBox2.Checked != true && checkBox3.Checked != true)
                    {
                        MessageBox.Show("Kies een categorie");

                    };
                    if (checkBox5.Checked != true && checkBox6.Checked != true && checkBox7.Checked != true && checkBox8.Checked != true)
                    {
                        MessageBox.Show("Kies een beroep");

                    };
                };

                for (int i = 0; i < query.Count; i++)
                {
                    MessageBox.Show(query[i]);
                }
                for (int i = 0; i < query2.Count; i++)
                {
                    MessageBox.Show(query2[i]);
                }
                for (int i = 0; i < whereClause.Count; i++)
                {
                    MessageBox.Show(whereClause[i]);
                }
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OverBtn_Click(object sender, EventArgs e)
        {
            using (Over Over = new Over())
            {
                Over.ShowDialog(this);
            }
        }
    }
}
