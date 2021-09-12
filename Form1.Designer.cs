
namespace EJERCICIO_1_T1_EST
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eXAMENT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJERCICIO1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJERCICIO2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eJERCICIO3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXAMENT1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // eXAMENT1ToolStripMenuItem
            // 
            this.eXAMENT1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eJERCICIO1ToolStripMenuItem,
            this.eJERCICIO2ToolStripMenuItem,
            this.eJERCICIO3ToolStripMenuItem});
            this.eXAMENT1ToolStripMenuItem.Name = "eXAMENT1ToolStripMenuItem";
            this.eXAMENT1ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.eXAMENT1ToolStripMenuItem.Text = "EXAMEN T1";
            // 
            // eJERCICIO1ToolStripMenuItem
            // 
            this.eJERCICIO1ToolStripMenuItem.Name = "eJERCICIO1ToolStripMenuItem";
            this.eJERCICIO1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eJERCICIO1ToolStripMenuItem.Text = "EJERCICIO 1";
            this.eJERCICIO1ToolStripMenuItem.Click += new System.EventHandler(this.eJERCICIO1ToolStripMenuItem_Click);
            // 
            // eJERCICIO2ToolStripMenuItem
            // 
            this.eJERCICIO2ToolStripMenuItem.Name = "eJERCICIO2ToolStripMenuItem";
            this.eJERCICIO2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eJERCICIO2ToolStripMenuItem.Text = "EJERCICIO 2";
            this.eJERCICIO2ToolStripMenuItem.Click += new System.EventHandler(this.eJERCICIO2ToolStripMenuItem_Click);
            // 
            // eJERCICIO3ToolStripMenuItem
            // 
            this.eJERCICIO3ToolStripMenuItem.Name = "eJERCICIO3ToolStripMenuItem";
            this.eJERCICIO3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eJERCICIO3ToolStripMenuItem.Text = "EJERCICIO 3";
            this.eJERCICIO3ToolStripMenuItem.Click += new System.EventHandler(this.eJERCICIO3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 329);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eXAMENT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJERCICIO1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJERCICIO2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eJERCICIO3ToolStripMenuItem;
    }
}

