namespace CW11062023
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			Thread[] messageBoxThreads = new Thread[3] {
				new Thread(() => { MessageBox.Show(richTextBox1.Text, "Message Box 1"); }),
				new Thread(() => { MessageBox.Show(richTextBox2.Text, "Message Box 2"); }),
				new Thread(() => {
					MessageBox.Show(richTextBox3.Text, $"Message Box 3 ({
						(richTextBox1.Text.Length + richTextBox2.Text.Length + richTextBox3.Text.Length) / 3
					})");
				})
			};
			
			foreach (Thread thread in messageBoxThreads)
				thread.Start();

			foreach (Thread thread in messageBoxThreads)
				thread.Join();
		}
	}
}