namespace Como_esta_o_clima_ai
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCity = new TextBox();
            btnGetWeather = new Button();
            lblWeatherInfo = new Label();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Location = new Point(42, 47);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(705, 110);
            txtCity.TabIndex = 0;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(522, 163);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(225, 95);
            btnGetWeather.TabIndex = 1;
            btnGetWeather.Text = "button1";
            btnGetWeather.UseVisualStyleBackColor = true;
            // 
            // lblWeatherInfo
            // 
            lblWeatherInfo.AutoSize = true;
            lblWeatherInfo.Location = new Point(34, 179);
            lblWeatherInfo.Name = "lblWeatherInfo";
            lblWeatherInfo.Size = new Size(45, 19);
            lblWeatherInfo.TabIndex = 2;
            lblWeatherInfo.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWeatherInfo);
            Controls.Add(btnGetWeather);
            Controls.Add(txtCity);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCity;
        private Button btnGetWeather;
        private Label lblWeatherInfo;
    }
}
