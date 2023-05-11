namespace Pokedex
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            pokedexTabPage = new TabPage();
            panel1 = new Panel();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnNextPage = new MaterialSkin.Controls.MaterialFloatingActionButton();
            btnPreviousPage = new MaterialSkin.Controls.MaterialFloatingActionButton();
            imageList = new ImageList(components);
            materialTabControl.SuspendLayout();
            pokedexTabPage.SuspendLayout();
            panel1.SuspendLayout();
            materialCard7.SuspendLayout();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Controls.Add(pokedexTabPage);
            materialTabControl.Depth = 0;
            materialTabControl.Dock = DockStyle.Fill;
            materialTabControl.ImageList = imageList;
            materialTabControl.Location = new Point(0, 64);
            materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl.Multiline = true;
            materialTabControl.Name = "materialTabControl";
            materialTabControl.SelectedIndex = 0;
            materialTabControl.Size = new Size(967, 561);
            materialTabControl.TabIndex = 0;
            // 
            // pokedexTabPage
            // 
            pokedexTabPage.AutoScroll = true;
            pokedexTabPage.Controls.Add(panel1);
            pokedexTabPage.Controls.Add(materialCard6);
            pokedexTabPage.Controls.Add(materialCard5);
            pokedexTabPage.Controls.Add(materialCard4);
            pokedexTabPage.Controls.Add(materialCard3);
            pokedexTabPage.Controls.Add(materialCard2);
            pokedexTabPage.Controls.Add(materialCard1);
            pokedexTabPage.Controls.Add(btnNextPage);
            pokedexTabPage.Controls.Add(btnPreviousPage);
            pokedexTabPage.ImageKey = "pokemon.png";
            pokedexTabPage.Location = new Point(4, 39);
            pokedexTabPage.Name = "pokedexTabPage";
            pokedexTabPage.Padding = new Padding(3);
            pokedexTabPage.Size = new Size(959, 518);
            pokedexTabPage.TabIndex = 0;
            pokedexTabPage.Text = "Pokedex";
            pokedexTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(materialCard7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 539);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            panel1.Click += panel1_Click;
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(materialTabControl1);
            materialCard7.Controls.Add(materialTabSelector1);
            materialCard7.Controls.Add(materialLabel1);
            materialCard7.Controls.Add(pictureBox1);
            materialCard7.Depth = 0;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(42, 113);
            materialCard7.Margin = new Padding(14);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(14);
            materialCard7.Size = new Size(750, 333);
            materialCard7.TabIndex = 0;
            materialCard7.Visible = false;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(323, 131);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(413, 185);
            materialTabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(materialLabel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(405, 157);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "About";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Fill;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.ForeColor = Color.Black;
            materialLabel2.Location = new Point(3, 3);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(399, 151);
            materialLabel2.TabIndex = 0;
            materialLabel2.Text = "materialLabel2";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(materialLabel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(405, 157);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Base stats";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Fill;
            materialLabel3.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel3.Location = new Point(3, 3);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(399, 151);
            materialLabel3.TabIndex = 0;
            materialLabel3.Text = "materialLabel3";
            materialLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Proper;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(323, 86);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(413, 48);
            materialTabSelector1.TabIndex = 2;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Right;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel1.Location = new Point(537, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(199, 58);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "pokemon";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(573, 295);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(250, 250);
            materialCard6.TabIndex = 3;
            materialCard6.Click += MaterialCard_Click;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(295, 295);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(250, 250);
            materialCard5.TabIndex = 3;
            materialCard5.Click += MaterialCard_Click;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(17, 295);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(250, 250);
            materialCard4.TabIndex = 4;
            materialCard4.Click += MaterialCard_Click;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(573, 17);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(250, 250);
            materialCard3.TabIndex = 3;
            materialCard3.Click += MaterialCard_Click;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(295, 17);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(250, 250);
            materialCard2.TabIndex = 3;
            materialCard2.Click += MaterialCard_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 17);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(250, 250);
            materialCard1.TabIndex = 2;
            materialCard1.Click += MaterialCard_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Depth = 0;
            btnNextPage.Icon = (Image)resources.GetObject("btnNextPage.Icon");
            btnNextPage.ImageKey = "(нет)";
            btnNextPage.Location = new Point(838, 288);
            btnNextPage.MouseState = MaterialSkin.MouseState.HOVER;
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(56, 56);
            btnNextPage.TabIndex = 1;
            btnNextPage.Text = "materialFloatingActionButton2";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Depth = 0;
            btnPreviousPage.Enabled = false;
            btnPreviousPage.Icon = (Image)resources.GetObject("btnPreviousPage.Icon");
            btnPreviousPage.ImageKey = "(нет)";
            btnPreviousPage.Location = new Point(838, 226);
            btnPreviousPage.MouseState = MaterialSkin.MouseState.HOVER;
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(56, 56);
            btnPreviousPage.TabIndex = 0;
            btnPreviousPage.Text = "materialFloatingActionButton1";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "pokemon.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 628);
            Controls.Add(materialTabControl);
            DrawerAutoShow = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new Padding(0, 64, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pokedex";
            Load += MainForm_Load;
            materialTabControl.ResumeLayout(false);
            pokedexTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            materialCard7.ResumeLayout(false);
            materialCard7.PerformLayout();
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private TabPage pokedexTabPage;
        private ImageList imageList;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnNextPage;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnPreviousPage;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}