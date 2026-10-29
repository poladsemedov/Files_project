namespace File_Edit_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text file *.txt | *.txt";
            sv.FileName = "Document" + count;
            sv.ShowDialog();

            if (!string.IsNullOrEmpty(sv.FileName))
            {
                File.Create(sv.FileName).Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text file *.txt | *.txt";
            op.ShowDialog();

            if (op.FileName == "")
            {
                MessageBox.Show("Fayl yolu tapılmadı", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                File.AppendAllText(op.FileName, richTextBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All files *.* | *.*";
            op.ShowDialog();

            if (op.FileName == "")
            {
                MessageBox.Show("Fayl yolu tapılmadı", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult d = MessageBox.Show("Fayl silinsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    File.Delete(op.FileName);
                    MessageBox.Show("Fayl silindi");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text file *.txt | *.txt";
            op.ShowDialog();

            if (op.FileName == "")
            {
                MessageBox.Show("Fayl yolu tapılmadı", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                richTextBox1.Text = File.ReadAllText(op.FileName);
            }
        }
    }
}
