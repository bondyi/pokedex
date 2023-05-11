using MaterialSkin;
using MaterialSkin.Controls;

namespace Pokedex
{
    public partial class MainForm : MaterialForm
    {
        private List<MaterialCard> _cards = new(6);
        private PageHandler _pageHandler = new(6, 1);

        public MainForm()
        {
            InitializeComponent();
            InitializeMaterialForm();
        }

        private void InitializeMaterialForm()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey400,
                Primary.Grey400,
                Primary.Grey400,
                Accent.Red400,
                TextShade.BLACK);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;

            await PokemonManager.GetPage(_pageHandler.PageLimit, _pageHandler.Offset);

            InitializeCards();
            UpdateCards();
        }

        private void InitializeCards()
        {
            for (var i = 1; i <= _pageHandler.PageLimit; ++i)
            {
                var card = (MaterialCard)Controls.Find($"materialCard{i}", true)[0];

                var label = new MaterialLabel
                {
                    Name = "label",
                    AutoSize = false,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                label.Click += MaterialCard_Click;

                var pictureBox = new PictureBox
                {
                    Name = "pictureBox",
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Enabled = false
                };
                pictureBox.Click += MaterialCard_Click;

                card.Controls.Add(label);
                card.Controls.Add(pictureBox);

                _cards.Add(card);
            }
        }

        private void UpdateCards()
        {
            for (var i = 0; i < _cards.Count; ++i)
            {
                _cards[i].Enabled = false;

                var label = (MaterialLabel)_cards[i].Controls.Find("label", false)[0];
                var pictureBox = (PictureBox)_cards[i].Controls.Find("pictureBox", false)[0];

                label.Visible = false;
                pictureBox.Visible = false;

                label.Text = PokemonManager.GetPokemonFromPage(i).Name;
                pictureBox.Load(PokemonManager.GetPokemonFromPage(i).Sprites.Other.Home.FrontDefault);

                label.Visible = true;
                pictureBox.Visible = true;

                _cards[i].Enabled = true;
            }
        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            btnPreviousPage.Enabled = _pageHandler.PreviousPage();
            await PokemonManager.GetPage(_pageHandler.PageLimit, _pageHandler.Offset);

            UpdateCards();
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            btnPreviousPage.Enabled = true;

            _pageHandler.NextPage();
            await PokemonManager.GetPage(_pageHandler.PageLimit, _pageHandler.Offset);

            UpdateCards();
        }

        private async void MaterialCard_Click(object? sender, EventArgs e)
        {
            var selectedCard = (MaterialCard)sender;

            await PokemonManager.GetPokemonInfo(int.Parse(selectedCard.Name.Last().ToString()) - 1);

            var selectedPokemonInfo = PokemonManager.SelectedPokemonInfo;

            materialLabel1.Text = selectedPokemonInfo.Name;
            pictureBox1.Load(selectedPokemonInfo.ImageUrl);
            materialLabel2.Text = selectedPokemonInfo.About;
            materialLabel3.Text = PokemonManager.GetBaseStats();

            ChangeView(true);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            materialCard7.Visible = false;

            ChangeView(false);
        }

        private void ChangeView(bool value)
        {
            _cards.ForEach(card => card.Visible = !value);
            btnPreviousPage.Visible = !value;
            btnNextPage.Visible = !value;

            panel1.Visible = value;
            materialCard7.Visible = value;
        }
    }
}
