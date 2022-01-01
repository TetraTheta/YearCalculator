using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace YearCalculator
{
    public partial class Main : Form
    {
        readonly int startYear = 1582; // 그레고리력은 1582년부터 시작함

        public Main()
        {
            InitializeComponent();
            initialize(null, null);
        }

        private void initialize(object sender, EventArgs e)
        {
            monthSelect_cb.SelectedIndex = 0;
            dateSelect_cb.SelectedIndex = 0;
            daySelect_cb.SelectedIndex = 0;
            minYear_tb.Text = startYear.ToString();
            maxYear_tb.Text = "3000";
            yearList_lb.DataSource = null;
            yearList_lb.Items.Clear();
        }

        private void validateMonth(object sender, CancelEventArgs e)
        {
            int month = int.Parse(monthSelect_cb.Text);

            if ((month < 1) || (month > 12))
            {
                monthSelect_cb.ForeColor = Color.Red;
                calculate_bt.Enabled = false;
            }
            else
            {
                monthSelect_cb.ForeColor = Color.Black;
                calculate_bt.Enabled = true;
            }
        }

        private void validateDate(object sender, CancelEventArgs e)
        {
            int date = int.Parse(dateSelect_cb.Text);

            if ((date < 1) || (date > 31))
            {
                dateSelect_cb.ForeColor = Color.Red;
                calculate_bt.Enabled = false;
            }
            else
            {
                dateSelect_cb.ForeColor = Color.Black;
                calculate_bt.Enabled = true;
            }

            // 2월 체크 (윤날 확인 없음)
            if ((int.Parse(monthSelect_cb.Text) == 2))
            {
                if (date > 29)
                {
                    dateSelect_cb.ForeColor = Color.Red;
                    calculate_bt.Enabled = false;
                }
                else
                {
                    dateSelect_cb.ForeColor = Color.Black;
                    calculate_bt.Enabled = true;
                }
            }
        }

        private DayOfWeek GetDOW(ComboBox cb)
        {
            string selected = cb.Text;
            switch (selected)
            {
                case "월":
                    return DayOfWeek.Monday;
                case "화":
                    return DayOfWeek.Tuesday;
                case "수":
                    return DayOfWeek.Wednesday;
                case "목":
                    return DayOfWeek.Thursday;
                case "금":
                    return DayOfWeek.Friday;
                case "토":
                    return DayOfWeek.Saturday;
                case "일":
                    return DayOfWeek.Sunday;
            }
            return DayOfWeek.Sunday;
        }

        private void validateDay(object sender, CancelEventArgs e)
        {
            if (daySelect_cb.SelectedIndex == -1)
            {
                daySelect_cb.ForeColor = Color.Red;
                calculate_bt.Enabled = false;
            }
            else
            {
                daySelect_cb.ForeColor = Color.Black;
                calculate_bt.Enabled = true;
            }
        }

        private void validateMinYear(object sender, CancelEventArgs e)
        {
            int minYear = int.Parse(minYear_tb.Text);
            int maxYear = int.Parse(maxYear_tb.Text);

            if ((minYear < startYear) || (minYear > maxYear))
            {
                minYear_tb.ForeColor = Color.Red;
                calculate_bt.Enabled = false;
            }
            else
            {
                minYear_tb.ForeColor = Color.Black;
                calculate_bt.Enabled = true;
            }
        }

        private void validateMaxYear(object sender, CancelEventArgs e)
        {
            int minYear = int.Parse(minYear_tb.Text);
            int maxYear = int.Parse(maxYear_tb.Text);

            if ((minYear < startYear) || (minYear > maxYear))
            {
                maxYear_tb.ForeColor = Color.Red;
                calculate_bt.Enabled = false;
            }
            else
            {
                maxYear_tb.ForeColor = Color.Black;
                calculate_bt.Enabled = true;
            }
        }

        private void comboBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush brush = Brushes.Black;

            string text = ((ComboBox)sender).Items[e.Index].ToString();

            e.Graphics.DrawString(text, ((ComboBox)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        }

        private void calculate(object sender, EventArgs e)
        {
            // 이전 결과 지우기
            yearList_lb.DataSource = null;
            yearList_lb.Items.Clear();

            int minYear = int.Parse(minYear_tb.Text);
            int maxYear = int.Parse(maxYear_tb.Text);

            int month = int.Parse(monthSelect_cb.Text);
            int date = int.Parse(dateSelect_cb.Text);
            DayOfWeek day = GetDOW(daySelect_cb);

            for (int i = minYear; i <= maxYear; i++)
            {
                DateTime dt = new DateTime(i, month, date);
                if (dt.DayOfWeek == day)
                {
                    yearList_lb.Items.Add(dt);
                }
            }
        }
    }
}
