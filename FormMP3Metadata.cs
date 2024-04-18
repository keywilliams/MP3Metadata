using MP3Metadata.Models;

namespace MP3Metadata
{
    public partial class FormMP3Metadata : Form
    {
        public FormMP3Metadata()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialogMP3Path.ShowDialog(this) == DialogResult.OK)
            {
                txtPath.Text = FolderBrowserDialogMP3Path.SelectedPath;

                var mp3List = new List<Music>();

                DirectoryInfo di = new DirectoryInfo(FolderBrowserDialogMP3Path.SelectedPath);

                foreach (var file in di.GetFiles("*.mp3"))
                {
                    var tfile = TagLib.File.Create(file.FullName);

                    mp3List.Add(new Music(file.Name, tfile.Tag.Title));
                }

                dataGridViewMP3Files.DataSource = mp3List;
            }
        }

        private void btnProcessFiles_Click(object sender, EventArgs e)
        {
            var mp3List = new List<Music>();

            DirectoryInfo di = new DirectoryInfo(txtPath.Text);

            foreach (var file in di.GetFiles("*.mp3"))
            {
                var tfile = TagLib.File.Create(file.FullName);

                tfile.Tag.Title = file.Name;
                tfile.Save();

                mp3List.Add(new Music(file.Name, tfile.Tag.Title));
            }

            dataGridViewMP3Files.DataSource = mp3List;
        }
    }
}