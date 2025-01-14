namespace UiAgenda
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            finaceiroToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            panel2 = new Panel();
            lstAgenda = new ListBox();
            monthCalendar1 = new MonthCalendar();
            panel4 = new Panel();
            tabControl1 = new TabControl();
            tabHome = new TabPage();
            panel5 = new Panel();
            tabAgenda = new TabPage();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            panel7 = new Panel();
            tarefasToolStripMenuItem = new ToolStripMenuItem();
            eventosToolStripMenuItem = new ToolStripMenuItem();
            lembretesToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            depsesasToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            requisiçõesToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabHome.SuspendLayout();
            tabAgenda.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { agendaToolStripMenuItem, finaceiroToolStripMenuItem, configuraçõesToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1145, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tarefasToolStripMenuItem, eventosToolStripMenuItem, lembretesToolStripMenuItem, notasToolStripMenuItem });
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(60, 20);
            agendaToolStripMenuItem.Text = "Agenda";
            // 
            // finaceiroToolStripMenuItem
            // 
            finaceiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depsesasToolStripMenuItem, comprasToolStripMenuItem, requisiçõesToolStripMenuItem });
            finaceiroToolStripMenuItem.Name = "finaceiroToolStripMenuItem";
            finaceiroToolStripMenuItem.Size = new Size(74, 20);
            finaceiroToolStripMenuItem.Text = "Financeiro";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem1 });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(50, 20);
            sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 663);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1145, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            panel2.Controls.Add(lstAgenda);
            panel2.Controls.Add(monthCalendar1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 639);
            panel2.TabIndex = 3;
            // 
            // lstAgenda
            // 
            lstAgenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstAgenda.FormattingEnabled = true;
            lstAgenda.ItemHeight = 15;
            lstAgenda.Items.AddRange(new object[] { "TAREFAS:", "EVENTOS:", "LEMBRETES:", "NOTAS:" });
            lstAgenda.Location = new Point(12, 183);
            lstAgenda.Name = "lstAgenda";
            lstAgenda.Size = new Size(226, 439);
            lstAgenda.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(11, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(tabControl1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(247, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(898, 639);
            panel4.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabHome);
            tabControl1.Controls.Add(tabAgenda);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(898, 639);
            tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(panel5);
            tabHome.Location = new Point(4, 24);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(890, 611);
            tabHome.TabIndex = 0;
            tabHome.Text = "HOME";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.WindowFrame;
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(884, 605);
            panel5.TabIndex = 1;
            // 
            // tabAgenda
            // 
            tabAgenda.Controls.Add(panel6);
            tabAgenda.Controls.Add(panel7);
            tabAgenda.Location = new Point(4, 24);
            tabAgenda.Name = "tabAgenda";
            tabAgenda.Padding = new Padding(3);
            tabAgenda.Size = new Size(890, 611);
            tabAgenda.TabIndex = 1;
            tabAgenda.Text = "AGENDA";
            tabAgenda.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDarkDark;
            panel6.Controls.Add(dataGridView1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 103);
            panel6.Name = "panel6";
            panel6.Size = new Size(884, 505);
            panel6.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(884, 505);
            dataGridView1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(884, 100);
            panel7.TabIndex = 2;
            // 
            // tarefasToolStripMenuItem
            // 
            tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            tarefasToolStripMenuItem.Size = new Size(180, 22);
            tarefasToolStripMenuItem.Text = "Tarefas";
            // 
            // eventosToolStripMenuItem
            // 
            eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            eventosToolStripMenuItem.Size = new Size(180, 22);
            eventosToolStripMenuItem.Text = "Eventos";
            // 
            // lembretesToolStripMenuItem
            // 
            lembretesToolStripMenuItem.Name = "lembretesToolStripMenuItem";
            lembretesToolStripMenuItem.Size = new Size(180, 22);
            lembretesToolStripMenuItem.Text = "Lembretes";
            // 
            // notasToolStripMenuItem
            // 
            notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            notasToolStripMenuItem.Size = new Size(180, 22);
            notasToolStripMenuItem.Text = "Notas";
            // 
            // depsesasToolStripMenuItem
            // 
            depsesasToolStripMenuItem.Name = "depsesasToolStripMenuItem";
            depsesasToolStripMenuItem.Size = new Size(180, 22);
            depsesasToolStripMenuItem.Text = "Depsesas";
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(180, 22);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // requisiçõesToolStripMenuItem
            // 
            requisiçõesToolStripMenuItem.Name = "requisiçõesToolStripMenuItem";
            requisiçõesToolStripMenuItem.Size = new Size(180, 22);
            requisiçõesToolStripMenuItem.Text = "Requisições";
            // 
            // sobreToolStripMenuItem1
            // 
            sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            sobreToolStripMenuItem1.Size = new Size(180, 22);
            sobreToolStripMenuItem1.Text = "Sobre";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 685);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Agenda 2025";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabAgenda.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private ToolStripMenuItem finaceiroToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private StatusStrip statusStrip1;
        private Panel panel2;
        private MonthCalendar monthCalendar1;
        private Panel panel4;
        private TabControl tabControl1;
        private TabPage tabHome;
        private TabPage tabAgenda;
        private ListBox lstAgenda;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private DataGridView dataGridView1;
        private ToolStripMenuItem tarefasToolStripMenuItem;
        private ToolStripMenuItem eventosToolStripMenuItem;
        private ToolStripMenuItem lembretesToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem depsesasToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem requisiçõesToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem1;
    }
}
