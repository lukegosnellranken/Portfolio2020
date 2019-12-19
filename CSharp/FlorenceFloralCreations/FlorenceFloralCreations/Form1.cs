using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlorenceFloralCreations
{
    public partial class FormFlorence : Form
    {
        public FormFlorence()
        {
            InitializeComponent();
        }

        string[][] flowers =
        {
            new string[] {"Chrysanthemum", "Daffodils", "Iris", "Rose", "Tulip"},
            new string[] {"Daisies", "Gladiolus", "Lily", "Orchids", "Rose"},
            new string[] {"Carnation", "Chrysanthemum", "Gladiolus", "Lily", "Rose"},
            new string[] {"Daisies", "Peonies", "White Lily", "White Roses"}
        };

        private void FormFlorence_Load(object sender, EventArgs e)
        {
            labelGoodChoice.Visible = false;
            listBoxChoice.Items.Clear();
            listBoxChoice.ClearSelected();
            //pictureBox1.Image = null;
            imageSelection();
        }

        private void listBoxOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxChoice.Items.Clear();
            imageSelection();
            showCorrectListBoxInfo();
        }

        private void listBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelGoodChoice.Visible = true;
        }

        private void imageSelection()
        {
            if (this.listBoxOccasion.Text == "")
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\lukeg\Desktop\AWD 1100\csharpexercisesnew\Chapter13\FlorenceFloralCreations\FlorenceFloralCreations\Resources\florence.jpg");
            }
            else if (this.listBoxOccasion.Text == "Anniversary")
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\lukeg\Desktop\AWD 1100\csharpexercisesnew\Chapter13\FlorenceFloralCreations\FlorenceFloralCreations\Resources\anniversary.jpg");
            }
            else if (this.listBoxOccasion.Text == "Birthday")
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\lukeg\Desktop\AWD 1100\csharpexercisesnew\Chapter13\FlorenceFloralCreations\FlorenceFloralCreations\Resources\birthday.jpg");
            }
            else if (this.listBoxOccasion.Text == "Funeral")
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\lukeg\Desktop\AWD 1100\csharpexercisesnew\Chapter13\FlorenceFloralCreations\FlorenceFloralCreations\Resources\funeral.jpg");
            }
            else if (this.listBoxOccasion.Text == "Get Well")
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\lukeg\Desktop\AWD 1100\csharpexercisesnew\Chapter13\FlorenceFloralCreations\FlorenceFloralCreations\Resources\getwell.jpg");
            }
        }

        private void showCorrectListBoxInfo()
        {
            for (int x = 0; x < listBoxOccasion.Items.Count; ++x)
            {
                if (listBoxOccasion.GetSelected(x))
                {
                    for (int y = 0; y < flowers[x].Length; ++y)
                    {
                        listBoxChoice.Items.Add(flowers[x][y]);
                    }
                }
            }
        }
    }
}
