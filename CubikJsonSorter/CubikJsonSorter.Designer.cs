namespace CubikJsonSorter
{
    partial class CubikJsonSorter
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ofd_button = new System.Windows.Forms.Button();
            this.ofd_txtbox = new System.Windows.Forms.TextBox();
            this.savepath_txtbox = new System.Windows.Forms.TextBox();
            this.savepath_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.color_txtbox = new System.Windows.Forms.TextBox();
            this.addcolor_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.color_listview = new System.Windows.Forms.ListView();
            this.result_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ofd_button
            // 
            this.ofd_button.Location = new System.Drawing.Point(452, 41);
            this.ofd_button.Name = "ofd_button";
            this.ofd_button.Size = new System.Drawing.Size(101, 32);
            this.ofd_button.TabIndex = 0;
            this.ofd_button.Text = "select a json";
            this.ofd_button.UseVisualStyleBackColor = true;
            this.ofd_button.Click += new System.EventHandler(this.ofd_button_Click);
            // 
            // ofd_txtbox
            // 
            this.ofd_txtbox.Location = new System.Drawing.Point(31, 46);
            this.ofd_txtbox.Name = "ofd_txtbox";
            this.ofd_txtbox.Size = new System.Drawing.Size(400, 22);
            this.ofd_txtbox.TabIndex = 1;
            // 
            // savepath_txtbox
            // 
            this.savepath_txtbox.Location = new System.Drawing.Point(31, 84);
            this.savepath_txtbox.Name = "savepath_txtbox";
            this.savepath_txtbox.Size = new System.Drawing.Size(400, 22);
            this.savepath_txtbox.TabIndex = 2;
            // 
            // savepath_button
            // 
            this.savepath_button.Location = new System.Drawing.Point(452, 79);
            this.savepath_button.Name = "savepath_button";
            this.savepath_button.Size = new System.Drawing.Size(101, 32);
            this.savepath_button.TabIndex = 3;
            this.savepath_button.Text = "save path";
            this.savepath_button.UseVisualStyleBackColor = true;
            this.savepath_button.Click += new System.EventHandler(this.savepath_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Launch sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // color_txtbox
            // 
            this.color_txtbox.Location = new System.Drawing.Point(89, 179);
            this.color_txtbox.Name = "color_txtbox";
            this.color_txtbox.Size = new System.Drawing.Size(141, 22);
            this.color_txtbox.TabIndex = 5;
            // 
            // addcolor_button
            // 
            this.addcolor_button.Location = new System.Drawing.Point(252, 179);
            this.addcolor_button.Name = "addcolor_button";
            this.addcolor_button.Size = new System.Drawing.Size(75, 23);
            this.addcolor_button.TabIndex = 6;
            this.addcolor_button.Text = "Add color";
            this.addcolor_button.UseVisualStyleBackColor = true;
            this.addcolor_button.Click += new System.EventHandler(this.addcolor_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(252, 218);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transparent color";
            // 
            // color_listview
            // 
            this.color_listview.HideSelection = false;
            this.color_listview.Location = new System.Drawing.Point(89, 218);
            this.color_listview.Name = "color_listview";
            this.color_listview.Size = new System.Drawing.Size(141, 220);
            this.color_listview.TabIndex = 10;
            this.color_listview.UseCompatibleStateImageBehavior = false;
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Location = new System.Drawing.Point(349, 368);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(0, 17);
            this.result_lbl.TabIndex = 11;
            // 
            // CubikJsonSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.color_listview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.addcolor_button);
            this.Controls.Add(this.color_txtbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savepath_button);
            this.Controls.Add(this.savepath_txtbox);
            this.Controls.Add(this.ofd_txtbox);
            this.Controls.Add(this.ofd_button);
            this.Name = "CubikJsonSorter";
            this.Text = "CubikJsonSorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ofd_button;
        private System.Windows.Forms.TextBox ofd_txtbox;
        private System.Windows.Forms.TextBox savepath_txtbox;
        private System.Windows.Forms.Button savepath_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox color_txtbox;
        private System.Windows.Forms.Button addcolor_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView color_listview;
        private System.Windows.Forms.Label result_lbl;
    }
}

