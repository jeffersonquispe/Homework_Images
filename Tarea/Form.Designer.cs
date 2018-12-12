namespace PDI_Tarea_3 {
	partial class Form {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.imagenBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.fileDimentions = new System.Windows.Forms.Label();
            this.bitsProfundidad = new System.Windows.Forms.Label();
            this.fileMb = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.textBitsInfo = new System.Windows.Forms.Label();
            this.textImageMB = new System.Windows.Forms.Label();
            this.textImageSize = new System.Windows.Forms.Label();
            this.textImageName = new System.Windows.Forms.Label();
            this.primariMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearestNeighborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilinealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicControlBox = new System.Windows.Forms.GroupBox();
            this.zoomOut = new System.Windows.Forms.Button();
            this.zoomIn = new System.Windows.Forms.Button();
            this.negativo = new System.Windows.Forms.Button();
            this.flipVertical = new System.Windows.Forms.Button();
            this.flipHorizontal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarBrillo = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBarContraste = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarUmbral = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarRotacion = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkInterBi = new System.Windows.Forms.CheckBox();
            this.gbFile = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFFT = new System.Windows.Forms.Button();
            this.imagenBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.primariMenu.SuspendLayout();
            this.basicControlBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrillo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContraste)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUmbral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotacion)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbFile.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagenBox
            // 
            resources.ApplyResources(this.imagenBox, "imagenBox");
            this.imagenBox.Controls.Add(this.panel1);
            this.imagenBox.Controls.Add(this.pictureBox);
            this.imagenBox.Name = "imagenBox";
            this.imagenBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.histogram);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // histogram
            // 
            this.histogram.BackColor = System.Drawing.Color.Transparent;
            this.histogram.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.histogram.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.histogram.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.histogram.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.histogram.ChartAreas.Add(chartArea2);
            this.histogram.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.histogram, "histogram");
            this.histogram.Name = "histogram";
            this.histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.histogram.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Green,
        System.Drawing.Color.Blue};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "R";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Name = "G";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Name = "B";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.histogram.Series.Add(series4);
            this.histogram.Series.Add(series5);
            this.histogram.Series.Add(series6);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // fileDimentions
            // 
            resources.ApplyResources(this.fileDimentions, "fileDimentions");
            this.fileDimentions.Name = "fileDimentions";
            // 
            // bitsProfundidad
            // 
            resources.ApplyResources(this.bitsProfundidad, "bitsProfundidad");
            this.bitsProfundidad.Name = "bitsProfundidad";
            // 
            // fileMb
            // 
            resources.ApplyResources(this.fileMb, "fileMb");
            this.fileMb.Name = "fileMb";
            // 
            // fileName
            // 
            resources.ApplyResources(this.fileName, "fileName");
            this.fileName.Name = "fileName";
            // 
            // textBitsInfo
            // 
            resources.ApplyResources(this.textBitsInfo, "textBitsInfo");
            this.textBitsInfo.Name = "textBitsInfo";
            // 
            // textImageMB
            // 
            resources.ApplyResources(this.textImageMB, "textImageMB");
            this.textImageMB.Name = "textImageMB";
            // 
            // textImageSize
            // 
            resources.ApplyResources(this.textImageSize, "textImageSize");
            this.textImageSize.Name = "textImageSize";
            // 
            // textImageName
            // 
            resources.ApplyResources(this.textImageName, "textImageName");
            this.textImageName.Name = "textImageName";
            // 
            // primariMenu
            // 
            this.primariMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.interpolaciónToolStripMenuItem});
            resources.ApplyResources(this.primariMenu, "primariMenu");
            this.primariMenu.Name = "primariMenu";
            this.primariMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // abrirToolStripMenuItem
            // 
            resources.ApplyResources(this.abrirToolStripMenuItem, "abrirToolStripMenuItem");
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            resources.ApplyResources(this.guardarToolStripMenuItem, "guardarToolStripMenuItem");
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            resources.ApplyResources(this.guardarComoToolStripMenuItem, "guardarComoToolStripMenuItem");
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            resources.ApplyResources(this.verToolStripMenuItem, "verToolStripMenuItem");
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // interpolaciónToolStripMenuItem
            // 
            this.interpolaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nearestNeighborToolStripMenuItem,
            this.bilinealToolStripMenuItem});
            this.interpolaciónToolStripMenuItem.Name = "interpolaciónToolStripMenuItem";
            resources.ApplyResources(this.interpolaciónToolStripMenuItem, "interpolaciónToolStripMenuItem");
            // 
            // nearestNeighborToolStripMenuItem
            // 
            this.nearestNeighborToolStripMenuItem.Checked = true;
            this.nearestNeighborToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.nearestNeighborToolStripMenuItem, "nearestNeighborToolStripMenuItem");
            this.nearestNeighborToolStripMenuItem.Name = "nearestNeighborToolStripMenuItem";
            this.nearestNeighborToolStripMenuItem.Click += new System.EventHandler(this.nearestNeighborToolStripMenuItem_Click);
            // 
            // bilinealToolStripMenuItem
            // 
            this.bilinealToolStripMenuItem.Name = "bilinealToolStripMenuItem";
            resources.ApplyResources(this.bilinealToolStripMenuItem, "bilinealToolStripMenuItem");
            this.bilinealToolStripMenuItem.Click += new System.EventHandler(this.bilinealToolStripMenuItem_Click);
            // 
            // basicControlBox
            // 
            resources.ApplyResources(this.basicControlBox, "basicControlBox");
            this.basicControlBox.Controls.Add(this.negativo);
            this.basicControlBox.Controls.Add(this.flipVertical);
            this.basicControlBox.Controls.Add(this.flipHorizontal);
            this.basicControlBox.Name = "basicControlBox";
            this.basicControlBox.TabStop = false;
            // 
            // zoomOut
            // 
            this.zoomOut.Image = global::PDI_Tarea_3.Properties.Resources.zoom_out;
            resources.ApplyResources(this.zoomOut, "zoomOut");
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // zoomIn
            // 
            this.zoomIn.Image = global::PDI_Tarea_3.Properties.Resources.zoom_in;
            resources.ApplyResources(this.zoomIn, "zoomIn");
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // negativo
            // 
            resources.ApplyResources(this.negativo, "negativo");
            this.negativo.Name = "negativo";
            this.negativo.UseVisualStyleBackColor = true;
            this.negativo.Click += new System.EventHandler(this.negativo_Click);
            // 
            // flipVertical
            // 
            resources.ApplyResources(this.flipVertical, "flipVertical");
            this.flipVertical.Name = "flipVertical";
            this.flipVertical.UseVisualStyleBackColor = true;
            this.flipVertical.Click += new System.EventHandler(this.flipVertical_Click);
            // 
            // flipHorizontal
            // 
            resources.ApplyResources(this.flipHorizontal, "flipHorizontal");
            this.flipHorizontal.Name = "flipHorizontal";
            this.flipHorizontal.UseVisualStyleBackColor = true;
            this.flipHorizontal.Click += new System.EventHandler(this.flipHorizontal_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.trackBarBrillo);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // trackBarBrillo
            // 
            resources.ApplyResources(this.trackBarBrillo, "trackBarBrillo");
            this.trackBarBrillo.Maximum = 255;
            this.trackBarBrillo.Minimum = -255;
            this.trackBarBrillo.Name = "trackBarBrillo";
            this.trackBarBrillo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBrillo.ValueChanged += new System.EventHandler(this.trackBarBrillo_ValueChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.trackBarContraste);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // trackBarContraste
            // 
            resources.ApplyResources(this.trackBarContraste, "trackBarContraste");
            this.trackBarContraste.Maximum = 300;
            this.trackBarContraste.Minimum = -300;
            this.trackBarContraste.Name = "trackBarContraste";
            this.trackBarContraste.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarContraste.ValueChanged += new System.EventHandler(this.trackBarContraste_ValueChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.trackBarUmbral);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // trackBarUmbral
            // 
            resources.ApplyResources(this.trackBarUmbral, "trackBarUmbral");
            this.trackBarUmbral.Maximum = 255;
            this.trackBarUmbral.Name = "trackBarUmbral";
            this.trackBarUmbral.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarUmbral.Value = 127;
            this.trackBarUmbral.ValueChanged += new System.EventHandler(this.trackBarUmbral_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // trackBarRotacion
            // 
            resources.ApplyResources(this.trackBarRotacion, "trackBarRotacion");
            this.trackBarRotacion.Maximum = 360;
            this.trackBarRotacion.Name = "trackBarRotacion";
            this.trackBarRotacion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRotacion.Scroll += new System.EventHandler(this.trackBarRotacion_Scroll);
            this.trackBarRotacion.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.comboBox3);
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            resources.GetString("comboBox3.Items2"),
            resources.GetString("comboBox3.Items3"),
            resources.GetString("comboBox3.Items4")});
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Tag = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox1);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAbrir
            // 
            resources.ApplyResources(this.btnAbrir, "btnAbrir");
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkInterBi
            // 
            resources.ApplyResources(this.chkInterBi, "chkInterBi");
            this.chkInterBi.Name = "chkInterBi";
            this.chkInterBi.UseVisualStyleBackColor = true;
            this.chkInterBi.CheckedChanged += new System.EventHandler(this.chkInterBi_CheckedChanged);
            // 
            // gbFile
            // 
            this.gbFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbFile.Controls.Add(this.fileDimentions);
            this.gbFile.Controls.Add(this.btnGuardar);
            this.gbFile.Controls.Add(this.bitsProfundidad);
            this.gbFile.Controls.Add(this.btnAbrir);
            this.gbFile.Controls.Add(this.fileMb);
            this.gbFile.Controls.Add(this.textImageName);
            this.gbFile.Controls.Add(this.fileName);
            this.gbFile.Controls.Add(this.textImageSize);
            this.gbFile.Controls.Add(this.textBitsInfo);
            this.gbFile.Controls.Add(this.textImageMB);
            resources.ApplyResources(this.gbFile, "gbFile");
            this.gbFile.Name = "gbFile";
            this.gbFile.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox8.Controls.Add(this.zoomOut);
            this.groupBox8.Controls.Add(this.zoomIn);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.trackBarRotacion);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.chkInterBi);
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox5.Controls.Add(this.btnFFT);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // btnFFT
            // 
            resources.ApplyResources(this.btnFFT, "btnFFT");
            this.btnFFT.Name = "btnFFT";
            this.btnFFT.UseVisualStyleBackColor = true;
            this.btnFFT.Click += new System.EventHandler(this.btnFFT_Click);
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbFile);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.basicControlBox);
            this.Controls.Add(this.imagenBox);
            this.Controls.Add(this.primariMenu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.primariMenu;
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.imagenBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.primariMenu.ResumeLayout(false);
            this.primariMenu.PerformLayout();
            this.basicControlBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrillo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContraste)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUmbral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotacion)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.gbFile.ResumeLayout(false);
            this.gbFile.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox imagenBox;
		private System.Windows.Forms.MenuStrip primariMenu;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.GroupBox basicControlBox;
		private System.Windows.Forms.Button negativo;
		private System.Windows.Forms.Button flipVertical;
		private System.Windows.Forms.Button flipHorizontal;
		private System.Windows.Forms.Label textImageMB;
		private System.Windows.Forms.Label textImageSize;
		private System.Windows.Forms.Label textImageName;
		private System.Windows.Forms.Label textBitsInfo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TrackBar trackBarBrillo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TrackBar trackBarContraste;
		private System.Windows.Forms.DataVisualization.Charting.Chart histogram;
		private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
		private System.Windows.Forms.Label fileName;
		private System.Windows.Forms.Label fileDimentions;
		private System.Windows.Forms.Label bitsProfundidad;
		private System.Windows.Forms.Label fileMb;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar trackBarUmbral;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar trackBarRotacion;
		private System.Windows.Forms.Button zoomIn;
		private System.Windows.Forms.Button zoomOut;
		private System.Windows.Forms.ToolStripMenuItem interpolaciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nearestNeighborToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bilinealToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkInterBi;
        private System.Windows.Forms.GroupBox gbFile;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFFT;
    }
}

