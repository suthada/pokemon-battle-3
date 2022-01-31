namespace pokemon_battle_3
{
    public partial class Form1 : Form
    {
        Pikachu pikachu;
        Bayleef bayleef;
        Parasect parasect;
        Machamp machamp;
        Chansey chansey;
        Quagsire quagsire;
        Snorlax snorlax;
        ///Array of pokemon
        Pokemon[] pokemondex;
        Pokemon[] enemydex;
        public Form1()
        {
            InitializeComponent();
            pokemondex = new Pokemon[6];
            enemydex = new Pokemon[6];

            pikachu = new Pikachu();
            bayleef = new Bayleef();
            parasect = new Parasect();
            chansey = new Chansey();
            quagsire = new Quagsire();
            snorlax = new Snorlax();

            machamp = new Machamp();

            pokemondex[0] = pikachu;
            pokemondex[1] = bayleef;
            pokemondex[2] = parasect;
            pokemondex[3] = chansey;
            pokemondex[4] = quagsire;
            pokemondex[5] = snorlax;

            enemydex[0] = machamp;
        }

        private void diaplayPokemon()
        {
            this.pictureBox1.Image = pokemondex[0].getImage();
            this.labelPokemon.Text = pokemondex[0].getName();
            this.pictureBox2.Image = pokemondex[1].getImage();
            this.pictureBox3.Image = pokemondex[2].getImage();
            this.pictureBox4.Image = pokemondex[3].getImage();
            this.pictureBox5.Image = pokemondex[4].getImage();
            this.pictureBox6.Image = pokemondex[5].getImage();

            this.pictureBox7.Image = enemydex[0].getImage();

            this.textBoxHP.Text = pokemondex[0].getHP().ToString();
            this.textBoxATK.Text = pokemondex[0].getATK().ToString();
            this.textBoxDEF.Text = pokemondex[0].getDEF().ToString();
            this.textBoxSPEED.Text = pokemondex[0].getSPEED().ToString();

            this.textBoxEnmyHP.Text = enemydex[0].getHP().ToString();
            
   
            this.buttonATK.Enabled = pokemondex[0].getHP() > 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            diaplayPokemon();

        }

        private void button_switch1_Click_1(object sender, EventArgs e)
        {

            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[1];
            pokemondex[1] = temp;

            diaplayPokemon();
        }

        private void button_switch2_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[2];
            pokemondex[2] = temp;

            diaplayPokemon(); ;
        }

        private void button_switch3_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[3];
            pokemondex[3] = temp;

            diaplayPokemon();
        }

        private void button_switch4_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[4];
            pokemondex[4] = temp;

            diaplayPokemon();
        }

        private void button_switch5_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[5];
            pokemondex[5] = temp;

            diaplayPokemon();
        }

        private void buttonATK_Click(object sender, EventArgs e)
        {
            pokemondex[0].attackPokemon(ref enemydex[0]);

            enemydex[0].attackPokemon(ref pokemondex[0]);

            diaplayPokemon();
        }
    }
}