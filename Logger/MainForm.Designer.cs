
namespace Logger
{
    partial class MainForm
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
            this.sayHelloButton = new System.Windows.Forms.Button();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.inputColorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputLogListView = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sayHelloButton
            // 
            this.sayHelloButton.Location = new System.Drawing.Point(303, 135);
            this.sayHelloButton.Name = "sayHelloButton";
            this.sayHelloButton.Size = new System.Drawing.Size(195, 51);
            this.sayHelloButton.TabIndex = 0;
            this.sayHelloButton.Text = "Print";
            this.sayHelloButton.UseVisualStyleBackColor = true;
            this.sayHelloButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(119, 71);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(304, 26);
            this.userInputTextBox.TabIndex = 2;
            // 
            // inputColorComboBox
            // 
            this.inputColorComboBox.FormattingEnabled = true;
            this.inputColorComboBox.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul"});
            this.inputColorComboBox.Location = new System.Drawing.Point(516, 71);
            this.inputColorComboBox.Name = "inputColorComboBox";
            this.inputColorComboBox.Size = new System.Drawing.Size(121, 28);
            this.inputColorComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(95, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 185);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputLogListView);
            this.groupBox2.Location = new System.Drawing.Point(95, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 185);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // inputLogListView
            // 
            this.inputLogListView.HideSelection = false;
            this.inputLogListView.Location = new System.Drawing.Point(24, 40);
            this.inputLogListView.Name = "inputLogListView";
            this.inputLogListView.Size = new System.Drawing.Size(555, 121);
            this.inputLogListView.TabIndex = 0;
            this.inputLogListView.UseCompatibleStateImageBehavior = false;
            this.inputLogListView.View = System.Windows.Forms.View.List;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputColorComboBox);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.sayHelloButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Ejemplo WinForms";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sayHelloButton;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.ComboBox inputColorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView inputLogListView;
    }
}

