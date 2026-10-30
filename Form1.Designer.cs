
namespace MasinIdareetme
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel road;
        private System.Windows.Forms.Panel controlPanel;

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;

        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.Label lblTime;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.road = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();

            this.btnStart = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();

            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // FORM
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(795, 675);
            this.Text = "Masin Idareetme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ROAD
            this.road.Location = new System.Drawing.Point(2, 12);
            this.road.Size = new System.Drawing.Size(333, 648);
            this.road.BackColor = System.Drawing.Color.DimGray;
            this.road.Paint += new System.Windows.Forms.PaintEventHandler(this.Road_Paint);

            // CONTROL PANEL
            this.controlPanel.Location = new System.Drawing.Point(335, 0);
            this.controlPanel.Size = new System.Drawing.Size(460, 675);
            this.controlPanel.BackColor = System.Drawing.Color.WhiteSmoke;

            // START
            this.btnStart.Text = "start";
            this.btnStart.Location = new System.Drawing.Point(165, 13);
            this.btnStart.Size = new System.Drawing.Size(73, 23);
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);

            // BREAK
            this.btnBreak.Text = "break";
            this.btnBreak.Location = new System.Drawing.Point(165, 86);
            this.btnBreak.Size = new System.Drawing.Size(73, 23);
            this.btnBreak.ForeColor = System.Drawing.Color.Red;
            this.btnBreak.BackColor = System.Drawing.Color.White;
            this.btnBreak.Click += new System.EventHandler(this.BtnBreak_Click);

            // UP
            this.btnUp.Text = "⬆";
            this.btnUp.Location = new System.Drawing.Point(152, 146);
            this.btnUp.Size = new System.Drawing.Size(100, 98);
            this.btnUp.Font = new System.Drawing.Font("Arial", 42, System.Drawing.FontStyle.Bold);
            this.btnUp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUp.BackColor = System.Drawing.Color.LightGray;
            this.btnUp.Click += (s, e) => MoveCar(0, -1);

            // LEFT
            this.btnLeft.Text = "⬅";
            this.btnLeft.Location = new System.Drawing.Point(33, 258);
            this.btnLeft.Size = new System.Drawing.Size(100, 98);
            this.btnLeft.Font = new System.Drawing.Font("Arial", 42, System.Drawing.FontStyle.Bold);
            this.btnLeft.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLeft.BackColor = System.Drawing.Color.LightGray;
            this.btnLeft.Click += (s, e) => MoveCar(-1, 0);

            // RIGHT
            this.btnRight.Text = "➡";
            this.btnRight.Location = new System.Drawing.Point(272, 258);
            this.btnRight.Size = new System.Drawing.Size(100, 98);
            this.btnRight.Font = new System.Drawing.Font("Arial", 42, System.Drawing.FontStyle.Bold);
            this.btnRight.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRight.BackColor = System.Drawing.Color.LightGray;
            this.btnRight.Click += (s, e) => MoveCar(1, 0);

            // DOWN
            this.btnDown.Text = "⬇";
            this.btnDown.Location = new System.Drawing.Point(152, 376);
            this.btnDown.Size = new System.Drawing.Size(100, 98);
            this.btnDown.Font = new System.Drawing.Font("Arial", 42, System.Drawing.FontStyle.Bold);
            this.btnDown.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDown.BackColor = System.Drawing.Color.LightGray;
            this.btnDown.Click += (s, e) => MoveCar(0, 1);

            // TIME LABEL
            this.lblTime.Text = "time";
            this.lblTime.Location = new System.Drawing.Point(185, 270);
            this.lblTime.Size = new System.Drawing.Size(70, 20);
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // COMBOBOX
            this.cmbSpeed.Location = new System.Drawing.Point(145, 289);
            this.cmbSpeed.Size = new System.Drawing.Size(120, 25);
            this.cmbSpeed.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbSpeed.Items.AddRange(new object[]
            {
                "30",
                "60",
                "90",
                "120"
            });

            this.cmbSpeed.SelectedIndex = 1;
            this.cmbSpeed.SelectedIndexChanged +=
                new System.EventHandler(this.CmbSpeed_SelectedIndexChanged);

            // EXIT
            this.btnExit.Text = "exit";
            this.btnExit.Location = new System.Drawing.Point(165, 555);
            this.btnExit.Size = new System.Drawing.Size(73, 23);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Click += (s, e) => this.Close();

            // CONTROLS
            this.controlPanel.Controls.Add(this.btnStart);
            this.controlPanel.Controls.Add(this.btnBreak);
            this.controlPanel.Controls.Add(this.btnUp);
            this.controlPanel.Controls.Add(this.btnDown);
            this.controlPanel.Controls.Add(this.btnLeft);
            this.controlPanel.Controls.Add(this.btnRight);
            this.controlPanel.Controls.Add(this.lblTime);
            this.controlPanel.Controls.Add(this.cmbSpeed);
            this.controlPanel.Controls.Add(this.btnExit);

            this.Controls.Add(this.road);
            this.Controls.Add(this.controlPanel);

            this.ResumeLayout(false);
        }
    }
}
