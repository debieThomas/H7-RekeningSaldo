﻿namespace frmRekeningSaldo
{
    partial class frmRekeningSaldo
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
            this.lblStandText = new System.Windows.Forms.Label();
            this.lblStand = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lstVerrichtingen = new System.Windows.Forms.ListBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.txtBedrag = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStandText
            // 
            this.lblStandText.AutoSize = true;
            this.lblStandText.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandText.Location = new System.Drawing.Point(342, 15);
            this.lblStandText.Name = "lblStandText";
            this.lblStandText.Size = new System.Drawing.Size(89, 17);
            this.lblStandText.TabIndex = 6;
            this.lblStandText.Text = "Rekeningstand:";
            // 
            // lblStand
            // 
            this.lblStand.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStand.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblStand.Location = new System.Drawing.Point(302, 37);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(181, 35);
            this.lblStand.TabIndex = 7;
            this.lblStand.Text = "€0,00";
            this.lblStand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(302, 83);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(181, 89);
            this.btnToevoegen.TabIndex = 4;
            this.btnToevoegen.Text = "Voeg verrichting toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lstVerrichtingen
            // 
            this.lstVerrichtingen.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVerrichtingen.FormattingEnabled = true;
            this.lstVerrichtingen.ItemHeight = 15;
            this.lstVerrichtingen.Location = new System.Drawing.Point(13, 12);
            this.lstVerrichtingen.Name = "lstVerrichtingen";
            this.lstVerrichtingen.Size = new System.Drawing.Size(275, 154);
            this.lstVerrichtingen.TabIndex = 5;
            this.lstVerrichtingen.TabStop = false;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmschrijving.Location = new System.Drawing.Point(14, 186);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(144, 15);
            this.lblOmschrijving.TabIndex = 8;
            this.lblOmschrijving.Text = "Voeg een omschrijving toe:";
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedrag.Location = new System.Drawing.Point(14, 253);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(213, 15);
            this.lblBedrag.TabIndex = 10;
            this.lblBedrag.Text = "Geef het bedrag in (eventueel negatief):";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(14, 219);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(151, 15);
            this.lblDatum.TabIndex = 9;
            this.lblDatum.Text = "Geef de datum (jjjj/mm/dd):";
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOmschrijving.Location = new System.Drawing.Point(189, 182);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(293, 23);
            this.txtOmschrijving.TabIndex = 1;
            // 
            // txtBedrag
            // 
            this.txtBedrag.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedrag.Location = new System.Drawing.Point(269, 249);
            this.txtBedrag.Name = "txtBedrag";
            this.txtBedrag.Size = new System.Drawing.Size(213, 23);
            this.txtBedrag.TabIndex = 3;
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(197, 216);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(285, 23);
            this.txtDatum.TabIndex = 2;
            // 
            // frmRekeningSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 287);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtBedrag);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblBedrag);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.lstVerrichtingen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.lblStandText);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmRekeningSaldo";
            this.Text = "Rekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStandText;
        private System.Windows.Forms.Label lblStand;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ListBox lstVerrichtingen;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.TextBox txtBedrag;
        private System.Windows.Forms.TextBox txtDatum;
    }
}

