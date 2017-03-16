namespace LatestTest
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.dataGridViewC = new System.Windows.Forms.DataGridView();
            this.buttonIncreaseA = new System.Windows.Forms.Button();
            this.buttonDecreaseA = new System.Windows.Forms.Button();
            this.buttonIncreaseB = new System.Windows.Forms.Button();
            this.buttonDecreaseB = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.radioDouble = new System.Windows.Forms.RadioButton();
            this.radioString = new System.Windows.Forms.RadioButton();
            this.radioComplex = new System.Windows.Forms.RadioButton();
            this.groupBoxTypes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).BeginInit();
            this.groupBoxTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.Location = new System.Drawing.Point(61, 47);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowTemplate.Height = 24;
            this.dataGridViewA.Size = new System.Drawing.Size(298, 288);
            this.dataGridViewA.TabIndex = 0;
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Location = new System.Drawing.Point(592, 47);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowTemplate.Height = 24;
            this.dataGridViewB.Size = new System.Drawing.Size(298, 288);
            this.dataGridViewB.TabIndex = 1;
            // 
            // dataGridViewC
            // 
            this.dataGridViewC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewC.Location = new System.Drawing.Point(322, 461);
            this.dataGridViewC.Name = "dataGridViewC";
            this.dataGridViewC.RowTemplate.Height = 24;
            this.dataGridViewC.Size = new System.Drawing.Size(298, 288);
            this.dataGridViewC.TabIndex = 2;
            // 
            // buttonIncreaseA
            // 
            this.buttonIncreaseA.Location = new System.Drawing.Point(61, 377);
            this.buttonIncreaseA.Name = "buttonIncreaseA";
            this.buttonIncreaseA.Size = new System.Drawing.Size(42, 44);
            this.buttonIncreaseA.TabIndex = 3;
            this.buttonIncreaseA.Text = "+";
            this.buttonIncreaseA.UseVisualStyleBackColor = true;
            this.buttonIncreaseA.Click += new System.EventHandler(this.buttonIncreaseA_Click);
            // 
            // buttonDecreaseA
            // 
            this.buttonDecreaseA.Location = new System.Drawing.Point(109, 377);
            this.buttonDecreaseA.Name = "buttonDecreaseA";
            this.buttonDecreaseA.Size = new System.Drawing.Size(42, 44);
            this.buttonDecreaseA.TabIndex = 4;
            this.buttonDecreaseA.Text = "—";
            this.buttonDecreaseA.UseVisualStyleBackColor = true;
            this.buttonDecreaseA.Click += new System.EventHandler(this.buttonDecreaseA_Click);
            // 
            // buttonIncreaseB
            // 
            this.buttonIncreaseB.Location = new System.Drawing.Point(592, 377);
            this.buttonIncreaseB.Name = "buttonIncreaseB";
            this.buttonIncreaseB.Size = new System.Drawing.Size(42, 44);
            this.buttonIncreaseB.TabIndex = 5;
            this.buttonIncreaseB.Text = "+";
            this.buttonIncreaseB.UseVisualStyleBackColor = true;
            this.buttonIncreaseB.Click += new System.EventHandler(this.buttonIncreaseB_Click);
            // 
            // buttonDecreaseB
            // 
            this.buttonDecreaseB.Location = new System.Drawing.Point(640, 377);
            this.buttonDecreaseB.Name = "buttonDecreaseB";
            this.buttonDecreaseB.Size = new System.Drawing.Size(42, 44);
            this.buttonDecreaseB.TabIndex = 6;
            this.buttonDecreaseB.Text = "—";
            this.buttonDecreaseB.UseVisualStyleBackColor = true;
            this.buttonDecreaseB.Click += new System.EventHandler(this.buttonDecreaseB_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(437, 68);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 41);
            this.buttonPlus.TabIndex = 7;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(437, 115);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 41);
            this.buttonMinus.TabIndex = 8;
            this.buttonMinus.Text = "—";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(437, 162);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(75, 41);
            this.buttonMulti.TabIndex = 9;
            this.buttonMulti.Text = "X";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // radioDouble
            // 
            this.radioDouble.AutoSize = true;
            this.radioDouble.Checked = true;
            this.radioDouble.Location = new System.Drawing.Point(24, 21);
            this.radioDouble.Name = "radioDouble";
            this.radioDouble.Size = new System.Drawing.Size(72, 21);
            this.radioDouble.TabIndex = 10;
            this.radioDouble.TabStop = true;
            this.radioDouble.Text = "double";
            this.radioDouble.UseVisualStyleBackColor = true;
            // 
            // radioString
            // 
            this.radioString.AutoSize = true;
            this.radioString.Location = new System.Drawing.Point(24, 48);
            this.radioString.Name = "radioString";
            this.radioString.Size = new System.Drawing.Size(64, 21);
            this.radioString.TabIndex = 11;
            this.radioString.TabStop = true;
            this.radioString.Text = "string";
            this.radioString.UseVisualStyleBackColor = true;
            // 
            // radioComplex
            // 
            this.radioComplex.AutoSize = true;
            this.radioComplex.Location = new System.Drawing.Point(24, 75);
            this.radioComplex.Name = "radioComplex";
            this.radioComplex.Size = new System.Drawing.Size(80, 21);
            this.radioComplex.TabIndex = 12;
            this.radioComplex.TabStop = true;
            this.radioComplex.Text = "complex";
            this.radioComplex.UseVisualStyleBackColor = true;
            // 
            // groupBoxTypes
            // 
            this.groupBoxTypes.Controls.Add(this.radioComplex);
            this.groupBoxTypes.Controls.Add(this.radioDouble);
            this.groupBoxTypes.Controls.Add(this.radioString);
            this.groupBoxTypes.Location = new System.Drawing.Point(375, 222);
            this.groupBoxTypes.Name = "groupBoxTypes";
            this.groupBoxTypes.Size = new System.Drawing.Size(200, 113);
            this.groupBoxTypes.TabIndex = 13;
            this.groupBoxTypes.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 809);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDecreaseB);
            this.Controls.Add(this.buttonIncreaseB);
            this.Controls.Add(this.buttonDecreaseA);
            this.Controls.Add(this.buttonIncreaseA);
            this.Controls.Add(this.dataGridViewC);
            this.Controls.Add(this.dataGridViewB);
            this.Controls.Add(this.dataGridViewA);
            this.Controls.Add(this.groupBoxTypes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).EndInit();
            this.groupBoxTypes.ResumeLayout(false);
            this.groupBoxTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.DataGridView dataGridViewC;
        private System.Windows.Forms.Button buttonIncreaseA;
        private System.Windows.Forms.Button buttonDecreaseA;
        private System.Windows.Forms.Button buttonIncreaseB;
        private System.Windows.Forms.Button buttonDecreaseB;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.RadioButton radioDouble;
        private System.Windows.Forms.RadioButton radioString;
        private System.Windows.Forms.RadioButton radioComplex;
        private System.Windows.Forms.GroupBox groupBoxTypes;
    }
}

