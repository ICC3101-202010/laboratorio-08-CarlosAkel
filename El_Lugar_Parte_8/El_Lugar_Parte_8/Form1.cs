using El_Lugar_Parte_8.Eventos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Lugar_Parte_8
{
    public partial class Form1 : Form
    {
        public event EventHandler SaveIdCine;
        public delegate List<int> IdEventHandler(object source, EventArgs e);
        public event IdEventHandler GetAllId;
        public delegate bool IdEventHandler2(object source, Local_EventArgs args);
        public event IdEventHandler2 IdCheck;

        public delegate bool CinemaEventHandler(object source,Cinea_EventArgs args);
        public event CinemaEventHandler CreateNewCinema;
        public delegate bool ShopEventHandler(object source, Shop_EventArgs args);
        public event ShopEventHandler CreateNewShop;
        public delegate bool RestaurantEventHandler(object source, Restaurant_EventArgs args);
        public event RestaurantEventHandler CreateNewRestaurant;
        public delegate bool RecreationEventHandler(object source, Recreation_EventArgs args);
        public event RecreationEventHandler CreateRecreation;


        public delegate List<Cine> CineEventHandler(object source, EventArgs e);
        public event CineEventHandler GetCine;
        public delegate List<Tienda> TiendaEventHandler(object source, EventArgs e);
        public event TiendaEventHandler GetShop;
        public delegate List<Recreacion> RecreacionEventHandler(object source, EventArgs e);
        public event RecreacionEventHandler GetRecreation;
        public delegate List<Restaurante> RestauranteEventHandler(object source, EventArgs e);
        public event RestauranteEventHandler GetRestaurant;



        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Titulo.Parent = panel_Inicio;
            Titulo.BackColor = Color.Transparent;
 
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void Crear_Locales_Click(object sender, EventArgs e)
        {

        }

        private void Create_Restaurant_Click(object sender, EventArgs e)
        {

        }

        private void Create_Cinema_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Local_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Create_Cinema_Click_1(object sender, EventArgs e)
        {
            Creating_Cinema.Visible = true;
        }

        private void Cinema_Create_Final_Click(object sender, EventArgs e)
        {
            
            bool pass;
            bool pass2;
            int id = 0;
            int.TryParse(Id_Cinema.Text, out id);
            int rooms = 0;
            int.TryParse(Rooms_Cinema.Text, out rooms);
            if(id == 0)
            {
                MessageBox.Show("You cant type those charecters", "ERROR ID", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(rooms == 0)
            {
                MessageBox.Show("You cant type those charecters", "ERROR ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Owner_Cinema.Text == "")
            {
                MessageBox.Show("Enter a Name Please", "NAME ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Id_Cinema.Text == "")
            {
                MessageBox.Show("Enter an Id Please", "ID ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Hours_Cinema.Text == "")
            {
                MessageBox.Show("Enter an Schedule Please", "SCHEDULES ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pass2 = IdCheck(this, new Local_EventArgs() { id = id });
                if(pass2 == true)
                {
                    pass = CreateNewCinema(this, new Cinea_EventArgs() { name = Owner_Cinema.Text, id = id, schedules = Hours_Cinema.SelectedItem.ToString(), rooms = rooms });
                }
                else
                {
                    pass = false;
                }
                
                
                if (pass == false)
                {
                    MessageBox.Show("The Local id already exist");
                }
                else
                {
                    Owner_Cinema.Text = "";
                    Id_Cinema.Text = "";
                    Rooms_Cinema.Text = "";
                    Hours_Cinema.Text = "";
                    MessageBox.Show("Cinema Succefully Created");

                }
            }

            
            

        }

        private void CreateNewCin_Return_Click(object sender, EventArgs e)
        {
            Creating_Cinema.Visible = false;
        }

        private void Create_Shop_Click(object sender, EventArgs e)
        {
            Creating_Cinema.Visible = true;
            Creating_Shop.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Creating_Shop.Visible = false;
            Creating_Cinema.Visible = false;

        }

        private void CreateShopFinal_Click(object sender, EventArgs e)
        {
            bool checker = true;
            bool pass;
            bool pass2;
            
            int id = 0;
            int.TryParse(Id_Shop.Text, out id);

            List<string> cate = new List<string>();
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                //MessageBox.Show("No se a seleccionado ninguna canción");
                MessageBox.Show("There is no Selected Category", "SELECCION ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Owner_Shop.Text == "")
            {
                MessageBox.Show("Enter a Name Please", "NAME ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Id_Shop.Text == "")
            {
                MessageBox.Show("Enter an Id Please", "ID ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Hours_Shop.Text == "")
            {
                MessageBox.Show("Enter an Schedule Please", "SCHEDULES ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string item in checkedListBox1.CheckedItems)
                {
                    cate.Add(item);
                }
                if (id == 0)
                {
                    MessageBox.Show("You cant type those charecters", "ERROR ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker = false;
                }

                if (checker == true)
                {
                    pass2 = IdCheck(this, new Local_EventArgs() { id = id });
                    if(pass2 == true)
                    {
                        pass = CreateNewShop(this, new Shop_EventArgs() { name = Owner_Shop.Text, id = id, schedules = Hours_Shop.SelectedItem.ToString(), categories = cate });
                    }
                    else
                    {
                        pass = false;
                    }

                    if (pass == false)
                    {
                        MessageBox.Show("The Local id already exist");
                    }
                    else
                    {
                        Owner_Shop.Text = "";
                        Id_Shop.Text = "";
                        Hours_Shop.Text = "";
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            checkedListBox1.SetItemChecked(i, false);
                        }

                        MessageBox.Show("Shop Succefully Created");
                    }
                }
            }



        }

        private void CreateRestaurantFinal_Click(object sender, EventArgs e)
        {
            bool checker = true;
            bool pass;
            bool pass2;

            int id = 0;
            int.TryParse(Id_Restaurant.Text, out id);

            if (Owner_Restaurant.Text == "")
            {
                MessageBox.Show("Enter a Name Please", "NAME ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Id_Restaurant.Text == "")
            {
                MessageBox.Show("Enter an Id Please", "ID ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Hour_Restaurant.Text == "")
            {
                MessageBox.Show("Enter an Schedule Please", "SCHEDULES ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (id == 0)
                {
                    MessageBox.Show("You cant type those charecters", "ERROR ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker = false;
                }

                if (checker == true)
                {
                    pass2 = IdCheck(this, new Local_EventArgs() { id = id });
                    if (pass2 == true)
                    {
                        pass = CreateNewRestaurant(this, new Restaurant_EventArgs() {name = Owner_Restaurant.Text,id = id,schedules = Hour_Restaurant.Text,exclusive = checkBox1.Checked });
                       
                    }
                    else
                    {
                        pass = false;
                    }

                    if (pass == false)
                    {
                        MessageBox.Show("The Local id already exist");
                    }
                    else
                    {
                        Owner_Restaurant.Text = "";
                        Id_Restaurant.Text = "";
                        Hour_Restaurant.Text = "";
                        checkBox1.Checked = false;

                        MessageBox.Show("Shop Succefully Created");
                    }
                }
            }

        }

        private void Create_Restaurant_Click_1(object sender, EventArgs e)
        {
            Creating_Cinema.Visible = true;
            Creating_Shop.Visible = true;
            Creating_Restaurant.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Creating_Cinema.Visible = false;
            Creating_Shop.Visible = false;
            Creating_Restaurant.Visible = false;
        }

        private void Create_Recration_Click(object sender, EventArgs e)
        {
            Creating_Cinema.Visible = true;
            Creating_Shop.Visible = true;
            Creating_Restaurant.Visible = true;
            Creating_Recreation.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Creating_Cinema.Visible = false;
            Creating_Shop.Visible = false;
            Creating_Restaurant.Visible = false;
            Creating_Recreation.Visible = false;
        }

        private void CreateRecreationFinal_Click(object sender, EventArgs e)
        {
            bool checker = true;
            bool pass;
            bool pass2;

            int id = 0;
            int.TryParse(Id_Recreation.Text, out id);

            if (Owner_Recreation.Text == "")
            {
                MessageBox.Show("Enter a Name Please", "NAME ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Id_Recreation.Text == "")
            {
                MessageBox.Show("Enter an Id Please", "ID ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Hour_Recreation.Text == "")
            {
                MessageBox.Show("Enter an Schedule Please", "SCHEDULES ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (id == 0)
                {
                    MessageBox.Show("You cant type those charecters", "ERROR ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checker = false;
                }

                if (checker == true)
                {
                    pass2 = IdCheck(this, new Local_EventArgs() { id = id });
                    if (pass2 == true)
                    {
                        pass = CreateRecreation(this, new Recreation_EventArgs() { name = Owner_Recreation.Text, id = id, schedules = Hour_Recreation.Text });

                    }
                    else
                    {
                        pass = false;
                    }

                    if (pass == false)
                    {
                        MessageBox.Show("The Local id already exist");
                    }
                    else
                    {
                        Owner_Recreation.Text = "";
                        Id_Recreation.Text = "";
                        Hour_Recreation.Text = "";

                        MessageBox.Show("Shop Succefully Created");
                    }
                }
            }
        }


        List<int> position = new List<int>();
        List<string> horarios = new List<string>();
        
        private void label11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void View_Local_Click(object sender, EventArgs e)
        {
            position.Clear();
            horarios.Clear();
            List<string> remove = new List<string>();
            if(Locales.Items.Count > 0)
            {
                foreach(string item in Locales.Items)
                {
                    remove.Add(item);
                }
            }
            if(remove.Count > 0)
            {
                foreach(string item in remove)
                {
                    Locales.Items.Remove(item);
                }
            }


            panel1.Visible = true;
            Creating_Cinema.Visible = true;
            Creating_Shop.Visible = true;
            Creating_Restaurant.Visible = true;
            Creating_Recreation.Visible = true;
            View_Local_Page.Visible = true;

            List <Tienda> shop= GetShop(this,new EventArgs());
            List <Cine> cinema = GetCine(this, new EventArgs());
            List <Recreacion> recreation= GetRecreation(this, new EventArgs());
            List <Restaurante> restaurant = GetRestaurant(this, new EventArgs());
            if (shop.Count != 0)
            {
                foreach (Tienda t in shop)
                {
                    Locales.Items.Add("Shop Name: " + t.get_Name2());
                    position.Add(t.get_id());
                    horarios.Add(t.get_Schedules2());
                }
            }
            if (cinema.Count != 0)
            {
                foreach (Cine c in cinema)
                {
                    Locales.Items.Add("Cinema Name: " + c.get_Name2());
                    position.Add(c.get_id());
                    horarios.Add(c.get_Schedules2());
                }
            }

            if (recreation.Count != 0)
            {
                foreach (Recreacion rec in recreation)
                {
 
                    Locales.Items.Add("Recreation Name: " + rec.get_Name2());
                    position.Add(rec.get_id());
                    horarios.Add(rec.get_Schedules2());
                }
            }
            if(restaurant.Count != 0)
            {
                foreach (Restaurante res in restaurant)
                {

                    Locales.Items.Add("Restaurant Name: " + res.get_Name2());
                    position.Add(res.get_id());
                    horarios.Add(res.get_Schedules2());
                }
            }

        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Creating_Cinema.Visible = false;
            Creating_Shop.Visible = false;
            Creating_Restaurant.Visible = false;
            Creating_Recreation.Visible = false;
            View_Local_Page.Visible = false;
        }
        int num = 0;
        List<Label> remobeLab = new List<Label>();
        private void Locales_TextChanged(object sender, EventArgs e)
        {
            
            if(remobeLab.Count > 0)
            {
                foreach(Label item in remobeLab)
                {
                    panel2.Controls.Remove(item);
                }
                remobeLab.Clear();
            }


            for(int i=0; i< Locales.Items.Count; i++)
            {
                if(Locales.Items[i].ToString() == Locales.Text)
                {
                    num = i;
                }
            }

            List<Tienda> shop = GetShop(this, new EventArgs());
            List<Cine> cinema = GetCine(this, new EventArgs());
            List<Recreacion> recreation = GetRecreation(this, new EventArgs());
            List<Restaurante> restaurant = GetRestaurant(this, new EventArgs());

            if (shop.Count != 0)
            {
                foreach (Tienda t in shop)
                {
                    if(t.get_id() == position[num])
                    {
                        Label l = new Label();
                        Label aux = new Label();
                        string p = "";
                        l.Location = new Point(50, 50);
                        l.Width = 500;
                        foreach (string item in t.get_cat())
                        {
                            p += " "+item;
                        }
                        l.Text = "Local: "+ t.get_Name2() + " Id: " + t.get_id() + " Schedules: " + t.get_Schedules2();
                        l.Font = new Font("Limelight", 12 ,FontStyle.Bold);
                        panel2.Controls.Add(l);

                        aux.Text = "Categories:" + p;
                        aux.Location = new Point(50, 100);
                        aux.Width = 500;
                        aux.Font = new Font("Limelight", 12, FontStyle.Bold);
                        panel2.Controls.Add(aux);
                        remobeLab.Add(l);
                        remobeLab.Add(aux);
                    }

                }
            }
            if (cinema.Count != 0)
            {
                foreach (Cine c in cinema)
                {
                    if (c.get_id() == position[num])
                    {
                        Label l = new Label();
                        Label aux = new Label();
                        l.Location = new Point(50, 50);
                        l.Width = 500;
                        l.Text = "Local: " + c.get_Name2() + " Id: " + c.get_id() + " Schedules: " + c.get_Schedules2();
                        l.Font = new Font("Limelight", 12, FontStyle.Bold);
                        panel2.Controls.Add(l);
                        aux.Text = "Rooms: "+ c.room().ToString();
                        aux.Location = new Point(50, 100);
                        aux.Width = 500;
                        aux.Font = new Font("Limelight", 12, FontStyle.Bold);
                        panel2.Controls.Add(aux);
                        remobeLab.Add(l);
                        remobeLab.Add(aux);
                    }
                }
            }

            if (recreation.Count != 0)
            {
                foreach (Recreacion rec in recreation)
                {
                    if (rec.get_id() == position[num])
                    {
                        Label l = new Label();
                        Label aux = new Label();
                        l.Location = new Point(50, 50);
                        l.Width = 500;
                        l.Text = "Local: " + rec.get_Name2() + " Id: " + rec.get_id() + " Schedules: " + rec.get_Schedules2();
                        l.Font = new Font("Limelight", 12, FontStyle.Bold);
                        panel2.Controls.Add(l);
                        aux.Text = " ";
                        aux.Location = new Point(50, 100);
                        aux.Width = 500;
                        aux.Font = new Font("Limelight", 12, FontStyle.Bold);
                        panel2.Controls.Add(aux);
                        remobeLab.Add(l);
                        remobeLab.Add(aux);
                    }
                }
            }
            if (restaurant.Count != 0)
            {
                foreach (Restaurante res in restaurant)
                {
                    if (res.get_id() == position[num])
                    {
                        Label l = new Label();
                        Label aux = new Label();
                        l.Location = new Point(50, 50);
                        l.Width = 500;
                        l.Text = "Local: " + res.get_Name2() + " Id: " + res.get_id() + " Schedules: " + res.get_Schedules2();
                        l.Font = new Font("Limelight", 12, FontStyle.Bold);
                        panel2.Controls.Add(l);
                        aux.Text = "Exclusive Tables: " + res.Ex().ToString();
                        aux.Location = new Point(50, 100);
                        aux.Width = 500;
                        aux.Font = new Font("Limelight", 12, FontStyle.Bold);
                        panel2.Controls.Add(aux);
                        remobeLab.Add(l);
                        remobeLab.Add(aux);
                    }
                }
            }





        }
        List<string> RemoveList35 = new List<string>();
        private void Local_List_Click(object sender, EventArgs e)
        {
            if (RemoveList35.Count > 0)
            {
                foreach (string item in RemoveList35)
                {
                    listBox1.Items.Remove(item);
                }
            }




            List<Tienda> shop = GetShop(this, new EventArgs());
            List<Cine> cinema = GetCine(this, new EventArgs());
            List<Recreacion> recreation = GetRecreation(this, new EventArgs());
            List<Restaurante> restaurant = GetRestaurant(this, new EventArgs());
            if (shop.Count != 0)
            {
                foreach (Tienda t in shop)
                {
                    listBox1.Items.Add("Local:   " + t.get_Name2() + " ID: " + t.get_id());
                    RemoveList35.Add("Local:   " + t.get_Name2() + " ID: " + t.get_id());
                }
            }
            if (cinema.Count != 0)
            {
                foreach (Cine c in cinema)
                {
                    listBox1.Items.Add("Local:   " + c.get_Name2() + " ID: " + c.get_id());
                    RemoveList35.Add("Local:   " + c.get_Name2() + " ID: " + c.get_id());
                }
            }

            if (recreation.Count != 0)
            {
                foreach (Recreacion rec in recreation)
                {
                    listBox1.Items.Add("Local:   " + rec.get_Name2() + " ID: " + rec.get_id());
                    RemoveList35.Add("Local:   " + rec.get_Name2() + " ID: " + rec.get_id());
                }
            }
            if (restaurant.Count != 0)
            {
                foreach (Restaurante res in restaurant)
                {

                    listBox1.Items.Add("Local:   " + res.get_Name2() + " ID: " + res.get_id());
                    RemoveList35.Add("Local:   " + res.get_Name2() + " ID: " + res.get_id());
                }
            }

            panel1.Visible = true;
            Creating_Cinema.Visible = true;
            Creating_Shop.Visible = true;
            Creating_Restaurant.Visible = true;
            Creating_Recreation.Visible = true;
            View_Local_Page.Visible = true;
            Mirar_List_Final.Visible = true;


        }


        private void label18_Click(object sender, EventArgs e)
        {




            panel1.Visible = false;
            Creating_Cinema.Visible = false;
            Creating_Shop.Visible = false;
            Creating_Restaurant.Visible = false;
            Creating_Recreation.Visible = false;
            View_Local_Page.Visible = false;
            Mirar_List_Final.Visible = false;


        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
