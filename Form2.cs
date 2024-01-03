namespace task3;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    public Form2(string text)
    {
        InitializeComponent();
        richTextBox1.Text = text;
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBox1.Clear();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new();
        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new();
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }
}
