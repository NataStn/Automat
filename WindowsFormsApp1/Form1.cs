using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Predmet trik1 = new Predmet(90);
        Predmet trik2 = new Predmet(90);
        Predmet trik3 = new Predmet(90);
        Predmet cokolada1 = new Predmet(60);
        Predmet cokolada2 = new Predmet(60);
        Predmet cokolada3 = new Predmet(60);
        Predmet voda1 = new Predmet(100);
        Predmet voda2 = new Predmet(100);
        Predmet voda3 = new Predmet(100);
        Predmet mleko1 = new Predmet(45);
        Predmet mleko2 = new Predmet(45);
        Predmet mleko3 = new Predmet(45);
        int uneto = 0;
        Kasa kasa = new Kasa();

        private void pet_Click(object sender, EventArgs e)
        {
            kasa.pet ++;
            uneto += 5;
        }

        private void deset_Click(object sender, EventArgs e)
        {
            kasa.deset++;
            uneto += 10;
        }

        private void dvadeset_Click(object sender, EventArgs e)
        {
            kasa.dvadeset++;
            uneto += 20;
        }

        private void pedeset_Click(object sender, EventArgs e)
        {
            kasa.pedeset++;
            uneto += 50;
        }

        private void sto_Click(object sender, EventArgs e)
        {
            kasa.sto++;
            uneto += 100;
        }

        private void dvesta_Click(object sender, EventArgs e)
        {
            kasa.dvesta++;
            uneto += 200;
        }

        private void jedan_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                trik1.cena = 90;
            }
            else
            {
                trik1.cena = 80;
            }
            if (uneto <= trik1.cena)
            {
                trik1.broj[0]--;
                if (trik1.broj[0] == 0)
                {
                    grisine1.Visible = false;
                    uneto -= trik1.cena;
                }
                if(trik1.broj[0] == 1)
                {
                    grisine2.Visible = false;
                    uneto -= trik1.cena;
                }
                if(trik1.broj[0] == 2)
                {
                    grisine3.Visible = false;
                    uneto -= trik1.cena;
                }
            }
        }

        private void dva_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                cokolada1.cena = 60;
            }
            else
            {
                cokolada1.cena = 50;
            }
            if (uneto <= cokolada1.cena)
            {
                trik1.broj[1]--;
                if (trik1.broj[1] == 0)
                {
                    snickers1.Visible = false;
                    uneto -= cokolada1.cena;
                }
                if (trik1.broj[1] == 1)
                {
                    snickers2.Visible = false;
                    uneto -= cokolada1.cena;
                }
                if (trik1.broj[1] == 2)
                {
                    snickers3.Visible = false;
                    uneto -= cokolada1.cena;
                }
            }
        }

        private void tri_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                voda1.cena = 90;
            }
            else
            {
                voda1.cena = 100;
            }
            if (uneto <= voda1.cena)
            {
                trik1.broj[2]--;
                if (trik1.broj[2] == 0)
                {
                    hidro1.Visible = false;
                    uneto -= voda1.cena;
                }
                if (trik1.broj[2] == 1)
                {
                    hidro2.Visible = false;
                    uneto -= voda1.cena;
                }
                if (trik1.broj[2] == 2)
                {
                    hidro3.Visible = false;
                    uneto -= voda1.cena;
                }
            }
        }

        private void cetiri_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                mleko1.cena = 30;
            }
            else
            {
                mleko1.cena = 45;
            }
            if (uneto <= mleko1.cena)
            {
                trik1.broj[3]--;
                if (trik1.broj[3] == 0)
                {
                    coko1.Visible = false;
                    uneto -= mleko1.cena;
                }
                if (trik1.broj[3] == 1)
                {
                    coko2.Visible = false;
                    uneto -= mleko1.cena;
                }
                if (trik1.broj[3] == 2)
                {
                    coko3.Visible = false;
                    uneto -= mleko1.cena;
                }
            }
        }

        private void kusur_Click(object sender, EventArgs e)
        {
            while (uneto != 0)
            {
                if ((uneto > 200) && (kasa.dvesta > 0))
                {
                    kasa.dvesta--;
                    uneto -= 200;
                }
                else if ((uneto > 100) && (kasa.sto > 0))
                {
                    kasa.sto--;
                    uneto -= 100;
                }
                else if ((uneto > 50) && (kasa.pedeset > 0))
                {
                    kasa.pedeset--;
                    uneto -= 50;
                }
                else if ((uneto > 20) && (kasa.dvadeset > 0))
                {
                    kasa.dvadeset--;
                    uneto -= 20;
                }
                else if ((uneto > 10) && (kasa.deset > 0))
                {
                    kasa.deset--;
                    uneto -= 10;
                }
                else if ((uneto > 5) && (kasa.pet > 0))
                {
                    kasa.pet--;
                    uneto -= 5;
                }
            }
        }

        private void dodajGrisine_Click(object sender, EventArgs e)
        {
            if (sifraGrisine.Text == "0701")
            {
                trik1.broj[0]++;
                if (trik1.broj[0] == 1)
                {
                    grisine1.Visible = true;
                }
                if (trik1.broj[0] == 2)
                {
                    grisine2.Visible = true;
                }
                if (trik1.broj[0] == 3)
                {
                    grisine3.Visible = true;
                }
            }
        }

        private void dodajSnickers_Click(object sender, EventArgs e)
        {
            if (sifraSnickers.Text == "0701")
            {
                trik1.broj[1]++;
                if (trik1.broj[1] == 1)
                {
                    snickers1.Visible = true;
                }
                if (trik1.broj[1] == 2)
                {
                    snickers2.Visible = true;
                }
                if (trik1.broj[1] == 3)
                {
                    snickers3.Visible = true;
                }
            }
        }

        private void dodajHidro_Click(object sender, EventArgs e)
        {
            if (sifraHidro.Text == "0701")
            {
                trik1.broj[2]++;
                if (trik1.broj[2] == 1)
                {
                    hidro1.Visible = true;
                }
                if (trik1.broj[2] == 2)
                {
                    hidro2.Visible = true;
                }
                if (trik1.broj[2] == 3)
                {
                    hidro3.Visible = true;
                }
            }
        }

        private void dodajCoko_Click(object sender, EventArgs e)
        {
            if (sifraCoko.Text == "0701")
            {
                trik1.broj[3]++;
                if (trik1.broj[3] == 1)
                {
                    coko1.Visible = true;
                }
                if (trik1.broj[3] == 2)
                {
                    coko2.Visible = true;
                }
                if (trik1.broj[3] == 3)
                {
                    coko3.Visible = true;
                }
            }
        }
    }
}
class Predmet
{
    public int cena;
    public int[] broj = { 3, 3, 3, 3 };
    public Predmet(int cena)
    {
        this.cena = cena;
    }
}
class Kasa
{
    public int pet = 100;
    public int deset = 100;
    public int dvadeset = 100;
    public int pedeset = 100;
    public int sto = 100;
    public int dvesta = 100;
}
