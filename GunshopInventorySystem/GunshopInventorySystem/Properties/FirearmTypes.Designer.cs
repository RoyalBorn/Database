
namespace GunshopInventorySystem.Properties
{
    partial class FirearmTypes
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
            this.Sidearm_DataV = new System.Windows.Forms.DataGridView();
            this.MainMen_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sidearm_DataV)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidearm_DataV
            // 
            this.Sidearm_DataV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sidearm_DataV.Location = new System.Drawing.Point(0, 0);
            this.Sidearm_DataV.Name = "Sidearm_DataV";
            this.Sidearm_DataV.Size = new System.Drawing.Size(800, 243);
            this.Sidearm_DataV.TabIndex = 32;
            // 
            // MainMen_Btn
            // 
            this.MainMen_Btn.BackgroundImage = global::GunshopInventorySystem.Properties.Resources.CAMO;
            this.MainMen_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMen_Btn.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMen_Btn.ForeColor = System.Drawing.Color.Gold;
            this.MainMen_Btn.Location = new System.Drawing.Point(322, 371);
            this.MainMen_Btn.Name = "MainMen_Btn";
            this.MainMen_Btn.Size = new System.Drawing.Size(179, 43);
            this.MainMen_Btn.TabIndex = 34;
            this.MainMen_Btn.Text = "Main Menu";
            this.MainMen_Btn.UseVisualStyleBackColor = true;
            // 
            // FirearmTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GunshopInventorySystem.Properties.Resources.CAMO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMen_Btn);
            this.Controls.Add(this.Sidearm_DataV);
            this.Name = "FirearmTypes";
            this.Text = "FirearmTypes";
            ((System.ComponentModel.ISupportInitialize)(this.Sidearm_DataV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Sidearm_DataV;
        private System.Windows.Forms.Button MainMen_Btn;
    }
}