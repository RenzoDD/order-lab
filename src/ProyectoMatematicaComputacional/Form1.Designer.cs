namespace ProyectoMatematicaComputacional
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAnalisis = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnColorFondo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColorBarras = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColorAnalisis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnInsercion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShellSort = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBubbleSort = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMergeSort = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuickSort = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHeap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.elementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtElementos = new System.Windows.Forms.ToolStripTextBox();
            this.btnGenerarArreglo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.minimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMinimo = new System.Windows.Forms.ToolStripTextBox();
            this.maximoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaximo = new System.Windows.Forms.ToolStripTextBox();
            this.canvas = new System.Windows.Forms.Panel();
            this.ElegirColor = new System.Windows.Forms.ColorDialog();
            this.text = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAnalisis,
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.toolStripDropDownButton3,
            this.toolStripSeparator2,
            this.toolStripDropDownButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(386, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnColorFondo,
            this.btnColorBarras,
            this.btnColorAnalisis,
            this.btnInfo});
            this.btnAnalisis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(67, 22);
            this.btnAnalisis.Text = "Proyecto";
            // 
            // btnColorFondo
            // 
            this.btnColorFondo.Image = ((System.Drawing.Image)(resources.GetObject("btnColorFondo.Image")));
            this.btnColorFondo.Name = "btnColorFondo";
            this.btnColorFondo.Size = new System.Drawing.Size(160, 22);
            this.btnColorFondo.Text = "Color de fondo";
            this.btnColorFondo.Click += new System.EventHandler(this.btnColorFondo_Click);
            // 
            // btnColorBarras
            // 
            this.btnColorBarras.Name = "btnColorBarras";
            this.btnColorBarras.Size = new System.Drawing.Size(160, 22);
            this.btnColorBarras.Text = "Color de barras";
            this.btnColorBarras.Click += new System.EventHandler(this.btnColorBarras_Click);
            // 
            // btnColorAnalisis
            // 
            this.btnColorAnalisis.Name = "btnColorAnalisis";
            this.btnColorAnalisis.Size = new System.Drawing.Size(160, 22);
            this.btnColorAnalisis.Text = "Color de análisis";
            this.btnColorAnalisis.Click += new System.EventHandler(this.btnColorAnalisis_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(160, 22);
            this.btnInfo.Text = "Información";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsercion,
            this.btnShellSort,
            this.btnBubbleSort,
            this.btnMergeSort,
            this.btnQuickSort,
            this.btnHeap});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(79, 22);
            this.toolStripDropDownButton2.Text = "Ordenar";
            // 
            // btnInsercion
            // 
            this.btnInsercion.Image = ((System.Drawing.Image)(resources.GetObject("btnInsercion.Image")));
            this.btnInsercion.Name = "btnInsercion";
            this.btnInsercion.Size = new System.Drawing.Size(144, 22);
            this.btnInsercion.Text = "Insertion Sort";
            this.btnInsercion.Click += new System.EventHandler(this.btnInsercion_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Image = ((System.Drawing.Image)(resources.GetObject("btnShellSort.Image")));
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(144, 22);
            this.btnShellSort.Text = "Shell Sort";
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Image = ((System.Drawing.Image)(resources.GetObject("btnBubbleSort.Image")));
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(144, 22);
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Image = ((System.Drawing.Image)(resources.GetObject("btnMergeSort.Image")));
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(144, 22);
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Image = ((System.Drawing.Image)(resources.GetObject("btnQuickSort.Image")));
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(144, 22);
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnHeap
            // 
            this.btnHeap.Image = ((System.Drawing.Image)(resources.GetObject("btnHeap.Image")));
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(144, 22);
            this.btnHeap.Text = "Heap Sort";
            this.btnHeap.Click += new System.EventHandler(this.btnHeap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elementosToolStripMenuItem,
            this.txtElementos,
            this.btnGenerarArreglo});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton3.Text = "Generar";
            // 
            // elementosToolStripMenuItem
            // 
            this.elementosToolStripMenuItem.Enabled = false;
            this.elementosToolStripMenuItem.Name = "elementosToolStripMenuItem";
            this.elementosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.elementosToolStripMenuItem.Text = "Elementos:";
            // 
            // txtElementos
            // 
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(100, 23);
            this.txtElementos.Text = "386";
            this.txtElementos.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtElementos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElementos_KeyPress);
            // 
            // btnGenerarArreglo
            // 
            this.btnGenerarArreglo.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarArreglo.Image")));
            this.btnGenerarArreglo.Name = "btnGenerarArreglo";
            this.btnGenerarArreglo.Size = new System.Drawing.Size(160, 22);
            this.btnGenerarArreglo.Text = "Generar arreglo";
            this.btnGenerarArreglo.Click += new System.EventHandler(this.btnGenerarArreglo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimoToolStripMenuItem,
            this.txtMinimo,
            this.maximoToolStripMenuItem,
            this.txtMaximo});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(58, 22);
            this.toolStripDropDownButton4.Text = "Limites";
            // 
            // minimoToolStripMenuItem
            // 
            this.minimoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimoToolStripMenuItem.Image")));
            this.minimoToolStripMenuItem.Name = "minimoToolStripMenuItem";
            this.minimoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.minimoToolStripMenuItem.Text = "Minimo:";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 23);
            this.txtMinimo.Text = "1";
            this.txtMinimo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElementos_KeyPress);
            // 
            // maximoToolStripMenuItem
            // 
            this.maximoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("maximoToolStripMenuItem.Image")));
            this.maximoToolStripMenuItem.Name = "maximoToolStripMenuItem";
            this.maximoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.maximoToolStripMenuItem.Text = "Maximo:";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 23);
            this.txtMaximo.Text = "10000";
            this.txtMaximo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElementos_KeyPress);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.DarkGray;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Top;
            this.canvas.Location = new System.Drawing.Point(0, 25);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(386, 140);
            this.canvas.TabIndex = 4;
            this.canvas.Resize += new System.EventHandler(this.canvas_Resize);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.White;
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Location = new System.Drawing.Point(0, 165);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(386, 514);
            this.text.TabIndex = 5;
            this.text.Resize += new System.EventHandler(this.canvas_Resize);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 679);
            this.Controls.Add(this.text);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(402, 718);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matemática Computacional";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton btnAnalisis;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btnInsercion;
        private System.Windows.Forms.ToolStripMenuItem btnShellSort;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripTextBox txtElementos;
        private System.Windows.Forms.ToolStripMenuItem elementosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnGenerarArreglo;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem minimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtMinimo;
        private System.Windows.Forms.ToolStripMenuItem maximoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtMaximo;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.ToolStripMenuItem btnColorFondo;
        private System.Windows.Forms.ToolStripMenuItem btnColorBarras;
        private System.Windows.Forms.ColorDialog ElegirColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnColorAnalisis;
        private System.Windows.Forms.ToolStripMenuItem btnInfo;
        private System.Windows.Forms.Panel text;
        private System.Windows.Forms.ToolStripMenuItem btnBubbleSort;
        private System.Windows.Forms.ToolStripMenuItem btnMergeSort;
        private System.Windows.Forms.ToolStripMenuItem btnHeap;
        private System.Windows.Forms.ToolStripMenuItem btnQuickSort;
        private System.Windows.Forms.Timer timer1;
    }
}

