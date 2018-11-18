namespace Mission2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demarrer = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervallemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.typeopmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.info = new System.Windows.Forms.ToolStripMenuItem();
            this.typeop = new System.Windows.Forms.GroupBox();
            this.multiplication = new System.Windows.Forms.RadioButton();
            this.soustraction = new System.Windows.Forms.RadioButton();
            this.addition = new System.Windows.Forms.RadioButton();
            this.intervalle = new System.Windows.Forms.GroupBox();
            this.interv4 = new System.Windows.Forms.RadioButton();
            this.interv3 = new System.Windows.Forms.RadioButton();
            this.interv2 = new System.Windows.Forms.RadioButton();
            this.interv1 = new System.Windows.Forms.RadioButton();
            this.apropos = new System.Windows.Forms.Label();
            this.site = new System.Windows.Forms.Label();
            this.suite = new System.Windows.Forms.Button();
            this.calcul = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.monScore = new System.Windows.Forms.Label();
            this.operationafaire = new System.Windows.Forms.Label();
            this.nb1 = new System.Windows.Forms.Label();
            this.nb2 = new System.Windows.Forms.Label();
            this.egal = new System.Windows.Forms.Label();
            this.resultat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.typeop.SuspendLayout();
            this.intervalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.info});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Que faire ?";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demarrer,
            this.quitterToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // demarrer
            // 
            this.demarrer.Name = "demarrer";
            this.demarrer.Size = new System.Drawing.Size(123, 22);
            this.demarrer.Text = "Démarrer";
            this.demarrer.Click += new System.EventHandler(this.demarrer_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervallemenu,
            this.typeopmenu});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.outilsToolStripMenuItem.Text = "Options";
            // 
            // intervallemenu
            // 
            this.intervallemenu.Name = "intervallemenu";
            this.intervallemenu.Size = new System.Drawing.Size(164, 22);
            this.intervallemenu.Text = "Intervalle";
            this.intervallemenu.Click += new System.EventHandler(this.intervallemenu_Click);
            // 
            // typeopmenu
            // 
            this.typeopmenu.Name = "typeopmenu";
            this.typeopmenu.Size = new System.Drawing.Size(164, 22);
            this.typeopmenu.Text = "Type D\'opération";
            this.typeopmenu.Click += new System.EventHandler(this.typeopmenu_Click);
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(67, 20);
            this.info.Text = "A Propos";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // typeop
            // 
            this.typeop.Controls.Add(this.multiplication);
            this.typeop.Controls.Add(this.soustraction);
            this.typeop.Controls.Add(this.addition);
            this.typeop.Location = new System.Drawing.Point(337, 310);
            this.typeop.Name = "typeop";
            this.typeop.Size = new System.Drawing.Size(103, 87);
            this.typeop.TabIndex = 2;
            this.typeop.TabStop = false;
            this.typeop.Text = "Type D\'opération";
            this.typeop.Visible = false;
            this.typeop.Enter += new System.EventHandler(this.typeop_Enter);
            // 
            // multiplication
            // 
            this.multiplication.AutoSize = true;
            this.multiplication.Location = new System.Drawing.Point(6, 64);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(86, 17);
            this.multiplication.TabIndex = 2;
            this.multiplication.TabStop = true;
            this.multiplication.Text = "Multiplication";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.CheckedChanged += new System.EventHandler(this.multiplication_CheckedChanged);
            // 
            // soustraction
            // 
            this.soustraction.AutoSize = true;
            this.soustraction.Location = new System.Drawing.Point(6, 42);
            this.soustraction.Name = "soustraction";
            this.soustraction.Size = new System.Drawing.Size(84, 17);
            this.soustraction.TabIndex = 1;
            this.soustraction.TabStop = true;
            this.soustraction.Text = "Soustraction";
            this.soustraction.UseVisualStyleBackColor = true;
            this.soustraction.CheckedChanged += new System.EventHandler(this.soustraction_CheckedChanged);
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Location = new System.Drawing.Point(6, 19);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(63, 17);
            this.addition.TabIndex = 0;
            this.addition.TabStop = true;
            this.addition.Text = "Addition";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.CheckedChanged += new System.EventHandler(this.addition_CheckedChanged);
            // 
            // intervalle
            // 
            this.intervalle.Controls.Add(this.interv4);
            this.intervalle.Controls.Add(this.interv3);
            this.intervalle.Controls.Add(this.interv2);
            this.intervalle.Controls.Add(this.interv1);
            this.intervalle.Location = new System.Drawing.Point(16, 285);
            this.intervalle.Name = "intervalle";
            this.intervalle.Size = new System.Drawing.Size(103, 112);
            this.intervalle.TabIndex = 3;
            this.intervalle.TabStop = false;
            this.intervalle.Text = "Intervalle";
            this.intervalle.Visible = false;
            this.intervalle.Enter += new System.EventHandler(this.intervalle_Enter);
            // 
            // interv4
            // 
            this.interv4.AutoSize = true;
            this.interv4.Location = new System.Drawing.Point(7, 85);
            this.interv4.Name = "interv4";
            this.interv4.Size = new System.Drawing.Size(55, 17);
            this.interv4.TabIndex = 11;
            this.interv4.TabStop = true;
            this.interv4.Text = "1 à 99";
            this.interv4.UseVisualStyleBackColor = true;
            this.interv4.CheckedChanged += new System.EventHandler(this.interv4_CheckedChanged);
            // 
            // interv3
            // 
            this.interv3.AutoSize = true;
            this.interv3.Location = new System.Drawing.Point(7, 65);
            this.interv3.Name = "interv3";
            this.interv3.Size = new System.Drawing.Size(55, 17);
            this.interv3.TabIndex = 10;
            this.interv3.TabStop = true;
            this.interv3.Text = "1 à 49";
            this.interv3.UseVisualStyleBackColor = true;
            this.interv3.CheckedChanged += new System.EventHandler(this.interv3_CheckedChanged);
            // 
            // interv2
            // 
            this.interv2.AutoSize = true;
            this.interv2.Location = new System.Drawing.Point(6, 42);
            this.interv2.Name = "interv2";
            this.interv2.Size = new System.Drawing.Size(55, 17);
            this.interv2.TabIndex = 9;
            this.interv2.TabStop = true;
            this.interv2.Text = "1 à 19";
            this.interv2.UseVisualStyleBackColor = true;
            this.interv2.CheckedChanged += new System.EventHandler(this.interv2_CheckedChanged);
            // 
            // interv1
            // 
            this.interv1.AutoSize = true;
            this.interv1.Location = new System.Drawing.Point(6, 19);
            this.interv1.Name = "interv1";
            this.interv1.Size = new System.Drawing.Size(49, 17);
            this.interv1.TabIndex = 8;
            this.interv1.TabStop = true;
            this.interv1.Text = "1 à 9";
            this.interv1.UseVisualStyleBackColor = true;
            this.interv1.CheckedChanged += new System.EventHandler(this.interv1_CheckedChanged_1);
            // 
            // apropos
            // 
            this.apropos.AllowDrop = true;
            this.apropos.AutoSize = true;
            this.apropos.BackColor = System.Drawing.Color.Transparent;
            this.apropos.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apropos.ForeColor = System.Drawing.Color.Red;
            this.apropos.Location = new System.Drawing.Point(12, 90);
            this.apropos.Name = "apropos";
            this.apropos.Size = new System.Drawing.Size(426, 115);
            this.apropos.TabIndex = 4;
            this.apropos.Text = "Cette application à était réaliser par Théodore Follet.\r\nCelle-ci est une applica" +
    "tion à but éducation,\r\nElle est adapté pour des enfants en classe de \r\nCP - CE1 " +
    "- CE2.\r\n\r\n";
            this.apropos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.apropos.Visible = false;
            this.apropos.Click += new System.EventHandler(this.apropos_Click);
            // 
            // site
            // 
            this.site.AutoSize = true;
            this.site.BackColor = System.Drawing.Color.Transparent;
            this.site.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.site.ForeColor = System.Drawing.Color.Peru;
            this.site.Location = new System.Drawing.Point(39, 244);
            this.site.Name = "site";
            this.site.Size = new System.Drawing.Size(374, 115);
            this.site.TabIndex = 5;
            this.site.Text = "Site vous désirez visitez mon site internet pour \r\nvoir mes autres créations\r\nou " +
    "bien me rejoindre sur mes réseaux sociaux, \r\nrendez vous sur https://ninjawaza.d" +
    "yjix.fr/\r\n\r\n";
            this.site.Visible = false;
            this.site.Click += new System.EventHandler(this.site_Click);
            // 
            // suite
            // 
            this.suite.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.suite.FlatAppearance.BorderSize = 10;
            this.suite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.suite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.suite.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suite.ForeColor = System.Drawing.Color.Peru;
            this.suite.Location = new System.Drawing.Point(93, 264);
            this.suite.Name = "suite";
            this.suite.Size = new System.Drawing.Size(250, 57);
            this.suite.TabIndex = 6;
            this.suite.Text = "En savoir plus";
            this.suite.UseVisualStyleBackColor = true;
            this.suite.Visible = false;
            this.suite.Click += new System.EventHandler(this.suite_Click);
            // 
            // calcul
            // 
            this.calcul.AutoSize = true;
            this.calcul.Location = new System.Drawing.Point(90, 144);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(13, 13);
            this.calcul.TabIndex = 7;
            this.calcul.Text = "0";
            this.calcul.Visible = false;
            this.calcul.Click += new System.EventHandler(this.calcul_Click);
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(180, 235);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 8;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Visible = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // monScore
            // 
            this.monScore.AutoSize = true;
            this.monScore.BackColor = System.Drawing.Color.Transparent;
            this.monScore.ForeColor = System.Drawing.Color.White;
            this.monScore.Location = new System.Drawing.Point(209, 363);
            this.monScore.Name = "monScore";
            this.monScore.Size = new System.Drawing.Size(36, 13);
            this.monScore.TabIndex = 9;
            this.monScore.Text = "0 / 10";
            this.monScore.Click += new System.EventHandler(this.monScore_Click);
            // 
            // operationafaire
            // 
            this.operationafaire.AutoSize = true;
            this.operationafaire.BackColor = System.Drawing.Color.Transparent;
            this.operationafaire.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationafaire.ForeColor = System.Drawing.Color.Maroon;
            this.operationafaire.Location = new System.Drawing.Point(173, 35);
            this.operationafaire.Name = "operationafaire";
            this.operationafaire.Size = new System.Drawing.Size(156, 39);
            this.operationafaire.TabIndex = 10;
            this.operationafaire.Text = "Que faire ?";
            this.operationafaire.Click += new System.EventHandler(this.operationafaire_Click);
            // 
            // nb1
            // 
            this.nb1.AutoSize = true;
            this.nb1.Location = new System.Drawing.Point(68, 144);
            this.nb1.Name = "nb1";
            this.nb1.Size = new System.Drawing.Size(35, 13);
            this.nb1.TabIndex = 12;
            this.nb1.Text = "label1";
            this.nb1.Click += new System.EventHandler(this.nb1_Click);
            // 
            // nb2
            // 
            this.nb2.AutoSize = true;
            this.nb2.Location = new System.Drawing.Point(109, 144);
            this.nb2.Name = "nb2";
            this.nb2.Size = new System.Drawing.Size(35, 13);
            this.nb2.TabIndex = 13;
            this.nb2.Text = "label2";
            this.nb2.Click += new System.EventHandler(this.nb2_Click);
            // 
            // egal
            // 
            this.egal.AutoSize = true;
            this.egal.Location = new System.Drawing.Point(131, 144);
            this.egal.Name = "egal";
            this.egal.Size = new System.Drawing.Size(22, 13);
            this.egal.TabIndex = 14;
            this.egal.Text = "= ?";
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.Location = new System.Drawing.Point(195, 192);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(46, 13);
            this.resultat.TabIndex = 15;
            this.resultat.Text = "Résultat";
            this.resultat.Click += new System.EventHandler(this.resultat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 409);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.egal);
            this.Controls.Add(this.nb2);
            this.Controls.Add(this.nb1);
            this.Controls.Add(this.operationafaire);
            this.Controls.Add(this.monScore);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.calcul);
            this.Controls.Add(this.intervalle);
            this.Controls.Add(this.typeop);
            this.Controls.Add(this.suite);
            this.Controls.Add(this.site);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.apropos);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CalculFolletTheodore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.typeop.ResumeLayout(false);
            this.typeop.PerformLayout();
            this.intervalle.ResumeLayout(false);
            this.intervalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demarrer;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervallemenu;
        private System.Windows.Forms.ToolStripMenuItem typeopmenu;
        private System.Windows.Forms.ToolStripMenuItem info;
        private System.Windows.Forms.GroupBox typeop;
        private System.Windows.Forms.GroupBox intervalle;
        private System.Windows.Forms.Label apropos;
        private System.Windows.Forms.Label site;
        private System.Windows.Forms.Button suite;
        private System.Windows.Forms.Label calcul;
        private System.Windows.Forms.RadioButton interv1;
        private System.Windows.Forms.RadioButton interv2;
        private System.Windows.Forms.RadioButton interv4;
        private System.Windows.Forms.RadioButton interv3;
        private System.Windows.Forms.RadioButton multiplication;
        private System.Windows.Forms.RadioButton soustraction;
        private System.Windows.Forms.RadioButton addition;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Label monScore;
        private System.Windows.Forms.Label operationafaire;
        private System.Windows.Forms.Label nb1;
        private System.Windows.Forms.Label nb2;
        private System.Windows.Forms.Label egal;
        private System.Windows.Forms.Label resultat;
    }
}

