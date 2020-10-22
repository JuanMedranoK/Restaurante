using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurante
{
    // JUAN CARLOS MEDRANO 2018-7214
    public partial class Orden1 : Form
    {
        public int? mesaIndex;
        public int? ordenescantidad;
        private readonly SerializationService serializationService = new SerializationService();
        List<String> listaordenes = new List<String>();
        private const string OrderDirectory= "Orders";
        private const string OrderFileName= "orders.dat";

        

        public Orden1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            entrada entrada = new entrada(cboEntrada.SelectedItem.ToString());
            bebida bebida = new bebida(cbobebida.SelectedItem.ToString());
            platofuerte platofuerte = new platofuerte(cboplatofuerte.SelectedItem.ToString());
            postre postre = new postre(cbopostre.SelectedItem.ToString());
            Orders order = new Orders(txtNombre.Text, entrada, platofuerte, bebida, postre);
            order.TableIndex = mesaIndex.Value;
            var deserializeOrder = (List<Orders>)serializationService.Deserialize(OrderDirectory, OrderFileName);
            var orders = Repositorio.Instancia.orders;

            if (deserializeOrder != null)
            {
                orders = deserializeOrder ?? new List<Orders>();
            }
            if (lboOrdenes.Items.Count != ordenescantidad.Value)
            {
                orders.Add(order);
                var indexOder = orders.IndexOf(order);
                lboOrdenes.BeginUpdate();
                serializationService.Serialize(orders, OrderDirectory, OrderFileName);
                for (int i = 0; i < 1; i++)
                {
                    lboOrdenes.Items.Add($"Nombre { orders[indexOder].Name} Entrada {orders[indexOder].Entry.Nombre} " +
                                         $" Plato Fuerte {orders[indexOder].Dish.Nombre} Bebida {orders[i].Drinks.Nombre} Postre {orders[indexOder].Dessert.Nombre}");

                }
                lboOrdenes.EndUpdate();
                txtNombre.Text = "";
                cbobebida.SelectedIndex = 0;
                cboEntrada.SelectedIndex = 0;
                cboplatofuerte.SelectedIndex = 0;
                cbopostre.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show($"Usted ha excedido el limite de pedidos", "Ordenes");
            }
        }

        private void Orden1_Load(object sender, EventArgs e)
        {
            llenarListas();
            var orderDeserialize = (List<Orders>)serializationService.Deserialize(OrderDirectory, OrderFileName);
            var orders = Repositorio.Instancia.orders;
            orders = orderDeserialize ?? new List<Orders>();

            lboOrdenes.BeginUpdate();
            lboOrdenes.Items.Clear();
            if (orders != null)
            {
                for (int i = 0; i < orders.Count; i++)
                {
                    if (orders[i].TableIndex == mesaIndex.Value)
                    {

                        lboOrdenes.Items.Add($"Nombre { orders[i].Name} Entrada {orders[i].Entry.Nombre} " +
                                          $" Plato Fuerte {orders[i].Dish.Nombre} Bebida {orders[i].Drinks.Nombre} Postre {orders[i].Dessert.Nombre}");
                    }


                }
            }
            lboOrdenes.EndUpdate();
        }
   

        
        
            
        

        public void llenarListas()
        {
            ComboBoxItem opcionPorDefecto = new ComboBoxItem
            {
                Text = "Seleccione una opcion",
                Value = null
            };

            var entradas = Repositorio.Instancia.entradas;
            var platofuertes = Repositorio.Instancia.platofuertes;
            var postres = Repositorio.Instancia.postres;
            var bebidas = Repositorio.Instancia.bebidas;

            entrada entrada1 = new entrada("Croquetas");
            entrada entrada2 = new entrada("Egg Roll");
            entrada entrada3 = new entrada("Sopa");
            entrada entrada4 = new entrada("Empanada");
            entrada entrada5 = new entrada("Quipes");

            platofuerte platofuerte1 = new platofuerte("Chow Mein");
            platofuerte platofuerte2 = new platofuerte("Chow Suey");
            platofuerte platofuerte3 = new platofuerte("Arroz Blanco");
            platofuerte platofuerte4 = new platofuerte("Pizza");
            platofuerte platofuerte5 = new platofuerte("Platano Maduro con salami");
            platofuerte platofuerte6 = new platofuerte("Tostones");
            platofuerte platofuerte7 = new platofuerte("Locrio de maiz");
            platofuerte platofuerte8 = new platofuerte("Mero con broccoli");
            platofuerte platofuerte9 = new platofuerte("Pescado");
            platofuerte platofuerte10 = new platofuerte("Moro de guandules");

            
            bebida bebida1 = new bebida("Fanta uva");
            bebida bebida2 = new bebida("Coca Cola");
            bebida bebida3 = new bebida("Corona");
            bebida bebida4 = new bebida("Jack Daniel");
            bebida bebida5 = new bebida("Vino");

            postre postre1 = new postre("Sundae");
            postre postre2 = new postre("Dulce de coco");
            postre postre3 = new postre("Flan de leche");
            postre postre4 = new postre("Helado");
            postre postre5 = new postre("Tres Leches");
            postre postre6 = new postre("Pudin");
            postre postre7 = new postre("Chocolate");
            postre postre8 = new postre("Dulce de vainilla");
            postre postre9 = new postre("mermelada");
            postre postre10 = new postre("Dulce de fruta");

            entradas.Add(entrada1);
            entradas.Add(entrada2);
            entradas.Add(entrada3);
            entradas.Add(entrada4);
            entradas.Add(entrada5);

            bebidas.Add(bebida1);
            bebidas.Add(bebida2);
            bebidas.Add(bebida3);
            bebidas.Add(bebida4);
            bebidas.Add(bebida5);


            platofuertes.Add(platofuerte1);
            platofuertes.Add(platofuerte2);
            platofuertes.Add(platofuerte3);
            platofuertes.Add(platofuerte4);
            platofuertes.Add(platofuerte5);
            platofuertes.Add(platofuerte6);
            platofuertes.Add(platofuerte7);
            platofuertes.Add(platofuerte8);
            platofuertes.Add(platofuerte9);
            platofuertes.Add(platofuerte10);

            postres.Add(postre1);
            postres.Add(postre2);
            postres.Add(postre3);
            postres.Add(postre4);
            postres.Add(postre5);
            postres.Add(postre6);
            postres.Add(postre7);
            postres.Add(postre8);
            postres.Add(postre9);
            postres.Add(postre10);

            cboEntrada.Items.Add(opcionPorDefecto);
            cboEntrada.SelectedItem = opcionPorDefecto;
            cbobebida.Items.Add(opcionPorDefecto);
            cbobebida.SelectedItem = opcionPorDefecto;
            for (int i=0; i<5; i++)
            {
                cboEntrada.Items.Add(entradas[i].Nombre);
                cbobebida.Items.Add(bebidas[i].Nombre);
            }

            cboplatofuerte.Items.Add(opcionPorDefecto);
            cboplatofuerte.SelectedItem = opcionPorDefecto;
            cbopostre.Items.Add(opcionPorDefecto);
            cbopostre.SelectedItem = opcionPorDefecto;
            for (int i=0; i < 10; i++){
                cboplatofuerte.Items.Add(platofuertes[i].Nombre);
                cbopostre.Items.Add(postres[i].Nombre);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Volver = new Form1();
            this.Hide();
            Volver.Show();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void lboOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
