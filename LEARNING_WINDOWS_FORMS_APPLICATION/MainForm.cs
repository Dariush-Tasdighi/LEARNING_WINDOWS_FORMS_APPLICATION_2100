namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(pathNameTextBox.Text))
			{
				System.Windows.Forms.MessageBox.Show
					(text: "تکمیل مسیر و نام فایل متنی الزامی است!",
					caption: "خطا",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

				pathNameTextBox.Text = string.Empty;
				pathNameTextBox.Focus();

				return;
			}

			pathNameTextBox.Text =
				pathNameTextBox.Text.Trim();

			System.IO.StreamWriter stream = null;

			try
			{
				stream =
					new System.IO.StreamWriter
						(path: pathNameTextBox.Text, append: false, encoding: System.Text.Encoding.UTF8);

				stream.Write(textTextBox.Text);

				//stream.Flush();
				stream.Close();

				System.Windows.Forms.MessageBox.Show
					(text: "فایل متنی با موفقیت ایجاد یا ذخیره گردید.",
					caption: "پیام",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Information,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (stream != null)
				{
					stream.Dispose();
					stream = null;
				}
			}
		}

		private void OpenButton_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(pathNameTextBox.Text))
			{
				System.Windows.Forms.MessageBox.Show
					(text: "تکمیل مسیر و نام فایل متنی الزامی است!",
					caption: "خطا",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

				pathNameTextBox.Text = string.Empty;

				pathNameTextBox.Focus();

				return;
			}

			pathNameTextBox.Text =
				pathNameTextBox.Text.Trim();

			if (System.IO.File.Exists(pathNameTextBox.Text) == false)
			{
				System.Windows.Forms.MessageBox.Show
					(text: "مسیر و یا نام فایل متنی صحیح نمی‌باشد!",
					caption: "خطا",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

				pathNameTextBox.Focus();

				return;
			}

			System.IO.StreamReader stream = null;

			try
			{
				stream =
					new System.IO.StreamReader
						(path: pathNameTextBox.Text, encoding: System.Text.Encoding.UTF8);

				textTextBox.Text = stream.ReadToEnd();

				stream.Close();

				System.Windows.Forms.MessageBox.Show
					(text: "فایل متنی با موفقیت بارگذاری گردید.",
					caption: "پیام",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Information,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button1,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (stream != null)
				{
					stream.Dispose();
					stream = null;
				}
			}
		}
	}
}
