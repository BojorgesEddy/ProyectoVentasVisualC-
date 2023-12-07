namespace GUI_MODERNISTA
{
    partial class EditarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textSerie = new System.Windows.Forms.TextBox();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(639, 532);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(194, 48);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "BORRAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Precio";
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.ForeColor = System.Drawing.Color.White;
            this.textPrecio.Location = new System.Drawing.Point(138, 368);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(286, 17);
            this.textPrecio.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(183, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Editar Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Numero de Serie";
            // 
            // textCantidad
            // 
            this.textCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidad.ForeColor = System.Drawing.Color.White;
            this.textCantidad.Location = new System.Drawing.Point(138, 329);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(286, 17);
            this.textCantidad.TabIndex = 19;
            // 
            // textDescripcion
            // 
            this.textDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.ForeColor = System.Drawing.Color.White;
            this.textDescripcion.Location = new System.Drawing.Point(138, 289);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(286, 17);
            this.textDescripcion.TabIndex = 18;
            // 
            // textModelo
            // 
            this.textModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModelo.ForeColor = System.Drawing.Color.White;
            this.textModelo.Location = new System.Drawing.Point(138, 247);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(286, 17);
            this.textModelo.TabIndex = 17;
            // 
            // textSerie
            // 
            this.textSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSerie.ForeColor = System.Drawing.Color.White;
            this.textSerie.Location = new System.Drawing.Point(138, 204);
            this.textSerie.Name = "textSerie";
            this.textSerie.Size = new System.Drawing.Size(286, 17);
            this.textSerie.TabIndex = 16;
            // 
            // textProducto
            // 
            this.textProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProducto.ForeColor = System.Drawing.Color.White;
            this.textProducto.Location = new System.Drawing.Point(138, 160);
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(286, 17);
            this.textProducto.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Producto";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(865, 532);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(194, 48);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "GUARDAR CAMBIOS";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnInicio.FlatAppearance.BorderSize = 2;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(19, 463);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(87, 51);
            this.btnInicio.TabIndex = 29;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSiguiente.FlatAppearance.BorderSize = 2;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(112, 463);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(87, 51);
            this.btnSiguiente.TabIndex = 30;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnRegresar.FlatAppearance.BorderSize = 2;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(222, 463);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(87, 51);
            this.btnRegresar.TabIndex = 31;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnFinal.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnFinal.FlatAppearance.BorderSize = 2;
            this.btnFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.ForeColor = System.Drawing.Color.White;
            this.btnFinal.Location = new System.Drawing.Point(320, 463);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(87, 51);
            this.btnFinal.TabIndex = 32;
            this.btnFinal.Text = "FINAL";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textID.Enabled = false;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.Color.White;
            this.textID.Location = new System.Drawing.Point(140, 119);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(286, 17);
            this.textID.TabIndex = 34;
            this.textID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(430, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 502);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1080, 612);
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 140;
            this.lineShape1.X2 = 422;
            this.lineShape1.Y1 = 136;
            this.lineShape1.Y2 = 136;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 138;
            this.lineShape2.X2 = 420;
            this.lineShape2.Y1 = 185;
            this.lineShape2.Y2 = 185;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 138;
            this.lineShape3.X2 = 420;
            this.lineShape3.Y1 = 229;
            this.lineShape3.Y2 = 229;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 140;
            this.lineShape4.X2 = 422;
            this.lineShape4.Y1 = 272;
            this.lineShape4.Y2 = 272;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 138;
            this.lineShape5.X2 = 420;
            this.lineShape5.Y1 = 353;
            this.lineShape5.Y2 = 353;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 140;
            this.lineShape6.X2 = 422;
            this.lineShape6.Y1 = 393;
            this.lineShape6.Y2 = 393;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 138;
            this.lineShape7.X2 = 420;
            this.lineShape7.Y1 = 314;
            this.lineShape7.Y2 = 314;
            // 
            // EditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.textSerie);
            this.Controls.Add(this.textProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "EditarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textSerie;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}