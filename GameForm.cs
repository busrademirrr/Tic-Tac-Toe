using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        private int gridSize;
        private Button[,] gameButtons;
        private bool isPlayer1Turn = true;
        private string player1Symbol = "X";
        private string player2Symbol = "O";
        private bool isSinglePlayer;

        public GameForm(int gridSize, bool isSinglePlayer)
        {
            InitializeComponent();
            this.gridSize = gridSize;
            this.isSinglePlayer = isSinglePlayer;
            InitializeGameBoard();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void InitializeGameBoard()
        {
            // Paneli temizle, eski butonları kaldır
            gamePanel.Controls.Clear();

            // Geçerli gridSize değerlerini kontrol et
            if (gridSize != 3 && gridSize != 5 && gridSize != 7)
            {
                // Eğer gridSize geçerli değilse, 3x3 boyutuna ayarla
                gridSize = 3;
            }

            // gameButtons dizisini yeniden oluştur
            gameButtons = new Button[gridSize, gridSize];

            // Buton boyutunu panelin en küçük boyutuna göre ayarla
            int buttonSize = Math.Min(gamePanel.ClientSize.Width, gamePanel.ClientSize.Height) / gridSize;

            // Butonları daha küçük yapmak için oranı %90'a çek
            buttonSize = (int)(buttonSize * 0.99); // %90 oranında küçültme

            // Butonları yerleştir
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Button button = new Button
                    {
                        Width = buttonSize,
                        Height = buttonSize,
                        Location = new Point(j * buttonSize, i * buttonSize), // Yerin doğru hesaplanması
                        Font = new Font("Arial", 24, FontStyle.Bold),
                        Tag = new Tuple<int, int>(i, j) // Butona tıklanabilir pozisyon bilgisi ekle
                    };

                    // Buton tıklama olayını bağla
                    button.Click += Button_Click;
                    gamePanel.Controls.Add(button);
                    gameButtons[i, j] = button;
                }
            }
            UpdateLabels();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Eğer tıklanan buton zaten doluysa, hiçbir şey yapma
            if (!string.IsNullOrEmpty(clickedButton.Text))
                return;

            // Oyun sırasına göre butona X veya O ekle
            if (isPlayer1Turn)
            {
                clickedButton.Text = player1Symbol;
            }
            else
            {
                clickedButton.Text = player2Symbol;
            }

            // Oyuncu sırasını değiştir
            isPlayer1Turn = !isPlayer1Turn;

            // Sıradaki oyuncuyu ve oyun koşulunu güncelle
            UpdateLabels();

            // Kazanan kontrolü
            if (CheckForWinner())
            {
                string winner = isPlayer1Turn ? player2Symbol : player1Symbol;
                ShowResult($"{winner} kazandı!");
            }
            else if (IsBoardFull())
            {
                ShowResult("Beraberlik!");
            }
            else if (isSinglePlayer && !isPlayer1Turn)
            {
                // AI hamlesi ve ardından sıralamayı güncelle
                AITurn();
                isPlayer1Turn = !isPlayer1Turn; // Oyuncuyu tekrar değiştir
                UpdateLabels(); // Sıralamayı güncelle
            }
        }

        private void AITurn()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (string.IsNullOrEmpty(gameButtons[i, j].Text))
                    {
                        gameButtons[i, j].Text = player2Symbol;
                        isPlayer1Turn = true;
                        UpdateLabels();
                        return;
                    }
                }
            }
        }

        private bool CheckForWinner()
        {
            int winCondition = gridSize == 3 ? 3 : 4;
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (!string.IsNullOrEmpty(gameButtons[i, j].Text))
                    {
                        if (j + winCondition <= gridSize && CheckLine(i, j, 0, 1, winCondition)) return true;
                        if (i + winCondition <= gridSize && CheckLine(i, j, 1, 0, winCondition)) return true;
                        if (i + winCondition <= gridSize && j + winCondition <= gridSize && CheckLine(i, j, 1, 1, winCondition)) return true;
                        if (i + winCondition <= gridSize && j - winCondition >= -1 && CheckLine(i, j, 1, -1, winCondition)) return true;
                    }
                }
            }
            return false;
        }

        private bool CheckLine(int startX, int startY, int dirX, int dirY, int length)
        {
            string firstSymbol = gameButtons[startX, startY].Text;
            for (int i = 1; i < length; i++)
            {
                int x = startX + dirX * i;
                int y = startY + dirY * i;
                if (x < 0 || y < 0 || x >= gridSize || y >= gridSize || gameButtons[x, y].Text != firstSymbol)
                    return false;
            }
            return true;
        }

        private bool IsBoardFull()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (string.IsNullOrEmpty(gameButtons[i, j].Text))
                        return false;
                }
            }
            return true;
        }

        private void ShowResult(string resultMessage)
        {
            string winner = isPlayer1Turn ? "Player 2" : "Player 1";
            string resultText = $"{winner} kazandı!";
            using (ResultForm resultForm = new ResultForm(resultText))
            {
                if (resultForm.ShowDialog() == DialogResult.Abort)
                {
                    MainMenuForm mainMenu = new MainMenuForm();
                    mainMenu.Show();
                    this.Close();
                }
                else
                {
                    ResetGame();
                }
            }
        }

        private void ResetGame()
        {
            foreach (var button in gameButtons)
            {
                button.Text = string.Empty;
            }
            isPlayer1Turn = true;
            UpdateLabels();
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            InitializeGameBoard();
        }

        private void UpdateLabels()
        {
            upperLabel.Text = isPlayer1Turn ? "Player 1 to move" : "Player 2 to move";
            lowerLabel.Text = gridSize == 3 ? "Place 3 in a row!" : "Place 4 in a row!";
        }
    }
}
