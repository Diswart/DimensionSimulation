namespace DimensionSimulation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputVertices = new System.Windows.Forms.TextBox();
            this.inputDimensions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.verticesList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.neighborsList = new System.Windows.Forms.ListBox();
            this.generate = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.TextBox();
            this.findPath = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.resultingPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputPercent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число вершин в одном измерении:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число измерений:";
            // 
            // inputVertices
            // 
            this.inputVertices.Location = new System.Drawing.Point(205, 10);
            this.inputVertices.Name = "inputVertices";
            this.inputVertices.Size = new System.Drawing.Size(27, 20);
            this.inputVertices.TabIndex = 2;
            // 
            // inputDimensions
            // 
            this.inputDimensions.Location = new System.Drawing.Point(366, 10);
            this.inputDimensions.Name = "inputDimensions";
            this.inputDimensions.Size = new System.Drawing.Size(24, 20);
            this.inputDimensions.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Список вершин:";
            // 
            // verticesList
            // 
            this.verticesList.FormattingEnabled = true;
            this.verticesList.Location = new System.Drawing.Point(19, 126);
            this.verticesList.Name = "verticesList";
            this.verticesList.Size = new System.Drawing.Size(244, 394);
            this.verticesList.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Список соседей каждой вершины:";
            // 
            // neighborsList
            // 
            this.neighborsList.FormattingEnabled = true;
            this.neighborsList.Location = new System.Drawing.Point(299, 126);
            this.neighborsList.Name = "neighborsList";
            this.neighborsList.Size = new System.Drawing.Size(371, 394);
            this.neighborsList.TabIndex = 7;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(526, 10);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(144, 23);
            this.generate.TabIndex = 8;
            this.generate.Text = "Сгенерировать граф";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(615, 585);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 9;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Найти путь от вершины №";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(165, 541);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(24, 20);
            this.start.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "до вершины №";
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(285, 541);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(29, 20);
            this.finish.TabIndex = 13;
            // 
            // findPath
            // 
            this.findPath.Location = new System.Drawing.Point(340, 538);
            this.findPath.Name = "findPath";
            this.findPath.Size = new System.Drawing.Size(75, 23);
            this.findPath.TabIndex = 14;
            this.findPath.Text = "Найти";
            this.findPath.UseVisualStyleBackColor = true;
            this.findPath.Click += new System.EventHandler(this.findPath_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 585);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Путь:";
            // 
            // resultingPath
            // 
            this.resultingPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultingPath.Location = new System.Drawing.Point(62, 582);
            this.resultingPath.Name = "resultingPath";
            this.resultingPath.ReadOnly = true;
            this.resultingPath.Size = new System.Drawing.Size(136, 20);
            this.resultingPath.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Вероятность генерации связи:";
            // 
            // inputPercent
            // 
            this.inputPercent.Location = new System.Drawing.Point(187, 50);
            this.inputPercent.Name = "inputPercent";
            this.inputPercent.Size = new System.Drawing.Size(30, 20);
            this.inputPercent.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(420, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Вероятность от 0 до 1. Вводить число необходимо через запятую (например: 0,3)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 622);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inputPercent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultingPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.findPath);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.neighborsList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.verticesList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputDimensions);
            this.Controls.Add(this.inputVertices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Генератор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputVertices;
        private System.Windows.Forms.TextBox inputDimensions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox verticesList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox neighborsList;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox finish;
        private System.Windows.Forms.Button findPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultingPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputPercent;
        private System.Windows.Forms.Label label9;
    }
}

