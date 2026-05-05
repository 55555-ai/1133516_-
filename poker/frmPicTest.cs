using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace poker
{
    public partial class frmPicTest : Form
    {
        Random rnd = new Random();

        int[] cardNumbers = new int[5]; // 1~13
        int[] cardSuits = new int[5];   // 0~3
        bool[] selected = new bool[5];

        int money = 1000000;
        int rate = 0;
        string handName = "";

        public frmPicTest()
        {
            InitializeComponent();

            txtMoney.Text = money.ToString();
            txtBet.Text = "500";
            txtResult.ReadOnly = true;

            picCard1.Click += picCard_Click;
            picCard2.Click += picCard_Click;
            picCard3.Click += picCard_Click;
            picCard4.Click += picCard_Click;
            picCard5.Click += picCard_Click;

            PictureBox[] pics = { picCard1, picCard2, picCard3, picCard4, picCard5 };
            foreach (PictureBox pic in pics)
            {
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Click += picCard_Click;
            }
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            int[] deck = Enumerable.Range(0, 52).OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < 5; i++)
            {
                int card = deck[i];
                cardSuits[i] = card / 13;
                cardNumbers[i] = card % 13 + 1;
                selected[i] = false;
            }

            ShowCards();
            txtResult.Text = "已發牌，請選擇要換的牌或判斷牌型。";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            bool hasSelected = selected.Any(x => x == true);

            if (!hasSelected)
            {
                MessageBox.Show("請先點選要換的牌。");
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                if (selected[i])
                {
                    int card;
                    do 
                    { 
                        card = rnd.Next(0, 52);
                    } 
                    while (IsCardAlreadyUsed(card));

                    cardSuits[i] = card / 13;
                    cardNumbers[i] = card % 13 + 1;

                    selected[i] = false;
                }
            }

            ShowCards();
            txtResult.Text = "已換牌，請重新判斷牌型。";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!HasCards())
            {
                MessageBox.Show("請先發牌。");
                return;
            }

            handName = CheckHand(out rate);
            txtResult.Text = $"牌型：{handName}，賠率：{rate}";
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (!HasCards())
            {
                MessageBox.Show("請先發牌。");
                return;
            }

            if (!int.TryParse(txtBet.Text, out int bet) || bet <= 0)
            {
                MessageBox.Show("請輸入有效的押注金額。");
                return;
            }

            if (bet > money)
            {
                MessageBox.Show("押注金額不能超過總資金。");
                return;
            }

            handName = CheckHand(out rate);

            int prize = bet * rate;
            money = money - bet + prize;

            txtMoney.Text = money.ToString();
            txtResult.Text = $"牌型：{handName}，賠率：{rate}，中獎金額：{prize}，目前資金：{money}";
        }

        private void ShowCards()
        {
            PictureBox[] pics = { picCard1, picCard2, picCard3, picCard4, picCard5 };

            for (int i = 0; i < 5; i++)
            {
                // 檢查數字
                if (cardNumbers[i] < 1 || cardNumbers[i] > 13)
                {
                    MessageBox.Show($"第 {i + 1} 張牌數字錯誤：{cardNumbers[i]}");
                    return;
                }

                string suit = GetSuitName(cardSuits[i]);   // s,h,d,p
                string num = GetNumber(cardNumbers[i]);    // 1~13
                string key = suit + num;                   // s1

                // ⭐ 從 Resources 讀圖片
                object obj = Properties.Resources.ResourceManager.GetObject(key);

                if (obj == null)
                {
                    MessageBox.Show("找不到資源圖片：" + key);
                    return;
                }

                pics[i].Image = (Image)obj;

                // UI 設定
                pics[i].SizeMode = PictureBoxSizeMode.Zoom;
                pics[i].BorderStyle = selected[i] ? BorderStyle.Fixed3D : BorderStyle.FixedSingle;
                pics[i].BackColor = selected[i] ? Color.Yellow : Color.Transparent;
            }
        }

        private void picCard_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int index = -1;

            if (pic == picCard1) index = 0;
            else if (pic == picCard2) index = 1;
            else if (pic == picCard3) index = 2;
            else if (pic == picCard4) index = 3;
            else if (pic == picCard5) index = 4;

            if (index == -1) return;

            selected[index] = !selected[index];

            if (selected[index])
            {
                pic.BorderStyle = BorderStyle.Fixed3D;
                pic.BackColor = Color.Yellow;
            }
            else
            {
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.BackColor = Color.Transparent;
            }
        }

        private bool HasCards()
        {
            return cardNumbers.Any(x => x != 0);
        }

        private bool IsCardAlreadyUsed(int card)
        {
            int suit = card / 13;
            int number = card % 13 + 1;

            for (int i = 0; i < 5; i++)
            {
                if (cardSuits[i] == suit && cardNumbers[i] == number)
                    return true;
            }

            return false;
        }

        private string GetSuitName(int suit)
        {
            if (suit == 0) return "s"; // 黑桃
            if (suit == 1) return "h"; // 愛心
            if (suit == 2) return "d"; // 菱形
            return "p";                // 梅花
        }

        private string GetNumber(int num)
        {
            return num.ToString(); // 1~13
        }

        private string CheckHand(out int payRate)
        {
            int[] nums = cardNumbers.OrderBy(x => x).ToArray();

            int[] counts = nums.GroupBy(x => x)
                               .Select(g => g.Count())
                               .OrderByDescending(x => x)
                               .ToArray();

            bool isFlush = cardSuits.All(x => x == cardSuits[0]);
            bool isStraight = IsStraight(nums);
            bool isRoyal = isFlush && nums.SequenceEqual(new int[] { 1, 10, 11, 12, 13 });

            if (isRoyal)
            {
                payRate = 250;
                return "皇家同花順";
            }
            else if (isFlush && isStraight)
            {
                payRate = 50;
                return "同花順";
            }
            else if (counts[0] == 4)
            {
                payRate = 25;
                return "四條";
            }
            else if (counts[0] == 3 && counts[1] == 2)
            {
                payRate = 9;
                return "葫蘆";
            }
            else if (isFlush)
            {
                payRate = 6;
                return "同花";
            }
            else if (isStraight)
            {
                payRate = 4;
                return "順子";
            }
            else if (counts[0] == 3)
            {
                payRate = 3;
                return "三條";
            }
            else if (counts[0] == 2 && counts[1] == 2)
            {
                payRate = 2;
                return "兩對";
            }
            else if (counts[0] == 2)
            {
                payRate = 1;
                return "一對";
            }
            else
            {
                payRate = 0;
                return "無牌型";
            }
        }

        private bool IsStraight(int[] nums)
        {
            if (nums.SequenceEqual(new int[] { 1, 2, 3, 4, 5 }))
                return true;

            if (nums.SequenceEqual(new int[] { 1, 10, 11, 12, 13 }))
                return true;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] - nums[i] != 1)
                    return false;
            }

            return true;
        }
    

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void lblCard4_Click(object sender, EventArgs e)
        {

        }
    }
}
