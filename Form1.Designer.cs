namespace Algoritmos
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.RichTextBox();
            this.txtOrden = new System.Windows.Forms.RichTextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtTimeBubble = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuick = new System.Windows.Forms.RichTextBox();
            this.txtTimeQuick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuick = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsercion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeInsercion = new System.Windows.Forms.TextBox();
            this.txtInsercion = new System.Windows.Forms.RichTextBox();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.txtSeekElement = new System.Windows.Forms.TextBox();
            this.txtBinaryTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBinaryIndex = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSecuentialIndex = new System.Windows.Forms.TextBox();
            this.txtSecuentialTime = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(773, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Vector";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(12, 51);
            this.txtArray.Name = "txtArray";
            this.txtArray.ReadOnly = true;
            this.txtArray.Size = new System.Drawing.Size(861, 296);
            this.txtArray.TabIndex = 1;
            this.txtArray.Text = "";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(16, 406);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.ReadOnly = true;
            this.txtOrden.Size = new System.Drawing.Size(276, 449);
            this.txtOrden.TabIndex = 2;
            this.txtOrden.Text = "";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(180, 369);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(99, 31);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtTimeBubble
            // 
            this.txtTimeBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeBubble.Location = new System.Drawing.Point(108, 881);
            this.txtTimeBubble.Name = "txtTimeBubble";
            this.txtTimeBubble.ReadOnly = true;
            this.txtTimeBubble.Size = new System.Drawing.Size(184, 26);
            this.txtTimeBubble.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 858);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tiempo que duro el Bubble Sort:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQuick
            // 
            this.txtQuick.Location = new System.Drawing.Point(306, 406);
            this.txtQuick.Name = "txtQuick";
            this.txtQuick.ReadOnly = true;
            this.txtQuick.Size = new System.Drawing.Size(276, 449);
            this.txtQuick.TabIndex = 6;
            this.txtQuick.Text = "";
            // 
            // txtTimeQuick
            // 
            this.txtTimeQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeQuick.Location = new System.Drawing.Point(382, 881);
            this.txtTimeQuick.Name = "txtTimeQuick";
            this.txtTimeQuick.ReadOnly = true;
            this.txtTimeQuick.Size = new System.Drawing.Size(200, 26);
            this.txtTimeQuick.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 858);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiempo que duro el Quick Sort:";
            // 
            // btnQuick
            // 
            this.btnQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuick.Location = new System.Drawing.Point(483, 369);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(99, 31);
            this.btnQuick.TabIndex = 9;
            this.btnQuick.Text = "Ordenar";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vector generado:";
            // 
            // btnInsercion
            // 
            this.btnInsercion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsercion.Location = new System.Drawing.Point(774, 369);
            this.btnInsercion.Name = "btnInsercion";
            this.btnInsercion.Size = new System.Drawing.Size(99, 31);
            this.btnInsercion.TabIndex = 14;
            this.btnInsercion.Text = "Ordenar";
            this.btnInsercion.UseVisualStyleBackColor = true;
            this.btnInsercion.Click += new System.EventHandler(this.btnInsercion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 858);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tiempo que duro el de Insercion:";
            // 
            // txtTimeInsercion
            // 
            this.txtTimeInsercion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeInsercion.Location = new System.Drawing.Point(673, 881);
            this.txtTimeInsercion.Name = "txtTimeInsercion";
            this.txtTimeInsercion.ReadOnly = true;
            this.txtTimeInsercion.Size = new System.Drawing.Size(200, 26);
            this.txtTimeInsercion.TabIndex = 12;
            // 
            // txtInsercion
            // 
            this.txtInsercion.Location = new System.Drawing.Point(597, 406);
            this.txtInsercion.Name = "txtInsercion";
            this.txtInsercion.ReadOnly = true;
            this.txtInsercion.Size = new System.Drawing.Size(276, 449);
            this.txtInsercion.TabIndex = 11;
            this.txtInsercion.Text = "";
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinarySearch.Location = new System.Drawing.Point(1104, 12);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(99, 31);
            this.btnBinarySearch.TabIndex = 15;
            this.btnBinarySearch.Text = "Buscar";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // txtSeekElement
            // 
            this.txtSeekElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeekElement.Location = new System.Drawing.Point(883, 51);
            this.txtSeekElement.Name = "txtSeekElement";
            this.txtSeekElement.Size = new System.Drawing.Size(320, 26);
            this.txtSeekElement.TabIndex = 17;
            // 
            // txtBinaryTime
            // 
            this.txtBinaryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinaryTime.Location = new System.Drawing.Point(109, 52);
            this.txtBinaryTime.Name = "txtBinaryTime";
            this.txtBinaryTime.ReadOnly = true;
            this.txtBinaryTime.Size = new System.Drawing.Size(205, 26);
            this.txtBinaryTime.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBinaryIndex);
            this.groupBox1.Controls.Add(this.txtBinaryTime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(883, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 153);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Binaria:";
            // 
            // txtBinaryIndex
            // 
            this.txtBinaryIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinaryIndex.Location = new System.Drawing.Point(109, 106);
            this.txtBinaryIndex.Name = "txtBinaryIndex";
            this.txtBinaryIndex.ReadOnly = true;
            this.txtBinaryIndex.Size = new System.Drawing.Size(205, 26);
            this.txtBinaryIndex.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSecuentialIndex);
            this.groupBox2.Controls.Add(this.txtSecuentialTime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(883, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 153);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda Secuencial:";
            // 
            // txtSecuentialIndex
            // 
            this.txtSecuentialIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecuentialIndex.Location = new System.Drawing.Point(109, 106);
            this.txtSecuentialIndex.Name = "txtSecuentialIndex";
            this.txtSecuentialIndex.ReadOnly = true;
            this.txtSecuentialIndex.Size = new System.Drawing.Size(205, 26);
            this.txtSecuentialIndex.TabIndex = 20;
            // 
            // txtSecuentialTime
            // 
            this.txtSecuentialTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecuentialTime.Location = new System.Drawing.Point(109, 52);
            this.txtSecuentialTime.Name = "txtSecuentialTime";
            this.txtSecuentialTime.ReadOnly = true;
            this.txtSecuentialTime.Size = new System.Drawing.Size(205, 26);
            this.txtSecuentialTime.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 925);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSeekElement);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.btnInsercion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimeInsercion);
            this.Controls.Add(this.txtInsercion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimeQuick);
            this.Controls.Add(this.txtQuick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeBubble);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtArray;
        private System.Windows.Forms.RichTextBox txtOrden;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtTimeBubble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtQuick;
        private System.Windows.Forms.TextBox txtTimeQuick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsercion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimeInsercion;
        private System.Windows.Forms.RichTextBox txtInsercion;
        private System.Windows.Forms.Button btnBinarySearch;
        private System.Windows.Forms.TextBox txtSeekElement;
        private System.Windows.Forms.TextBox txtBinaryTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBinaryIndex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSecuentialIndex;
        private System.Windows.Forms.TextBox txtSecuentialTime;
    }
}

