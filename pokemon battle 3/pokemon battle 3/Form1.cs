namespace pokemon_battle_3
{
    public partial class Form1 : Form
    {
        Pikachu pikachu;
        Bayleef bayleef;
        Parasect parasect;
        Machamp machamp;
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
            machamp = new Machamp();

            pokemondex[0] = pikachu;
            pokemondex[1] = bayleef;
            pokemondex[2] = parasect;

            enemydex[0] = machamp;
        }

        private void diaplayPokemon()
        {
            this.pictureBox1.Image = pokemondex[0].getImage();
            this.labelPokemon.Text = pokemondex[0].getName();
            this.pictureBox2.Image = pokemondex[1].getImage();
            this.pictureBox3.Image = pokemondex[2].getImage();

            this.pictureBox7.Image = enemydex[0].getImage();

            this.textBoxHP.Text = pokemondex[0].getHP().ToString();
            this.textBoxATK.Text = pokemondex[0].getATK().ToString();
            this.textBoxDEF.Text = pokemondex[0].getDEF().ToString();
            this.textBoxSPEED.Text = pokemondex[0].getSPEED().ToString();

            this.textBoxEnemyHP.Text = enemydex[0].getHP().ToString();
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
            Image temp = this.pictureBox1.Image;
            this.pictureBox1.Image = this.pictureBox3.Image;
            this.pictureBox3.Image = temp;
        }

        private void button_switch3_Click(object sender, EventArgs e)
        {

        }

        private void button_switch4_Click(object sender, EventArgs e)
        {

        }

        private void button_switch5_Click(object sender, EventArgs e)
        {

        }

        private void buttonATK_Click(object sender, EventArgs e)
        {
            int damage = pokemondex[0].getATK();
            int newHP = enemydex[0].getHP() - damage;
            enemydex[0].setHP(newHP);

            if(enemydex[0].getHP() <= 0)
            {
                enemydex[0].setHP(0);
             
            }

            diaplayPokemon();
        }
    }
}