using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JourneyMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AlternatingRowsDefaultCellStyle = null;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private bool watchCellChange = true;
        private List<RowObject> rowObjects = new List<RowObject>();
        public int reduceImageWidthTo = 640; // 640 is the default
        private BindingSource source = new BindingSource();

        // Adds new images and new rows, as well as some default text for the user to change
        private void addImagesButton_Click(object sender, EventArgs e)
        {
            if (imageLoadDialog.ShowDialog() == DialogResult.OK)
            {
                watchCellChange = false;
                int count = 0;
                dataGridView1.Rows.Clear();

                for (int i = 0; i < imageLoadDialog.FileNames.Length; i++)
                {
                    // Create a PictureBox. 
                    try
                    {
                        Bitmap img;
                        img = new Bitmap(imageLoadDialog.FileNames[i]);
                        RowObject row = new RowObject(img, imageLoadDialog.SafeFileNames[i]);
                        rowObjects.Add(row);
                        img.Dispose(); // Greatly reduces memory use

                    }
                    catch (System.Security.SecurityException ex)
                    {
                        showFileAccessException("securityEx", ex);
                    }
                    catch (Exception ex)
                    {
                        showFileAccessException("regularEx", ex);
                    }
                }

                foreach (RowObject row in rowObjects) 
                {
                    Bitmap imgResized = new Bitmap(row.picture, new Size(row.picture.Width / 6, row.picture.Height / 6));
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[count].Height = imgResized.Size.Height;
                    dataGridView1.Rows[count].Cells[0].Value = imgResized;
                    dataGridView1.Rows[count].Cells[1].Value = row.underPicText;
                    dataGridView1.Rows[count].Cells[2].Value = row.noteText;
                    count++;
                }
                watchCellChange = true;
            }
        }

        // Updates text in row object based on user input in datagridview
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (watchCellChange == true)
            {
                if (rowObjects.Count > 0)
                {
                    RowObject row = rowObjects[e.RowIndex];

                    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
                    {
                        row.underPicText = dataGridView1.Rows[e.RowIndex].Cells[1].Value as string;
                    }
                    else
                    {
                        row.underPicText = "";
                    }

                    if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
                    {
                        row.noteText = dataGridView1.Rows[e.RowIndex].Cells[2].Value as string;
                    }
                    else
                    {
                        row.noteText = "";
                    }
                }
            }   
        }

        // This publishes the list, both the images (scaled as requested) and the HTML for the update and text
        private void publishButton_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("There is nothing to publish");
                return;
            }
            dataGridView1.ClearSelection();
            PublishForm subForm = new PublishForm(this);
            subForm.ShowDialog();
        }

        // This method enables higher quality JPEGs
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private string getNameForMonth(int month)
        {
            List<string> monthNames = new List<string>{"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct",
            "Nov", "Dec"};

            return monthNames[month - 1];
        }

        public bool publish(DateTime dt, string headerText, Int64 imageQuality, bool kristinMode, bool createZipFile)
        {
            int rowCount = dataGridView1.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("There is nothing to publish");
                return false;
            }

            // Placeholder until I implement Kristin mode (publish HTML for the site)
            if (kristinMode == true)
            {
                MessageBox.Show("This feature is not yet implemented!");
                return false;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
         
                string shortMonthDayString = getNameForMonth(dt.Month) + dt.Day.ToString();
                if (Directory.Exists(folderBrowserDialog1.SelectedPath + "\\" + shortMonthDayString) == true)
                {
                    DialogResult clearWarning = MessageBox.Show("This folder appears to contain a previous update, which will be overwritten! " + 
                    "Would you like to continue?",
                    "Warning!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                    if (clearWarning == DialogResult.Yes)
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath + "\\" + shortMonthDayString + "\\picts_s");
                        foreach (FileInfo file in dirInfo.GetFiles())
                        {
                            file.Delete();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                string folderName = folderBrowserDialog1.SelectedPath;
                DirectoryInfo rootDir = Directory.CreateDirectory(folderName + "\\" + shortMonthDayString);
                DirectoryInfo di = Directory.CreateDirectory(rootDir.FullName + "\\picts_s");
                // The next five lines are all used to try and create a higher quality JPG output
                // code taken from MSDN
                ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);
                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, imageQuality);
                myEncoderParameters.Param[0] = myEncoderParameter;

                StreamWriter htmlFileWriter = new StreamWriter(rootDir.FullName + "\\index.htm");

                htmlFileWriter.WriteLine("<head>\n<title>Trip Log - " + dt.ToLongDateString() + "</title>");
                htmlFileWriter.WriteLine("<h2>Trip Log - " + dt.ToLongDateString() + "</h2>");
                htmlFileWriter.WriteLine("<h4>" + headerText + "</h4></head>");
                htmlFileWriter.WriteLine("<table width=\"100%\" border=\"5\" align=\"left\" cellpadding=\"5\" cellspacing=\"0\">");
                string subBR = "<br>";

                foreach (RowObject row in rowObjects)
                {
                    Bitmap imgResized = row.returnResizedImage(reduceImageWidthTo);
                    string fixedUnderPicText = Regex.Replace(row.underPicText, @"\r\n?|\n", subBR);
                    string fixedNoteText = Regex.Replace(row.noteText, @"\r\n?|\n", subBR);

                    string fileNameExtension = row.pictureFileName.Substring(row.pictureFileName.Length - 4);
                    string fileNameWithoutExtension = row.pictureFileName.Substring(0, row.pictureFileName.Length - 4);
                    string pictureFileSaveName = fileNameWithoutExtension + "_small" + fileNameExtension;

                    imgResized.Save(di.FullName + "\\" + pictureFileSaveName, jgpEncoder, myEncoderParameters);
                    
                    if (fixedNoteText != "")
                    {
                        htmlFileWriter.WriteLine("<tr><td align=\"center\">" + fixedNoteText + "<br></td>");
                        htmlFileWriter.WriteLine("<td width = \""+ imgResized.Width + "\" align=\"center\" valign=\"top\"><img src=\"./picts_s/" + pictureFileSaveName + "\"><br>" +
                        fixedUnderPicText + "</td></tr>");
                    }
                    else
                    {
                        htmlFileWriter.WriteLine("<td colspan=2 align=\"center\" valign=\"top\"><img src=\"./picts_s/" + pictureFileSaveName + "\"><br>" +
                        fixedUnderPicText + "</td></tr>");
                    }
                    imgResized.Dispose(); //?
                }

                htmlFileWriter.WriteLine("</table>");
                htmlFileWriter.Close();

                // Commented out this feature to troubleshoot
                // Compression not supported in older NET versions. Need to detect version and enable/disable based
                // on if the system can even handle it.
                /*if (createZipFile == true)
                {
                    ZipFile.CreateFromDirectory(rootDir.FullName, folderName + "\\" + dt.Year.ToString() + "-" + dt.Month.ToString() + "-" +
                        dt.Day.ToString() +  "_zippedUpdateToEmail.zip");
                }*/
                
            }
            return true;
        }

        // This moves the row up
        private void moveRowUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dataGridView1.Rows.Count;
                int idx = dataGridView1.SelectedCells[0].OwningRow.Index;
                if (idx == 0)
                    return;
                int col = dataGridView1.SelectedCells[0].OwningColumn.Index;
                DataGridViewRowCollection rows = dataGridView1.Rows;
                DataGridViewRow row = rows[idx];
                RowObject listRow = rowObjects[idx];
                rows.Remove(row);
                rowObjects.Remove(listRow);
                rows.Insert(idx - 1, row);
                rowObjects.Insert(idx - 1, listRow);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[idx - 1].Cells[col].Selected = true;
            }
            catch { }
        }

        // This moves the selected row down (if it is not one of the bottom two rows)
        private void moveRowDownButton_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dataGridView1.Rows.Count;
                int idx = dataGridView1.SelectedCells[0].OwningRow.Index;
                if (idx == totalRows - 1)
                    return;
                int col = dataGridView1.SelectedCells[0].OwningColumn.Index;
                DataGridViewRowCollection rows = dataGridView1.Rows;
                DataGridViewRow row = rows[idx];
                RowObject listRow = rowObjects[idx];
                rows.Remove(row);
                rowObjects.Remove(listRow);
                rows.Insert(idx + 1, row);
                rowObjects.Insert(idx + 1, listRow);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[idx + 1].Cells[col].Selected = true;
            }
            catch { }
        }

        // This should remove the selected row
        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dataGridView1.Rows.Count;
                int idx = dataGridView1.SelectedCells[0].OwningRow.Index;
                
                int col = dataGridView1.SelectedCells[0].OwningColumn.Index;
                DataGridViewRowCollection rows = dataGridView1.Rows;
                DataGridViewRow row = rows[idx];
                RowObject listRow = rowObjects[idx];
                rows.Remove(row);
                rowObjects.Remove(listRow);
                dataGridView1.ClearSelection();
            }
            catch { }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit(); // For some reason EndEdit works but ClearSelection does not??
            if (saveProgressDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter serializer = new BinaryFormatter();
                // For some reason I can't just tell to overwrite then append so I need to create
                // and close two streams...
                FileStream fcreate = File.Open(saveProgressDialog.FileName, FileMode.Create);
                fcreate.Close();

                FileStream stream = new FileStream(saveProgressDialog.FileName, FileMode.Append, FileAccess.Write);
                foreach (RowObject row in rowObjects)
                {
                    serializer.Serialize(stream, row); 
                }

                stream.Close();

            }   
        }

        // lots of dupe code very messy should clean
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (loadSavedDialog.ShowDialog() == DialogResult.OK)
            {
                watchCellChange = false;
                int count = 0;
                dataGridView1.Rows.Clear();
                rowObjects = new List<RowObject>();

                try
                {
                    Stream TestFileStream = File.OpenRead(loadSavedDialog.FileName);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    while (TestFileStream.Position != TestFileStream.Length)
                    {
                        RowObject row = (RowObject)deserializer.Deserialize(TestFileStream);
                        rowObjects.Add(row);
                    }
                    
                    TestFileStream.Close();
                }
                catch (System.Security.SecurityException ex)
                {
                    showFileAccessException("securityEx", ex);
                }
                catch (Exception ex)
                {
                    showFileAccessException("regularEx", ex);
                }

                foreach (RowObject row in rowObjects)
                {
                    Bitmap imgResized = new Bitmap(row.picture, new Size(row.picture.Width / 6, row.picture.Height / 6));
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[count].Height = imgResized.Size.Height;
                    dataGridView1.Rows[count].Cells[0].Value = imgResized;
                    dataGridView1.Rows[count].Cells[1].Value = row.underPicText;
                    dataGridView1.Rows[count].Cells[2].Value = row.noteText;
                    count++;
                }
                watchCellChange = true;
            }
        }

        private void showFileAccessException(string type, Exception ex)
        {
            if (type == "securityEx")
            {
                // The user lacks appropriate permissions to read files, discover paths, etc.
                MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                    "Error message: " + ex.Message + "\n\n" +
                    "Details (send to Support):\n\n" + ex.StackTrace
                );
            }
            else
            {
                // Could not load the image - probably related to Windows file system permissions.
                MessageBox.Show("Cannot display the image: " + loadSavedDialog.FileName.Substring(loadSavedDialog.FileName.LastIndexOf('\\'))
                    + ". You may not have permission to read the file, or " +
                    "it may be corrupt.\n\nReported error: " + ex.Message);
            }
        }

        private void toolStripMenuClear_Click(object sender, EventArgs e)
        {
            clearAll(0);
        }

        public void clearAll(int source)
        {
            if (source == 0)
            {
                DialogResult clearWarning = MessageBox.Show("Are you sure you want to clear data? All unsaved progress will be lost!",
                    "Warning!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (clearWarning == DialogResult.Yes)
                {
                    dataGridView1.Rows.Clear();
                    rowObjects = new List<RowObject>();
                }
            } 
            else {
                DialogResult clearWarning = MessageBox.Show("Would you like to clear data?",
                    "Warning!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (clearWarning == DialogResult.Yes)
                {
                    dataGridView1.Rows.Clear();
                    rowObjects = new List<RowObject>();
                }
            }  
        }

        private void toolStripMenuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Need some help??\n\n" +
                            "Click Add Image(s) to load desired images. You can select more than one at a time.\n" +
                            "Add text to the Text Under Image and Notes fields. Press Shift+Enter to insert breaks.\n\n" +
                            "NOTE: Omitting the text in the Notes column will automatically center the image in the published table.\n\n" +
                            "Select a row and use the up and down arrow buttons to change order.\n" +
                            "Select a row and press the Remove Row button to delete it.\n" +
                            "Select one or more rows and use the < and > buttons to rotate the image.\n" +
                            "Press the publish button to open the Publish Options dialog. Choose desired image width, quality, the date of the update," + 
                            " and any text to appear at the top of the page. Then click publish and choose a folder to save in.\n\n" +
                            "Check the \"Create Zip File\" checkbox to create an emailable zip file in the chosen directory.\n" +
                            "Kristin mode is not yet implemented!\n\n" +
                            "You can also save and load your progress using the menu options.\n" +
                            "Clear All will wipe any unsaved progress so you can start fresh", 
                "Help and Tips", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Question);
        }

        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dataGridView1.Rows.Count;
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    int idx = cell.OwningRow.Index;
                    if (idx == totalRows)
                        return;
                    int col = cell.OwningColumn.Index;
                    DataGridViewRowCollection rows = dataGridView1.Rows;
                    DataGridViewRow row = rows[idx];
                    RowObject listRow = rowObjects[idx];
                    listRow.picture.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    Bitmap imgResized = new Bitmap(listRow.picture, new Size(listRow.picture.Width / 6, listRow.picture.Height / 6));
                    row.Cells[0].Value = imgResized;
                    row.Height = imgResized.Height;
                }  
            }
            catch { }
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dataGridView1.Rows.Count;
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    int idx = cell.OwningRow.Index;
                    if (idx == totalRows)
                        return;
                    int col = cell.OwningColumn.Index;
                    DataGridViewRowCollection rows = dataGridView1.Rows;
                    DataGridViewRow row = rows[idx];
                    RowObject listRow = rowObjects[idx];
                    listRow.picture.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    Bitmap imgResized = new Bitmap(listRow.picture, new Size(listRow.picture.Width / 6, listRow.picture.Height / 6));
                    row.Cells[0].Value = imgResized;
                }
            }
            catch { }
        }
    }
}
