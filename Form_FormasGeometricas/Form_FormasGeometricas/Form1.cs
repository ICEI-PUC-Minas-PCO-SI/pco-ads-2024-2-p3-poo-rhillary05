using Form_FormasGeometricas.src.com.rhillary.Formas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_FormasGeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Forma forma = null;

            string figura = comboBoxFiguras.SelectedItem.ToString();

            
            if (figura == "Círculo")
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                forma = new Circulo(raio);
                pictureBoxFigura.Image = Image.FromFile(@"src/com/rhillary/Imagens/CirculoImagem.png");
                pictureBoxFigura.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (figura == "Retângulo")
            {
                double baseRet = Convert.ToDouble(txtBase.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                forma = new Retangulo(baseRet, altura);
                pictureBoxFigura.Image = Image.FromFile(@"src/com/rhillary/Imagens/RetanguloImagem.png");
                pictureBoxFigura.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (figura == "Hexágono")
            {
                double ladoH = Convert.ToDouble(txtLado1.Text);
                forma = new Hexagono(ladoH);
                pictureBoxFigura.Image = Image.FromFile(@"src/com/rhillary/Imagens/HexagonoImagem.png");
                pictureBoxFigura.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (figura == "Pentágono")
            {
                double ladoP = Convert.ToDouble(txtLado1.Text);
                forma = new Pentagono(ladoP);
                pictureBoxFigura.Image = Image.FromFile(@"src/com/rhillary/Imagens/PentagonoImagem.png");
                pictureBoxFigura.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (figura == "Octógono")
            {
                double ladoO = Convert.ToDouble(txtLado1.Text);
                forma = new Octogono(ladoO);
                pictureBoxFigura.Image = Image.FromFile(@"src/com/rhillary/Imagens/OctagonoImagem.png");
                pictureBoxFigura.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (figura == "Quadrado")
            {
                double ladoQ = Convert.ToDouble(txtLado1.Text);
                forma = new Quadrado(ladoQ);
                pictureBoxFigura.Image = Image.FromFile(@"src/com/rhillary/Imagens/QuadradoImagem.png");
                pictureBoxFigura.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (figura == "Triângulo Equilátero")
            {
                double ladoT = Convert.ToDouble(txtLado1.Text);
                forma = new Equilatero(ladoT);
                pictureBoxFigura.Image = Image.FromFile(@"src/com/rhillary/Imagens/TrianguloEquilateroImagem.png");
                pictureBoxFigura.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (figura == "Triângulo Escaleno")
            {
                double lado1 = Convert.ToDouble(txtLado1.Text);
                double lado2 = Convert.ToDouble(txtLado2.Text);
                double lado3 = Convert.ToDouble(txtLado3.Text);
                forma = new Escaleno(lado1, lado2, lado3);
                pictureBoxFigura.Image = Image.FromFile(@"src/com/rhillary/Imagens/TrianguloEscalenoImagem.png");
                pictureBoxFigura.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (figura == "Triângulo Isósceles")
            {
                double baseT = Convert.ToDouble(txtBase.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                double lado1 = Convert.ToDouble(txtLado1.Text);
                forma = new Isosceles(baseT, altura, lado1);
                pictureBoxFigura.Image = Image.FromFile(@"src/com/rhillary/Imagens/TrianguloIsoscelesImagem.png");
                pictureBoxFigura.SizeMode = PictureBoxSizeMode.Zoom;
            }

            
            if (forma != null)
            {
                
                double area = forma.calcularArea();
                double perimetro = forma.calcularPerimetro();

                
                lblResultadoArea.Text = $"Área: {area:F2}";
                lblPerimetroResultado.Text = $"Perímetro: {perimetro:F2}";
            }
        }

        private void comboBoxFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string figura = comboBoxFiguras.SelectedItem.ToString();

            if (figura == "Círculo")
            {
                lblRaio.Visible = true;
                txtRaio.Visible = true;

                lblBase.Visible = false;
                txtBase.Visible = false;
                lblAltura.Visible = false;
                txtAltura.Visible = false;
                lblLado1.Visible = false;
                txtLado1.Visible = false;
                lblLado2.Visible = false;
                txtLado2.Visible = false;
                lblLado3.Visible = false;
                txtLado3.Visible = false;
            }
            else if (figura == "Retângulo")
            {
                lblRaio.Visible = false;
                txtRaio.Visible = false;
                lblLado1.Visible = false;
                txtLado1.Visible = false;
                lblLado2.Visible = false;
                txtLado2.Visible = false;
                lblLado3.Visible = false;
                txtLado3.Visible = false;

                lblBase.Visible = true;
                txtBase.Visible = true;
                lblAltura.Visible = true;
                txtAltura.Visible = true;
            }
            else if (figura == "Hexágono")
            {
                lblRaio.Visible = false;
                txtRaio.Visible = false;
                lblLado2.Visible = false;
                txtLado2.Visible = false;
                lblLado3.Visible = false;
                txtLado3.Visible = false;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lblAltura.Visible = false;
                txtAltura.Visible = false;

                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            else if (figura == "Pentágono")
            {
                lblRaio.Visible = false;
                txtRaio.Visible = false;
                lblLado2.Visible = false;
                txtLado2.Visible = false;
                lblLado3.Visible = false;
                txtLado3.Visible = false;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lblAltura.Visible = false;
                txtAltura.Visible = false;

                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            else if (figura == "Octógono")
            {
                lblRaio.Visible = false;
                txtRaio.Visible = false;
                lblLado2.Visible = false;
                txtLado2.Visible = false;
                lblLado3.Visible = false;
                txtLado3.Visible = false;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lblAltura.Visible = false;
                txtAltura.Visible = false;

                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            else if (figura == "Quadrado")
            {
                lblRaio.Visible = false;
                txtRaio.Visible = false;
                lblLado2.Visible = false;
                txtLado2.Visible = false;
                lblLado3.Visible = false;
                txtLado3.Visible = false;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lblAltura.Visible = false;
                txtAltura.Visible = false;

                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            else if (figura == "Triângulo Equilátero")
            {
                lblRaio.Visible = false;
                txtRaio.Visible = false;
                lblLado2.Visible = false;
                txtLado2.Visible = false;
                lblLado3.Visible = false;
                txtLado3.Visible = false;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lblAltura.Visible = false;
                txtAltura.Visible = false;

                lblLado1.Visible = true;
                txtLado1.Visible = true;
            }
            else if (figura == "Triângulo Escaleno")
            {
                lblRaio.Visible = false;
                txtRaio.Visible = false;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lblAltura.Visible = false;
                txtAltura.Visible = false;

                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Visible = true;
                txtLado3.Visible = true;
            }
            else if (figura == "Triângulo Isósceles")
            {
                lblRaio.Visible = false;
                txtRaio.Visible = false;
                lblLado2.Visible = false;
                txtLado2.Visible = false;
                lblLado3.Visible = false;
                txtLado3.Visible = false;
                

                lblLado1.Visible = true;
                txtLado1.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblAltura.Visible = true;
                txtAltura.Visible = true;
            }
        }




    }
}