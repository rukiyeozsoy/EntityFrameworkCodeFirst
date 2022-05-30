
namespace EntityCodeFirst
{
    partial class Giris
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
            this.urunlersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityCodeFirstDataSet = new EntityCodeFirst.EntityCodeFirstDataSet();
            this.urunlersTableAdapter = new EntityCodeFirst.EntityCodeFirstDataSetTableAdapters.UrunlersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urunlersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityCodeFirstDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // urunlersBindingSource
            // 
            this.urunlersBindingSource.DataMember = "Urunlers";
            this.urunlersBindingSource.DataSource = this.entityCodeFirstDataSet;
            // 
            // entityCodeFirstDataSet
            // 
            this.entityCodeFirstDataSet.DataSetName = "EntityCodeFirstDataSet";
            this.entityCodeFirstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlersTableAdapter
            // 
            this.urunlersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(27, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürünler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(27, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 98);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşteriler";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(27, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 98);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tedarikçiler";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityCodeFirstDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EntityCodeFirstDataSet entityCodeFirstDataSet;
        private System.Windows.Forms.BindingSource urunlersBindingSource;
        private EntityCodeFirstDataSetTableAdapters.UrunlersTableAdapter urunlersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

