namespace _4_Way_Movement_with_Sprite_Images_MOO_ICT
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
            this.components = new System.ComponentModel.Container();
            this.lblMovement = new System.Windows.Forms.Label();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCollected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.BackColor = System.Drawing.Color.Transparent;
            this.lblMovement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMovement.ForeColor = System.Drawing.Color.Coral;
            this.lblMovement.Location = new System.Drawing.Point(10, 563);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(151, 32);
            this.lblMovement.TabIndex = 0;
            this.lblMovement.Text = "Movement: ";
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 20;
            this.movementTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // lblCollected
            // 
            this.lblCollected.BackColor = System.Drawing.Color.Transparent;
            this.lblCollected.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCollected.ForeColor = System.Drawing.Color.Coral;
            this.lblCollected.Location = new System.Drawing.Point(397, 563);
            this.lblCollected.Name = "lblCollected";
            this.lblCollected.Size = new System.Drawing.Size(437, 32);
            this.lblCollected.TabIndex = 1;
            this.lblCollected.Text = "Collected: 00";
            this.lblCollected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.lblCollected);
            this.Controls.Add(this.lblMovement);
            this.Name = "Form1";
            this.Text = "4 Way Sprite Animation  MOO ICT";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMovement;
        private System.Windows.Forms.Timer movementTimer;
        private Label lblCollected;
    }
}