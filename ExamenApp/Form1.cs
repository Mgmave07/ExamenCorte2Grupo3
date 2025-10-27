using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenApp
{
    public partial class Form1 : Form
    {
        // Cola Para pacientes normales
        Queue<string> colaNormales = new Queue<string>();
        // Cola Para pacientes prioritarios
        Stack<string> pilaEmergencia = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string tipo = cmbUrgencia.SelectedItem.ToString();
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Por favor ingrese un nombre y seleccione el tipo de urgencia.");
                return;
            }
            if (tipo == "Emergencia")
            {
                pilaEmergencia.Push(nombre);
                MessageBox.Show("Paciente de emergencia agregado: " + nombre);

            }
            else
            {
                colaNormales.Enqueue(nombre);
                MessageBox.Show("Paciente normal agregado: " + nombre);
            }
            tbNombre.Clear();
            ActualizarLista();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            string atendido = null;
            if (pilaEmergencia.Count > 0)
            {
                atendido = pilaEmergencia.Pop();

            }
            else if (colaNormales.Count > 0)
            {
                atendido = colaNormales.Dequeue();

            }
            else
            {
                MessageBox.Show("No hay pacientes en espera.");
                return;
            }
            lblAtendiendo.Text = "Atendiendo a: " + atendido;
            ActualizarLista();
        }
        private void ActualizarLista()
        {
            lbNormal.Items.Clear();
            foreach (string p in colaNormales)
            {
                lbNormal.Items.Add(p);
            }
            lbUrgencia.Items.Clear();
            foreach (string p in pilaEmergencia)
            {
                lbUrgencia.Items.Add(p);
            }
        }
    }
}
