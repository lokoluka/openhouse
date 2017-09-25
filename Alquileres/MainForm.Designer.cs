namespace Alquileres
{
    partial class main_Lease
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
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.tab_Contracts = new System.Windows.Forms.TabPage();
            this.tab_Owners = new System.Windows.Forms.TabPage();
            this.tab_Property = new System.Windows.Forms.TabPage();
            this.tab_Inquilino = new System.Windows.Forms.TabPage();
            this.tab_Charges = new System.Windows.Forms.TabPage();
            this.mainTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.tab_Contracts);
            this.mainTabs.Controls.Add(this.tab_Owners);
            this.mainTabs.Controls.Add(this.tab_Property);
            this.mainTabs.Controls.Add(this.tab_Inquilino);
            this.mainTabs.Controls.Add(this.tab_Charges);
            this.mainTabs.Location = new System.Drawing.Point(12, 12);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1247, 565);
            this.mainTabs.TabIndex = 0;
            // 
            // tab_Contracts
            // 
            this.tab_Contracts.Location = new System.Drawing.Point(4, 25);
            this.tab_Contracts.Name = "tab_Contracts";
            this.tab_Contracts.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Contracts.Size = new System.Drawing.Size(1239, 536);
            this.tab_Contracts.TabIndex = 0;
            this.tab_Contracts.Text = "Contratos";
            this.tab_Contracts.UseVisualStyleBackColor = true;
            // 
            // tab_Owners
            // 
            this.tab_Owners.Location = new System.Drawing.Point(4, 25);
            this.tab_Owners.Name = "tab_Owners";
            this.tab_Owners.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Owners.Size = new System.Drawing.Size(1239, 536);
            this.tab_Owners.TabIndex = 1;
            this.tab_Owners.Text = "Propietarios";
            this.tab_Owners.UseVisualStyleBackColor = true;
            // 
            // tab_Property
            // 
            this.tab_Property.Location = new System.Drawing.Point(4, 25);
            this.tab_Property.Name = "tab_Property";
            this.tab_Property.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Property.Size = new System.Drawing.Size(1239, 536);
            this.tab_Property.TabIndex = 2;
            this.tab_Property.Text = "Propiedades";
            this.tab_Property.UseVisualStyleBackColor = true;
            // 
            // tab_Inquilino
            // 
            this.tab_Inquilino.Location = new System.Drawing.Point(4, 25);
            this.tab_Inquilino.Name = "tab_Inquilino";
            this.tab_Inquilino.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Inquilino.Size = new System.Drawing.Size(1239, 536);
            this.tab_Inquilino.TabIndex = 3;
            this.tab_Inquilino.Text = "Inquilinos";
            this.tab_Inquilino.UseVisualStyleBackColor = true;
            // 
            // tab_Charges
            // 
            this.tab_Charges.Location = new System.Drawing.Point(4, 25);
            this.tab_Charges.Name = "tab_Charges";
            this.tab_Charges.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Charges.Size = new System.Drawing.Size(1239, 536);
            this.tab_Charges.TabIndex = 4;
            this.tab_Charges.Text = "Cargos";
            this.tab_Charges.UseVisualStyleBackColor = true;
            // 
            // main_Lease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 589);
            this.Controls.Add(this.mainTabs);
            this.Name = "main_Lease";
            this.Text = "Alquileres v0.1";
            this.Load += new System.EventHandler(this.main_Lease_Load);
            this.mainTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage tab_Contracts;
        private System.Windows.Forms.TabPage tab_Owners;
        private System.Windows.Forms.TabPage tab_Property;
        private System.Windows.Forms.TabPage tab_Inquilino;
        private System.Windows.Forms.TabPage tab_Charges;
    }
}

