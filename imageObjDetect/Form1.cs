using Alturos.Yolo;
using Alturos.Yolo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageObjDetect
{
    public partial class Form1 : Form
    {
        private object pictureBoxToRender;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            var configurationDetector = new ConfigurationDetector();
            var config = configurationDetector.Detect();
            YoloWrapper yolo = new YoloWrapper(config);
            var memoryStream = new MemoryStream();
            picImage.Image.Save(memoryStream, ImageFormat.Png);
            var _items = yolo.Detect(memoryStream.ToArray()).ToList();
            AddDetailsToPictureBox(picImage, _items);
        }

        private void AddDetailsToPictureBox(PictureBox pictureBoxToRender, List<YoloItem> items)
        {
            var img = pictureBoxToRender.Image;

            var font = new Font("Arial", 40, FontStyle.Bold);
            var brush = new SolidBrush(Color.Red);

            var graphics = Graphics.FromImage(img);
            foreach (var item in items)
            {
                var x = item.X;
                var y = item.Y;
                var width = item.Width;
                var height = item.Height;

                var rect = new Rectangle(x, y, width, height);
                var pen = new Pen(Color.Red, 6);
                //var point = new Point((x + width / 2), (y + height /2));
                var point = new Point(x, y);


                graphics.DrawRectangle(pen, rect);
                graphics.DrawString(item.Type, font, brush, point);

                if (item.Type == "person")
                {
                    fLabel.Text = "OK";
                    resultLabel.Text = item.Type;
                    confidentLabel.Text = item.Confidence.ToString();
                }
                else 
                {
                    fLabel.Text = "NG";
                    resultLabel.Text = item.Type;
                    confidentLabel.Text = item.Confidence.ToString();
                }

            }
            pictureBoxToRender.Image = img;
        }
    }
}
