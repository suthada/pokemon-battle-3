namespace pokemon_battle_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_switch1_Click(object sender, EventArgs e)
        {
            Image temp = this.pictureBox1.Image;
            this.pictureBox1.Image = this.pictureBox2.Image;
            this.pictureBox2.Image = temp;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            this.labelPokemon.Text = pikachu.getName();
            this.pictureBox1.Image = pikachu.getImage();

            Parasect parasect = new Parasect();
            this.pictureBox2.Image = parasect.getImage();

            Quagsire quagsire = new Quagsire();
            this.pictureBox3.Image = quagsire.getImage();

        }

        private void button_switch1_Click_1(object sender, EventArgs e)
        {
            Image temp = this.pictureBox1.Image;
            this.pictureBox1.Image = this.pictureBox2.Image;
            this.pictureBox2.Image = temp;
        }

        private void button_switch2_Click(object sender, EventArgs e)
        {
            //Image temp = this.pictureBox1.Image;
            //this.pictureBox1.Image = this.pictureBox2.Image;
            //this.pictureBox2.Image = temp;
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
    }
}