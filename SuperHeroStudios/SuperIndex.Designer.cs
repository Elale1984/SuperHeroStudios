
namespace SuperHeroStudios
{
    partial class SuperIndex
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
            this.components = new System.ComponentModel.Container();
            this.lb_PoweredIndex = new System.Windows.Forms.ListBox();
            this.tb_IndexSelectedDetails = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.superIndexListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.superIndexListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_PoweredIndex
            // 
            this.lb_PoweredIndex.FormattingEnabled = true;
            this.lb_PoweredIndex.ItemHeight = 16;
            this.lb_PoweredIndex.Location = new System.Drawing.Point(35, 51);
            this.lb_PoweredIndex.Name = "lb_PoweredIndex";
            this.lb_PoweredIndex.Size = new System.Drawing.Size(173, 324);
            this.lb_PoweredIndex.TabIndex = 0;
            this.lb_PoweredIndex.SelectedIndexChanged += new System.EventHandler(this.lb_PoweredIndex_SelectedIndexChanged);
            // 
            // tb_IndexSelectedDetails
            // 
            this.tb_IndexSelectedDetails.Location = new System.Drawing.Point(236, 51);
            this.tb_IndexSelectedDetails.Multiline = true;
            this.tb_IndexSelectedDetails.Name = "tb_IndexSelectedDetails";
            this.tb_IndexSelectedDetails.Size = new System.Drawing.Size(435, 331);
            this.tb_IndexSelectedDetails.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // superIndexListBindingSource
            // 
            this.superIndexListBindingSource.DataSource = typeof(SuperHeroStudios.SuperIndexList);
            // 
            // SuperIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_IndexSelectedDetails);
            this.Controls.Add(this.lb_PoweredIndex);
            this.Name = "SuperIndex";
            this.Text = "SuperIndex";
            ((System.ComponentModel.ISupportInitialize)(this.superIndexListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_PoweredIndex;
        private System.Windows.Forms.TextBox tb_IndexSelectedDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource superIndexListBindingSource;
    }
}