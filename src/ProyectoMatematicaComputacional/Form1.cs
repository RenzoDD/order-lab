using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMatematicaComputacional
{
    public partial class Principal : Form
    {
        #region Atributos/Variables
        int[] arreglo;

        int size = 386;
        long complex = 0;
        bool generacion = false;
        bool sort_in_progress = false;

        BufferedGraphicsContext bfcs;
        BufferedGraphics bfs;
        Graphics lienzoTXT;

        BufferedGraphicsContext bfcIMG;
        BufferedGraphics bfIMG;
        Graphics lienzoIMG;
        Color colorBrocha;
        Color colorFondo;
        Color colorAnalisis;

        #endregion

        #region Formulario
        public Principal()
        {
            InitializeComponent();
            arreglo = new int[0];

            lienzoIMG = canvas.CreateGraphics();
            lienzoTXT = text.CreateGraphics();

            colorBrocha = Color.Red;
            colorFondo = Color.DarkGray;
            colorAnalisis = Color.Blue;

            bfcs = BufferedGraphicsManager.Current;
            bfs = bfcs.Allocate(text.CreateGraphics(), text.ClientRectangle);

            bfcIMG = BufferedGraphicsManager.Current;
            bfIMG = bfcIMG.Allocate(lienzoIMG, this.ClientRectangle);

        }
        private void canvas_Resize(object sender, EventArgs e)
        {
            lienzoIMG = canvas.CreateGraphics();
            bfcIMG = BufferedGraphicsManager.Current;
            bfIMG = bfcIMG.Allocate(lienzoIMG, canvas.ClientRectangle);

            lienzoTXT = text.CreateGraphics();
            bfcs = BufferedGraphicsManager.Current;
            bfs = bfcs.Allocate(text.CreateGraphics(), text.ClientRectangle);
            size = canvas.Size.Width;
            if (!sort_in_progress)
            {

                txtElementos.Text = (canvas.Size.Width).ToString();

                try
                {
                    if (arreglo.Length > 0)
                    {
                        generacion = false;
                        GenerarArreglo();
                        VerArregloText();
                        VerArregloImagen(-1, -1);
                    }
                }
                catch { }
            }
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            GenerarArreglo();
        }
        #endregion
        #region Funciones de ordenamiento
        void GenerarArreglo()
        {
            try
            {
                int i = int.Parse(txtMinimo.Text);
                int f = int.Parse(txtMaximo.Text);
                if (int.Parse(txtElementos.Text) <= size)
                {

                    if (i < f && !String.IsNullOrEmpty(txtMinimo.Text) && !String.IsNullOrEmpty(txtMaximo.Text))
                    {
                        if (0 < (f - i) / Convert.ToInt32(canvas.Height))
                        {
                            if (!String.IsNullOrEmpty(txtElementos.Text))
                            {
                                Random j = new Random();
                                arreglo = new int[int.Parse(txtElementos.Text)];

                                for (int l = 0; l < arreglo.Length; l++)
                                    arreglo[l] = j.Next(i, f);

                                generacion = true;
                                VerArregloText();
                                VerArregloImagen(-1, -1);

                            }
                            else
                                MessageBox.Show("Revise los elementos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Aumente la distancia de los límites, la diferencia debe ser mayor a 212, su diferencia actual es: " + (f - i), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                        MessageBox.Show("Revise los límites", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("La cantidad máxima de elementos es " + size.ToString() + ". ¡Agrande la ventana!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch { }
        }
        void Insercion()
        {
            try
            {
                int pos, aux;
                int i = 0; Complex(1);
                sort_in_progress = true;
                Complex(1);
                while (i < arreglo.Length)
                {
                    Complex(1);

                    pos = i; Complex(1);
                    aux = arreglo[i]; Complex(2);

                    Complex(3);
                    while ((pos > 0) && (arreglo[pos - 1] > aux))
                    {
                        Complex(3);

                        arreglo[pos] = arreglo[pos - 1]; Complex(4);
                        pos--; Complex(2);

                        VerArregloText();
                        VerArregloImagen(i, pos);
                    }

                    arreglo[pos] = aux; Complex(2);
                    i++; Complex(2);
                }
            }
            catch { }
        }
        void ShellSort()
        {
            sort_in_progress = true;
            try
            {
                int n = arreglo.Length;
                Complex(1);
                int salto, i, j, k;
                salto = n / 2;
                Complex(2);


                Complex(1);
                while (salto > 0)
                {
                    Complex(1);

                    i = salto;
                    Complex(1);

                    Complex(1);
                    while (i < n)
                    {
                        Complex(1);
                        j = i - salto;
                        Complex(2);

                        Complex(1);
                        while (j >= 0)
                        {
                            Complex(1);
                            k = j + salto;
                            Complex(2);

                            Complex(3);
                            if (arreglo[j] <= arreglo[k])
                            {
                                j = -1;
                                Complex(1);
                            }

                            else
                            {
                                int aux;
                                aux = arreglo[j];
                                Complex(2);
                                arreglo[j] = arreglo[k];
                                Complex(3);
                                arreglo[k] = aux;
                                Complex(2);
                                j -= salto;
                                Complex(2);
                            }

                            VerArregloText();
                            VerArregloImagen(j, k);

                        }

                        i++;
                        Complex(2);
                    }
                    salto = salto / 2;
                    Complex(2);

                }
            }
            catch { }
        }
        void BubbleSort()
        {
            sort_in_progress = true;
            try
            {
                int aux;
                for (int i = 1; i < arreglo.Length; i++)
                {
                    Complex(1);
                    for (int j = 0; j < arreglo.Length - i; j++)
                    {
                        Complex(2);

                        Complex(1);
                        if (arreglo[j] > arreglo[j + 1])
                        {
                            aux = arreglo[j + 1]; Complex(3);
                            arreglo[j + 1] = arreglo[j]; Complex(4);
                            arreglo[j] = aux; Complex(2);

                            VerArregloImagen(j, i);
                            VerArregloText();
                        }
                    }
                }
            }
            catch { }
        }
        void MergeSort(int izq, int m, int der)
        {
            sort_in_progress = true;
            try
            {
                int i, j, k;
                int[] B = new int[arreglo.Length]; //array auxiliar
                Complex(1);
                for (i = izq; i <= der; i++) //copia ambas mitades en el array auxiliar
                {
                    Complex(3);
                    B[i] = arreglo[i]; Complex(3);
                    VerArregloImagen(i, -1);
                }
                i = izq; j = m + 1; k = izq; Complex(4);
                while (i <= m && j <= der) //copia el siguiente elemento más grande
                {
                    if (B[i] <= B[j])
                    { arreglo[k++] = B[i++]; Complex(7); }
                    else
                    { arreglo[k++] = B[j++]; Complex(7); }

                    VerArregloImagen(i, k);
                    VerArregloText();
                }
                while (i <= m) //copia los elementos que quedan de la
                {
                    arreglo[k++] = B[i++]; Complex(7); //primera mitad (si los hay)
                    VerArregloImagen(-1, i);

                }
            }
            catch { }
        }
        void Merge(int izq, int der)
        {
            sort_in_progress = true;
            try
            {
                Complex(1);
                if (izq < der)
                {
                    int m = (izq + der) / 2; Complex(2);
                    Merge(izq, m);
                    Merge(m + 1, der);
                    MergeSort(izq, m, der);
                }
            }
            catch { }
        }
        void HeapSort()
        {
            sort_in_progress = true;
            try
            {
                Complex(1);
                int n = arreglo.Length;

                Complex(2);
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    Complex(3);
                    heapify(arreglo, n, i);
                    VerArregloImagen(i, n);
                }
                Complex(2);
                for (int i = n - 1; i >= 0; i--)
                {
                    Complex(3);

                    int temp = arreglo[0]; Complex(2);
                    arreglo[0] = arreglo[i]; Complex(3);
                    arreglo[i] = temp; Complex(2);

                    heapify(arreglo, i, 0);
                    VerArregloImagen(i, n);
                    VerArregloText();
                }
            }
            catch
            {

            }
        }
        void heapify(int[] arr, int n, int i)
        {
            int largest = i; Complex(1);
            int l = 2 * i + 1; Complex(2);
            int r = 2 * i + 2; Complex(2);

            Complex(3);
            if (l < n && arr[l] > arr[largest])
            { largest = l; Complex(4); }

            Complex(3);
            if (r < n && arr[r] > arr[largest])
            { largest = r; Complex(4); }

            Complex(1);
            if (largest != i)
            {
                Complex(1);
                int swap = arr[i]; Complex(2);
                arr[i] = arr[largest]; Complex(3);
                arr[largest] = swap; Complex(2);

                heapify(arr, n, largest);
            }
        }
        void QuickSort(int primero, int ultimo)
        {
            sort_in_progress = true;
            try
            {
                int i, j, central;
                double pivote;
                int temp;

                central = (primero + ultimo) / 2; Complex(2);
                pivote = arreglo[central]; Complex(2);
                i = primero; Complex(1);
                j = ultimo; Complex(1);
                do
                {
                    Complex(2);
                    while (arreglo[i] < pivote) { i++; Complex(4); }
                    Complex(2);
                    while (arreglo[j] > pivote) { j--; Complex(4); }
                    Complex(1);
                    if (i <= j)
                    {
                        Complex(1);

                        temp = arreglo[i]; Complex(2);
                        arreglo[i] = arreglo[j]; Complex(3);
                        arreglo[j] = temp; Complex(2);
                        i++; Complex(2);
                        j--; Complex(2);
                    }
                    VerArregloText();
                    VerArregloImagen(i, j);
                    Complex(2);
                } while (i <= j);

                VerArregloText();
                VerArregloImagen(i, j);

                Complex(2);

                Complex(1);
                if (primero < j)
                {
                    QuickSort(primero, j);
                }
                Complex(1);
                if (i < ultimo)
                {
                    QuickSort(i, ultimo);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        #endregion
        #region SinLetras
        private void txtElementos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion
        #region Visualizar
        void VerArregloText()
        {
            try
            {
                if (generacion)
                {
                    string ARRAY = "";
                    if (arreglo.Length > 0)
                    {
                        for (int i = 0; i < arreglo.Length; i++)
                        {
                            if (arreglo[i] / 10 == 0)
                                ARRAY += "000";
                            else if (arreglo[i] / 100 == 0)
                                ARRAY += "00";
                            else if (arreglo[i] / 1000 == 0)
                                ARRAY += "0";


                            ARRAY += arreglo[i].ToString() + " ";
                            if ((i + 1) % (Convert.ToInt32((size - 19) / 34.21)) == 0 && i != 0)
                                ARRAY += "\n";
                        }
                    }
                    bfs.Graphics.Clear(Color.White);
                    bfs.Graphics.DrawString(ARRAY, new Font("Consolas", 9), new SolidBrush(Color.Black), 5, 5);
                    bfs.Render();
                }
            }
            catch { }
        }
        void VerArregloImagen(int j, int k)
        {
            try
            {
                if (generacion)
                {
                    int i = int.Parse(txtMinimo.Text);
                    int f = int.Parse(txtMaximo.Text);

                    bfIMG.Graphics.Clear(colorFondo);

                    int und = (f - i) / Convert.ToInt32(canvas.Height);


                    int ancho = Convert.ToInt32(canvas.Width) / arreglo.Length;

                    for (int value = 0; value < arreglo.Length; value++)
                    {
                        int alto = (arreglo[value] - i) / und;
                        int y = Convert.ToInt32(canvas.Height) - alto;
                        int x = ancho * value;

                        Rectangle rect = new Rectangle(x, y, ancho, alto);
                        if (value == j || value == k)
                            bfIMG.Graphics.FillRectangle(new SolidBrush(colorAnalisis), rect);
                        else
                            bfIMG.Graphics.FillRectangle(new SolidBrush(colorBrocha), rect);
                    }

                    bfIMG.Graphics.DrawString("Complejidad: " + complex.ToString(), new Font("Consolas", 9), new SolidBrush(colorAnalisis), 5, 5);
                    bfIMG.Graphics.DrawString("Elementos: " + arreglo.Length.ToString(), new Font("Consolas", 9), new SolidBrush(colorAnalisis), 5, 15);
                    bfIMG.Render(lienzoIMG);
                }
            }
            catch { }
        }
        void Complex(int n)
        {
            complex += n;
        }
        #endregion
        #region Botones
        private void btnGenerarArreglo_Click(object sender, EventArgs e)
        {
            if (!sort_in_progress)
            {
                GenerarArreglo();
                generacion = true;
            }
        }
        private void btnShellSort_Click(object sender, EventArgs e)
        {
            if (!sort_in_progress)
            {
                inicio:
                if (arreglo.Length > 0 && generacion)
                {
                    Task t = new Task(() =>
                    {
                        ShellSort(); sort_in_progress = false;
                        VerArregloImagen(-1, -1);
                        complex = 0;
                        generacion = false;
                    });
                    t.Start();
                }
                else
                {
                    GenerarArreglo(); generacion = true; goto inicio;
                }
            }
        }
        private void btnInsercion_Click(object sender, EventArgs e)
        {
            if (!sort_in_progress)
            {
                inicio:
                if (arreglo.Length > 0 && generacion)
                {
                    Task t = new Task(() =>
                    {
                        Insercion(); sort_in_progress = false;
                        VerArregloImagen(-1, -1);
                        complex = 0;
                        generacion = false;
                    });
                    t.Start();
                }
                else
                { GenerarArreglo(); generacion = true; goto inicio; }

            }
        }
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            if (!sort_in_progress)
            {
                inicio:
                if (arreglo.Length > 0 && generacion)
                {

                    Task t = new Task(() =>
                    {
                        BubbleSort(); sort_in_progress = false;
                        VerArregloImagen(-1, -1);
                        complex = 0;
                        generacion = false;
                    });
                    t.Start();
                }
                else
                { GenerarArreglo(); generacion = true; goto inicio; }

            }
        }
        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            if (!sort_in_progress)
            {
                inicio:
                if (arreglo.Length > 0 && generacion)
                {

                    Task t = new Task(() =>
                    {
                        Merge(0, arreglo.Length - 1); sort_in_progress = false;
                        VerArregloImagen(-1, -1);
                        complex = 0;
                        generacion = false;
                    });
                    t.Start();
                }
                else
                { GenerarArreglo(); generacion = true; goto inicio; }
            }
        }
        private void btnHeap_Click(object sender, EventArgs e)
        {
            if (!sort_in_progress)
            {
                inicio:
                if (arreglo.Length > 0 && generacion)
                {

                    Task t = new Task(() =>
                    {
                        HeapSort(); sort_in_progress = false;
                        VerArregloImagen(-1, -1);
                        complex = 0;
                        generacion = false;
                    });
                    t.Start();
                }
                else
                { GenerarArreglo(); generacion = true; goto inicio; }
            }
        }
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            if (!sort_in_progress)
            {
                inicio:
                if (arreglo.Length > 0 && generacion)
                {

                    Task t = new Task(() =>
                    {
                        QuickSort(0, arreglo.Length - 1); sort_in_progress = false;
                        VerArregloImagen(-1, -1);
                        complex = 0;
                        generacion = false;
                    });
                    t.Start();
                }
                else
                { GenerarArreglo(); generacion = true; goto inicio; }
            }
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region Colores
        private void btnColorFondo_Click(object sender, EventArgs e)
        {
            ElegirColor.Color = colorFondo;

            if (ElegirColor.ShowDialog() == DialogResult.OK)
                colorFondo = ElegirColor.Color;

            VerArregloImagen(-1, -1);
        }
        private void btnColorBarras_Click(object sender, EventArgs e)
        {
            ElegirColor.Color = colorBrocha;

            if (ElegirColor.ShowDialog() == DialogResult.OK)
                colorBrocha = ElegirColor.Color;

            VerArregloImagen(-1, -1);
        }
        private void btnColorAnalisis_Click(object sender, EventArgs e)
        {
            ElegirColor.Color = colorAnalisis;

            if (ElegirColor.ShowDialog() == DialogResult.OK)
                colorAnalisis = ElegirColor.Color;

            VerArregloImagen(-1, -1);
        }


        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!sort_in_progress)
            {
                lienzoIMG = canvas.CreateGraphics();
                bfcIMG = BufferedGraphicsManager.Current;
                bfIMG = bfcIMG.Allocate(lienzoIMG, canvas.ClientRectangle);

                lienzoTXT = text.CreateGraphics();
                bfcs = BufferedGraphicsManager.Current;
                bfs = bfcs.Allocate(text.CreateGraphics(), text.ClientRectangle);
                size = canvas.Size.Width;
                if (!sort_in_progress)
                {

                    txtElementos.Text = (canvas.Size.Width).ToString();

                    try
                    {
                        if (arreglo.Length > 0)
                        {
                            VerArregloText();
                            VerArregloImagen(-1, -1);
                        }
                    }
                    catch { }
                }
            }
        }
    }
}
