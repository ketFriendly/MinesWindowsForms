using PogadjanjeMinaWinForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PogadjanjeMinaWinForms
{
    public partial class PogadjanjeMina : Form
    {
        int maksimalanBrojMina = 10;
        int brojGenerisanihMina = 0;
        Random randomBroj = new Random();
        int brojPokusaja = 0;
        int maksimalanBrojPokusaja = 20;
        int maksimalanBrojPogodaka = 10;
        int trenutniRezultatPogodaka = 0;

        // inicijalizovati matricu:
        // 0 - znaci da je polje slobodno
        // 1 - znaci da je na toj koordinati mina
        // 2 - znaci da je mina pogodjena
        // 3 - znaci da je mina promasena
        int[,] matrica = new int[10, 10];

        public PogadjanjeMina()
        {
            InitializeComponent();
            InicijalizujZnakovePitanjaZaSvakoDugme();
            InicijalizacijaMatrice();
        }

        private void InicijalizacijaMatrice()
        {
            // generisi polja gde se nalaze mine
            // za ovo je potrebno dve for petlje, jedna za redove, druga za kolone
            for (int i = 0; i < 10; i++) // for petlja za redove
            {
                for (int j = 0; j < 10; j++) // for petlja za kolone
                {
                    int generisanBroj = randomBroj.Next(0, 2); // generise random broj 0 ili 1

                    if (generisanBroj == 1) // ako je generisan broj 1 povecati brojGenerisanihMina za 1, maksimalan broj mina je 10
                    {
                        brojGenerisanihMina++;
                    }

                    matrica[i, j] = generisanBroj; // dodeliti matrici generisan broj

                    if (brojGenerisanihMina == maksimalanBrojMina) // proveriti da li je broj generisanih mina jednak maksimalnom dozvoljenom broju mina, ako jeste izaci iz druge petlje
                    {
                        break; // izadji iz druge petlje
                    }
                }

                if (brojGenerisanihMina == maksimalanBrojMina) // proveriti da li je broj generisanih mina jednak maksimalnom dozvoljenom broju mina, ako jeste izaci iz prve petlje
                {
                    break; // izadji iz prve petlje
                }
            }
        }

        private void InicijalizujZnakovePitanjaZaSvakoDugme()
        {
            this.btn1_1.BackgroundImage = Resources.znakpitanja;
            this.btn1_2.BackgroundImage = Resources.znakpitanja;
            this.btn1_3.BackgroundImage = Resources.znakpitanja;
            this.btn1_4.BackgroundImage = Resources.znakpitanja;
            this.btn1_5.BackgroundImage = Resources.znakpitanja;
            this.btn1_6.BackgroundImage = Resources.znakpitanja;
            this.btn1_7.BackgroundImage = Resources.znakpitanja;
            this.btn1_8.BackgroundImage = Resources.znakpitanja;
            this.btn1_9.BackgroundImage = Resources.znakpitanja;
            this.btn1_10.BackgroundImage = Resources.znakpitanja;

            this.btn2_1.BackgroundImage = Resources.znakpitanja;
            this.btn2_2.BackgroundImage = Resources.znakpitanja;
            this.btn2_3.BackgroundImage = Resources.znakpitanja;
            this.btn2_4.BackgroundImage = Resources.znakpitanja;
            this.btn2_5.BackgroundImage = Resources.znakpitanja;
            this.btn2_6.BackgroundImage = Resources.znakpitanja;
            this.btn2_7.BackgroundImage = Resources.znakpitanja;
            this.btn2_8.BackgroundImage = Resources.znakpitanja;
            this.btn2_9.BackgroundImage = Resources.znakpitanja;
            this.btn2_10.BackgroundImage = Resources.znakpitanja;

            this.btn3_1.BackgroundImage = Resources.znakpitanja;
            this.btn3_2.BackgroundImage = Resources.znakpitanja;
            this.btn3_3.BackgroundImage = Resources.znakpitanja;
            this.btn3_4.BackgroundImage = Resources.znakpitanja;
            this.btn3_5.BackgroundImage = Resources.znakpitanja;
            this.btn3_6.BackgroundImage = Resources.znakpitanja;
            this.btn3_7.BackgroundImage = Resources.znakpitanja;
            this.btn3_8.BackgroundImage = Resources.znakpitanja;
            this.btn3_9.BackgroundImage = Resources.znakpitanja;
            this.btn3_10.BackgroundImage = Resources.znakpitanja;

            this.btn4_1.BackgroundImage = Resources.znakpitanja;
            this.btn4_2.BackgroundImage = Resources.znakpitanja;
            this.btn4_3.BackgroundImage = Resources.znakpitanja;
            this.btn4_4.BackgroundImage = Resources.znakpitanja;
            this.btn4_5.BackgroundImage = Resources.znakpitanja;
            this.btn4_6.BackgroundImage = Resources.znakpitanja;
            this.btn4_7.BackgroundImage = Resources.znakpitanja;
            this.btn4_8.BackgroundImage = Resources.znakpitanja;
            this.btn4_9.BackgroundImage = Resources.znakpitanja;
            this.btn4_10.BackgroundImage = Resources.znakpitanja;

            this.btn5_1.BackgroundImage = Resources.znakpitanja;
            this.btn5_2.BackgroundImage = Resources.znakpitanja;
            this.btn5_3.BackgroundImage = Resources.znakpitanja;
            this.btn5_4.BackgroundImage = Resources.znakpitanja;
            this.btn5_5.BackgroundImage = Resources.znakpitanja;
            this.btn5_6.BackgroundImage = Resources.znakpitanja;
            this.btn5_7.BackgroundImage = Resources.znakpitanja;
            this.btn5_8.BackgroundImage = Resources.znakpitanja;
            this.btn5_9.BackgroundImage = Resources.znakpitanja;
            this.btn5_10.BackgroundImage = Resources.znakpitanja;

            this.btn6_1.BackgroundImage = Resources.znakpitanja;
            this.btn6_2.BackgroundImage = Resources.znakpitanja;
            this.btn6_3.BackgroundImage = Resources.znakpitanja;
            this.btn6_4.BackgroundImage = Resources.znakpitanja;
            this.btn6_5.BackgroundImage = Resources.znakpitanja;
            this.btn6_6.BackgroundImage = Resources.znakpitanja;
            this.btn6_7.BackgroundImage = Resources.znakpitanja;
            this.btn6_8.BackgroundImage = Resources.znakpitanja;
            this.btn6_9.BackgroundImage = Resources.znakpitanja;
            this.btn6_10.BackgroundImage = Resources.znakpitanja;

            this.btn7_1.BackgroundImage = Resources.znakpitanja;
            this.btn7_2.BackgroundImage = Resources.znakpitanja;
            this.btn7_3.BackgroundImage = Resources.znakpitanja;
            this.btn7_4.BackgroundImage = Resources.znakpitanja;
            this.btn7_5.BackgroundImage = Resources.znakpitanja;
            this.btn7_6.BackgroundImage = Resources.znakpitanja;
            this.btn7_7.BackgroundImage = Resources.znakpitanja;
            this.btn7_8.BackgroundImage = Resources.znakpitanja;
            this.btn7_9.BackgroundImage = Resources.znakpitanja;
            this.btn7_10.BackgroundImage = Resources.znakpitanja;

            this.btn8_1.BackgroundImage = Resources.znakpitanja;
            this.btn8_2.BackgroundImage = Resources.znakpitanja;
            this.btn8_3.BackgroundImage = Resources.znakpitanja;
            this.btn8_4.BackgroundImage = Resources.znakpitanja;
            this.btn8_5.BackgroundImage = Resources.znakpitanja;
            this.btn8_6.BackgroundImage = Resources.znakpitanja;
            this.btn8_7.BackgroundImage = Resources.znakpitanja;
            this.btn8_8.BackgroundImage = Resources.znakpitanja;
            this.btn8_9.BackgroundImage = Resources.znakpitanja;
            this.btn8_10.BackgroundImage = Resources.znakpitanja;

            this.btn9_1.BackgroundImage = Resources.znakpitanja;
            this.btn9_2.BackgroundImage = Resources.znakpitanja;
            this.btn9_3.BackgroundImage = Resources.znakpitanja;
            this.btn9_4.BackgroundImage = Resources.znakpitanja;
            this.btn9_5.BackgroundImage = Resources.znakpitanja;
            this.btn9_6.BackgroundImage = Resources.znakpitanja;
            this.btn9_7.BackgroundImage = Resources.znakpitanja;
            this.btn9_8.BackgroundImage = Resources.znakpitanja;
            this.btn9_9.BackgroundImage = Resources.znakpitanja;
            this.btn9_10.BackgroundImage = Resources.znakpitanja;

            this.btn10_1.BackgroundImage = Resources.znakpitanja;
            this.btn10_2.BackgroundImage = Resources.znakpitanja;
            this.btn10_3.BackgroundImage = Resources.znakpitanja;
            this.btn10_4.BackgroundImage = Resources.znakpitanja;
            this.btn10_5.BackgroundImage = Resources.znakpitanja;
            this.btn10_6.BackgroundImage = Resources.znakpitanja;
            this.btn10_7.BackgroundImage = Resources.znakpitanja;
            this.btn10_8.BackgroundImage = Resources.znakpitanja;
            this.btn10_9.BackgroundImage = Resources.znakpitanja;
            this.btn10_10.BackgroundImage = Resources.znakpitanja;
        }

        private bool PogodiMinu(int x, int y)
        {
            lblBrojPokusaja.Text = string.Format("Broj pokušaja: {0}", ++brojPokusaja);

            // kada su koordinate uspesno unesene
            // proveriti da li mina postoji na datoj koordinati x,y
            if (matrica[x, y] == 1) // ovo je pogodak
            {
                matrica[x, y] = 2; // posto je na tom polju pogodjena mina, postaviti vrednost polja na koordinati [x,y] na 2

                if (++trenutniRezultatPogodaka == maksimalanBrojPogodaka)
                {
                    MessageBox.Show("POBEDA, uspesno ste pogodili sve mine.", "POBEDA");
                }

                return true;
            }
            else
            {
                matrica[x, y] = 3;
                return false;
            }
        }

        private bool DaLiJeMinaVecPromasena(int x, int y)
        {
            if (matrica[x, y] == 3)
            {
                return true;
            }

            return false;
        }

        private bool DaLiJeMinaVecPogodjena(int x, int y)
        {
            if (matrica[x, y] == 2)
            {
                return true;
            }

            return false;
        }

        private bool DaLiJeIgraZavrsena()
        {
            if (brojPokusaja == maksimalanBrojPokusaja)
            {
                MessageBox.Show("IZGUBILI STE, dostigli ste maksimalan broj pokušaja za pogađanje", "IZGUBILI STE");
                return true;
            }

            return false;
        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 0))
            {
                return;
            }

            if (PogodiMinu(0, 0) == true)
            {
                btn1_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 1))
            {
                return;
            }

            if (PogodiMinu(0, 1) == true)
            {
                btn1_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 2))
            {
                return;
            }

            if (PogodiMinu(0, 2) == true)
            {
                btn1_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn1_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 3))
            {
                return;
            }

            if (PogodiMinu(0, 3) == true)
            {
                btn1_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn1_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 4))
            {
                return;
            }

            if (PogodiMinu(0, 4) == true)
            {
                btn1_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn1_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 5))
            {
                return;
            }

            if (PogodiMinu(0, 5) == true)
            {
                btn1_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn1_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 6))
            {
                return;
            }

            if (PogodiMinu(0, 6) == true)
            {
                btn1_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn1_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 7))
            {
                return;
            }

            if (PogodiMinu(0, 7) == true)
            {
                btn1_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn1_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 8))
            {
                return;
            }

            if (PogodiMinu(0, 8) == true)
            {
                btn1_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn1_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(0, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(0, 9))
            {
                return;
            }

            if (PogodiMinu(0, 9) == true)
            {
                btn1_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn1_10.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 0))
            {
                return;
            }

            if (PogodiMinu(1, 0) == true)
            {
                btn2_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 1))
            {
                return;
            }

            if (PogodiMinu(1, 1) == true)
            {
                btn2_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 2))
            {
                return;
            }

            if (PogodiMinu(1, 2) == true)
            {
                btn2_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 3))
            {
                return;
            }

            if (PogodiMinu(1, 3) == true)
            {
                btn2_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 4))
            {
                return;
            }

            if (PogodiMinu(1, 4) == true)
            {
                btn2_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 5))
            {
                return;
            }

            if (PogodiMinu(1, 5) == true)
            {
                btn2_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 6))
            {
                return;
            }

            if (PogodiMinu(1, 6) == true)
            {
                btn2_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 7))
            {
                return;
            }

            if (PogodiMinu(1, 7) == true)
            {
                btn2_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 8))
            {
                return;
            }

            if (PogodiMinu(1, 8) == true)
            {
                btn2_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn2_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(1, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(1, 9))
            {
                return;
            }

            if (PogodiMinu(1, 9) == true)
            {
                btn2_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn2_10.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 0))
            {
                return;
            }

            if (PogodiMinu(2, 0) == true)
            {
                btn3_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 1))
            {
                return;
            }

            if (PogodiMinu(2, 1) == true)
            {
                btn3_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 2))
            {
                return;
            }

            if (PogodiMinu(2, 2) == true)
            {
                btn3_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 3))
            {
                return;
            }

            if (PogodiMinu(2, 3) == true)
            {
                btn3_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 4))
            {
                return;
            }

            if (PogodiMinu(2, 4) == true)
            {
                btn3_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 5))
            {
                return;
            }

            if (PogodiMinu(2, 5) == true)
            {
                btn3_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 6))
            {
                return;
            }

            if (PogodiMinu(2, 6) == true)
            {
                btn3_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 7))
            {
                return;
            }

            if (PogodiMinu(2, 7) == true)
            {
                btn3_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 8))
            {
                return;
            }

            if (PogodiMinu(2, 8) == true)
            {
                btn3_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn3_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(2, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(2, 9))
            {
                return;
            }

            if (PogodiMinu(2, 9) == true)
            {
                btn3_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn3_10.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 0))
            {
                return;
            }

            if (PogodiMinu(3, 0) == true)
            {
                btn4_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 1))
            {
                return;
            }

            if (PogodiMinu(3, 1) == true)
            {
                btn4_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 2))
            {
                return;
            }

            if (PogodiMinu(3, 2) == true)
            {
                btn4_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 3))
            {
                return;
            }

            if (PogodiMinu(3, 3) == true)
            {
                btn4_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 4))
            {
                return;
            }

            if (PogodiMinu(3, 4) == true)
            {
                btn4_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 5))
            {
                return;
            }

            if (PogodiMinu(3, 5) == true)
            {
                btn4_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 6))
            {
                return;
            }

            if (PogodiMinu(3, 6) == true)
            {
                btn4_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 7))
            {
                return;
            }

            if (PogodiMinu(3, 7) == true)
            {
                btn4_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 8))
            {
                return;
            }

            if (PogodiMinu(3, 8) == true)
            {
                btn4_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn4_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(3, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(3, 9))
            {
                return;
            }

            if (PogodiMinu(3, 9) == true)
            {
                btn4_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn4_10.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 0))
            {
                return;
            }

            if (PogodiMinu(4, 0) == true)
            {
                btn5_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 1))
            {
                return;
            }

            if (PogodiMinu(4, 1) == true)
            {
                btn5_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 2))
            {
                return;
            }

            if (PogodiMinu(4, 2) == true)
            {
                btn5_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 3))
            {
                return;
            }

            if (PogodiMinu(4, 3) == true)
            {
                btn5_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 4))
            {
                return;
            }

            if (PogodiMinu(4, 4) == true)
            {
                btn5_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 5))
            {
                return;
            }

            if (PogodiMinu(4, 5) == true)
            {
                btn5_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 6))
            {
                return;
            }

            if (PogodiMinu(4, 6) == true)
            {
                btn5_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 7))
            {
                return;
            }

            if (PogodiMinu(4, 7) == true)
            {
                btn5_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 8))
            {
                return;
            }

            if (PogodiMinu(4, 8) == true)
            {
                btn5_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn5_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(4, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(4, 9))
            {
                return;
            }

            if (PogodiMinu(4, 9) == true)
            {
                btn5_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn5_10.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 0))
            {
                return;
            }

            if (PogodiMinu(5, 0) == true)
            {
                btn6_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 1))
            {
                return;
            }

            if (PogodiMinu(5, 1) == true)
            {
                btn6_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 2))
            {
                return;
            }

            if (PogodiMinu(5, 2) == true)
            {
                btn6_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 3))
            {
                return;
            }

            if (PogodiMinu(5, 3) == true)
            {
                btn6_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 4))
            {
                return;
            }

            if (PogodiMinu(5, 4) == true)
            {
                btn6_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 5))
            {
                return;
            }

            if (PogodiMinu(5, 5) == true)
            {
                btn6_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 6))
            {
                return;
            }

            if (PogodiMinu(5, 6) == true)
            {
                btn6_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 7))
            {
                return;
            }

            if (PogodiMinu(5, 7) == true)
            {
                btn6_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 8))
            {
                return;
            }

            if (PogodiMinu(5, 8) == true)
            {
                btn6_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn6_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(5, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(5, 9))
            {
                return;
            }

            if (PogodiMinu(5, 9) == true)
            {
                btn6_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn6_10.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 0))
            {
                return;
            }

            if (PogodiMinu(6, 0) == true)
            {
                btn7_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 1))
            {
                return;
            }

            if (PogodiMinu(6, 1) == true)
            {
                btn7_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 2))
            {
                return;
            }

            if (PogodiMinu(6, 2) == true)
            {
                btn7_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 3))
            {
                return;
            }

            if (PogodiMinu(6, 3) == true)
            {
                btn7_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 4))
            {
                return;
            }

            if (PogodiMinu(6, 4) == true)
            {
                btn7_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 5))
            {
                return;
            }

            if (PogodiMinu(6, 5) == true)
            {
                btn7_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 6))
            {
                return;
            }

            if (PogodiMinu(6, 6) == true)
            {
                btn7_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 7))
            {
                return;
            }

            if (PogodiMinu(6, 7) == true)
            {
                btn7_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 8))
            {
                return;
            }

            if (PogodiMinu(6, 8) == true)
            {
                btn7_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn7_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(6, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(6, 9))
            {
                return;
            }

            if (PogodiMinu(6, 9) == true)
            {
                btn7_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn7_10.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 0))
            {
                return;
            }

            if (PogodiMinu(7, 0) == true)
            {
                btn8_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 1))
            {
                return;
            }

            if (PogodiMinu(7, 1) == true)
            {
                btn8_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 2))
            {
                return;
            }

            if (PogodiMinu(7, 2) == true)
            {
                btn8_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 3))
            {
                return;
            }

            if (PogodiMinu(7, 3) == true)
            {
                btn8_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 4))
            {
                return;
            }

            if (PogodiMinu(7, 4) == true)
            {
                btn8_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 5))
            {
                return;
            }

            if (PogodiMinu(7, 5) == true)
            {
                btn8_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 6))
            {
                return;
            }

            if (PogodiMinu(7, 6) == true)
            {
                btn8_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 7))
            {
                return;
            }

            if (PogodiMinu(7, 7) == true)
            {
                btn8_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 8))
            {
                return;
            }

            if (PogodiMinu(7, 8) == true)
            {
                btn8_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn8_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(7, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(7, 9))
            {
                return;
            }

            if (PogodiMinu(7, 9) == true)
            {
                btn8_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn8_10.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 0))
            {
                return;
            }

            if (PogodiMinu(8, 0) == true)
            {
                btn9_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 1))
            {
                return;
            }

            if (PogodiMinu(8, 1) == true)
            {
                btn9_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 2))
            {
                return;
            }

            if (PogodiMinu(8, 2) == true)
            {
                btn9_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 3))
            {
                return;
            }

            if (PogodiMinu(8, 3) == true)
            {
                btn9_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 4))
            {
                return;
            }

            if (PogodiMinu(8, 4) == true)
            {
                btn9_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 5))
            {
                return;
            }

            if (PogodiMinu(8, 5) == true)
            {
                btn9_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 6))
            {
                return;
            }

            if (PogodiMinu(8, 6) == true)
            {
                btn9_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 7))
            {
                return;
            }

            if (PogodiMinu(8, 7) == true)
            {
                btn9_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 8))
            {
                return;
            }

            if (PogodiMinu(8, 8) == true)
            {
                btn9_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn9_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(8, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(8, 9))
            {
                return;
            }

            if (PogodiMinu(8, 9) == true)
            {
                btn9_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn9_10.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_1_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 0))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 0))
            {
                return;
            }

            if (PogodiMinu(9, 0) == true)
            {
                btn10_1.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_1.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_2_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 1))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 1))
            {
                return;
            }

            if (PogodiMinu(9, 1) == true)
            {
                btn10_2.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_2.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_3_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 2))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 2))
            {
                return;
            }

            if (PogodiMinu(9, 2) == true)
            {
                btn10_3.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_3.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_4_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 3))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 3))
            {
                return;
            }

            if (PogodiMinu(9, 3) == true)
            {
                btn10_4.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_4.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_5_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 4))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 4))
            {
                return;
            }

            if (PogodiMinu(9, 4) == true)
            {
                btn10_5.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_5.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_6_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 5))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 5))
            {
                return;
            }

            if (PogodiMinu(9, 5) == true)
            {
                btn10_6.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_6.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_7_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 6))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 6))
            {
                return;
            }

            if (PogodiMinu(9, 6) == true)
            {
                btn10_7.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_7.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_8_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 7))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 7))
            {
                return;
            }

            if (PogodiMinu(9, 7) == true)
            {
                btn10_8.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_8.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_9_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 8))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 8))
            {
                return;
            }

            if (PogodiMinu(9, 8) == true)
            {
                btn10_9.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_9.BackgroundImage = Resources.promasaj;
            }
        }

        private void btn10_10_Click(object sender, EventArgs e)
        {
            if (DaLiJeIgraZavrsena())
            {
                return;
            }

            if (DaLiJeMinaVecPromasena(9, 9))
            {
                return;
            }

            if (DaLiJeMinaVecPogodjena(9, 9))
            {
                return;
            }

            if (PogodiMinu(9, 9) == true)
            {
                btn10_10.BackgroundImage = Resources.mina;
            }
            else
            {
                btn10_10.BackgroundImage = Resources.promasaj;
            }
        }
    }
}
