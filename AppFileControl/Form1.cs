using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace AppFileControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            //Open a Foler browser dialog to select the folder
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the folder";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            //if the user select a folder, set the path to the textbox
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            txtFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnProcessFolder_Click(object sender, EventArgs e)
        {
            string[] filesInFolder = Directory.GetFiles(txtFolder.Text);
            //show in txtProcessFileNumber the number of items in the filesInFolder Array
            txtProcessFileNumber.Text = filesInFolder.Length + " file(s) Processed";
            foreach (string file in filesInFolder)
            {
                //Get the file name
                string fileName = Path.GetFileName(file);
                //Get the file extension
                string fileExtension = Path.GetExtension(file);
                //sort the file by extension using a switch
                switch (fileExtension)
                {
                    case ".txt":
                    case ".xlsx":
                    case ".docx":
                    case ".pptx":
                        //Move the file to the folder to a docs
                        if (!Directory.Exists(txtFolder.Text + "\\Docs"))
                        {
                            Directory.CreateDirectory(txtFolder.Text + "\\Docs");
                        }
                        File.Move(file, txtFolder.Text + "\\Docs\\" + fileName);
                        break;
                    case ".jpg":
                    case ".jpeg":
                    case ".png":
                        //Move the file to the  folder if the folder exist else create the folder
                        if (!Directory.Exists(txtFolder.Text + "\\Pics"))
                        {
                            Directory.CreateDirectory(txtFolder.Text + "\\Pics");
                        }
                        File.Move(file, txtFolder.Text + "\\Pics\\" + fileName);
                        break;

                    default:
                        //Move the file to the other folder
                        if (!Directory.Exists(txtFolder.Text + "\\other"))
                        {
                            Directory.CreateDirectory(txtFolder.Text + "\\other");
                        }
                        File.Move(file, txtFolder.Text + "\\other\\" + fileName);
                        break;
                }
            }
        }

        private void btnOpenTextFile_Click(object sender, EventArgs e)
        {
            //Open a file dialog to select the file
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files|*.txt";
            dialog.Title = "Select a Text File";
            //if the user select a file, set the path to the textbox
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            //Read the file and show the content in the txtContent textbox
            TxtContent.Text = File.ReadAllText(dialog.FileName);
        }



        private void btnSaveTextFile_Click(object sender, EventArgs e)
        {
            //save the content of the txtContent textbox to a new file
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files|*.txt";
            dialog.Title = "Save the Text File";
            //if the user select a file, set the path to the textbox
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            //Write the content of the txtContent textbox to the file
            File.WriteAllText(dialog.FileName, TxtContent.Text);
        }



        private void TextSave_Click(object sender, EventArgs e)
        {
            //save the content of the file of word
            // Crear un nuevo documento de Word
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Word Files|*.docx";
            saveFile.Title = "Save the Text File";


            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFile.FileName;

                // Crear un nuevo documento de Word
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
                {
                    // Agregar un MainDocumentPart al documento
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    // Crear un documento
                    mainPart.Document = new Document();

                    // Agregar un párrafo al cuerpo del documento
                    Body body = mainPart.Document.AppendChild(new Body());
                    Paragraph para = body.AppendChild(new Paragraph());
                    Run run = para.AppendChild(new Run());
                    run.AppendChild(new Text(TxtContent.Text));
                }


            }
        }
    }

}
