using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGrayscaleBrightenedEdge
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			checkBoxChangeBrightness.Checked = true;
			checkBoxChangeBoundaryValue.Checked = true;
        }

        Bitmap _bitmap = null;
		Bitmap pictureBoxBitmap2
		{
			set {
				_bitmap?.Dispose();
				_bitmap = value;
				pictureBox2.Image = _bitmap;
			}
		}

        protected override void OnLoad(EventArgs e)
        {
            Bitmap bitmap = Properties.Resources.image;
            pictureBox1.Image = bitmap;

            base.OnLoad(e);
        }

        private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = (Bitmap)pictureBox1.Image;
			pictureBoxBitmap2 = GetGrayscaleBitmap(bitmap);
		}

		Bitmap GetGrayscaleBitmap(Bitmap bitmap)
		{
			Bitmap ret = new Bitmap(bitmap.Width, bitmap.Height);
			for (int y = 0; y < bitmap.Height; y++)
			{
				for (int x = 0; x < bitmap.Width; x++)
				{
					Color color = bitmap.GetPixel(x, y);
					int value = (color.R + color.G + color.B) / 3;
					Color newColor = Color.FromArgb(value, value, value);
					ret.SetPixel(x, y, newColor);
				}
			}
			return ret;
		}

		Bitmap GetBrightenedBitmap(Bitmap bitmap, int value)
		{
			Bitmap ret = new Bitmap(bitmap.Width, bitmap.Height);
			for (int y = 0; y < bitmap.Height; y++)
			{
				for (int x = 0; x < bitmap.Width; x++)
				{
					Color color = bitmap.GetPixel(x, y);
					int r = color.R + value > 255 ? 255 : color.R + value;
					int g = color.G + value > 255 ? 255 : color.G + value;
					int b = color.B + value > 255 ? 255 : color.B + value;
					r = r < 0 ? 0 : r;
					g = g < 0 ? 0 : g;
					b = b < 0 ? 0 : b;
					Color newColor = Color.FromArgb(r, g, b);
					ret.SetPixel(x, y, newColor);
				}
			}
			return ret;
		}

		private void checkBoxChangeBrightness_CheckedChanged(object sender, EventArgs e)
		{
			trackBarBrightness.Enabled= checkBoxChangeBrightness.Checked;
		}

		private void trackBarBrightness_Scroll(object sender, EventArgs e)
		{
		}

		private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
		{
			checkBoxChangeBrightness.Text = $"明るさ変更 {trackBarBrightness.Value}";
			Bitmap bitmap = (Bitmap)pictureBox1.Image;
			pictureBoxBitmap2 = GetBrightenedBitmap(bitmap, trackBarBrightness.Value);
		}

		Bitmap GetEdgeBitmap(Bitmap bitmap, int boundaryValue)
		{
			int[,] ints = new int[bitmap.Height, bitmap.Width];
			for (int y = 0; y < bitmap.Height; y++)
			{
				for (int x = 0; x < bitmap.Width; x++)
				{
					Color color = bitmap.GetPixel(x, y);
					ints[y, x] = (color.R + color.G + color.B) / 3;
				}
			}

			bool[,] isBorders = new bool[bitmap.Height, bitmap.Width];

			for (int y = 0; y < bitmap.Height; y++)
			{
				for (int x = 0; x < bitmap.Width; x++)
				{
					bool b1 = x + 1 < bitmap.Width && Math.Abs(ints[y, x] - ints[y, x + 1]) > boundaryValue;
					bool b2 = y + 1 < bitmap.Height && Math.Abs(ints[y, x] - ints[y + 1, x]) > boundaryValue;
					isBorders[y, x] = b1 || b2;
				}
			}

			Bitmap ret = new Bitmap(bitmap.Width, bitmap.Height);
			for (int y = 0; y < bitmap.Height; y++)
			{
				for (int x = 0; x < bitmap.Width; x++)
				{
					if (isBorders[y, x])
						ret.SetPixel(x, y, Color.Black);
					else
						ret.SetPixel(x, y, Color.White);
				}
			}
			return ret;
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void checkBoxChangeBoundaryValue_CheckedChanged(object sender, EventArgs e)
		{
			trackBarBoundaryValue.Enabled = checkBoxChangeBoundaryValue.Checked;
		}

		private void trackBarBoundaryValue_ValueChanged(object sender, EventArgs e)
		{
			Bitmap bitmap = (Bitmap)pictureBox1.Image;

			//境界値変更
			int boundaryValue = trackBarBoundaryValue.Value;
			checkBoxChangeBoundaryValue.Text = $"境界値変更 {boundaryValue}";
			pictureBoxBitmap2 = GetEdgeBitmap(bitmap, boundaryValue);
		}

		private void trackBarBrightness_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Left)
					trackBarBrightness.Value -= trackBarBrightness.LargeChange;
				if (e.KeyCode == Keys.Right)
					trackBarBrightness.Value += trackBarBrightness.LargeChange;
			}
			catch
			{
			}
			e.Handled = true;
		}

		private void trackBarBoundaryValue_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Left)
					trackBarBoundaryValue.Value -= trackBarBoundaryValue.LargeChange;
				if (e.KeyCode == Keys.Right)
					trackBarBoundaryValue.Value += trackBarBoundaryValue.LargeChange;
			}
			catch
			{
			}
			e.Handled = true;
		}
	}
}
