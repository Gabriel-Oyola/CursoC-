using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
         

        }
        int c= 0;
        int[] NumPedido = new int[9];
        string[] comida = new string[9];
        int[] cantComida = new int[9];
        string[] Extra = new string[9];
        int[] CantExtra = new int[9];
        string[] Gaseosa = new string[9];
        int[] CantGaseosa = new int[9];


        private void Form1_Load(object sender, EventArgs e)
        {
            cbComida.Items.Add("Lomito");
            cbComida.Items.Add("Hamburguesa");
            cbComida.Items.Add("Choripan");
            cbComida.Items.Add("Pizza");
            cbComida.Items.Add("Empanadas");

            cbExtra.Items.Add("Papas con huevo");
            cbExtra.Items.Add("Papas con cheddar");

            cbGaseosa.Items.Add("Coca cola");
            cbGaseosa.Items.Add("Fanta");
            cbGaseosa.Items.Add("Spritte");
            cbGaseosa.Items.Add("Agua Mineral");



        }

        public void btCARGAR_Click(object sender, EventArgs e)
        {

            c++;

            string CComida = cbComida.SelectedItem.ToString();
            int CanTC = int.Parse(txtComida.Text); 
            string eextra= cbExtra.SelectedItem.ToString();
            int extraCant = int.Parse(txtExtra.Text); 
            string gas = cbGaseosa.SelectedItem.ToString();
            int gasCant = int.Parse(txtGaseosa.Text);

            NumPedido[c]= c;
            comida[c]= CComida;
            cantComida[c] =CanTC;
            Extra[c] = eextra ;
            CantExtra[c] = extraCant;
            Gaseosa[c] = gas ;
            CantGaseosa[c] =gasCant;

            listNumPedido.Items.Add("PEDIDO " + c);
            listEstadoPedido.Items.Add("En preparacion"); 
        }

        

        private void btCambiarEstado_Click(object sender, EventArgs e)
        {
            listEstadoPedido.Items[listEstadoPedido.SelectedIndex] = "Listo";
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            listEstadoPedido.Items[listEstadoPedido.SelectedIndex] = "Cancelado";
        }

        private void btVer_Click(object sender, EventArgs e)
        {
            string N = listNumPedido.SelectedItem.ToString();
            N=N.Substring(7,1);
            int Ind= int.Parse(N);

            int i = Ind;

            listPedido.Items.Add("N° Pedido: "+i);
            listPedido.Items.Add("Comida: " + comida[i]);
            listPedido.Items.Add("Cantidad: " + cantComida[i]);
            listPedido.Items.Add("Extra: " + Extra[i]);
            listPedido.Items.Add("Cantidad: " + CantExtra[i]);
            listPedido.Items.Add("Gaseosa: " + Gaseosa[i]);
            listPedido.Items.Add("Cantidad: " + CantGaseosa[i]); 

        }
    }
}
