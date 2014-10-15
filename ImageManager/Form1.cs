using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageManager
{
	public partial class Form1 : Form
	{

		public Form1 ()
		{

			InitializeComponent();



			#region removed
			//listView1.LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;

			//// Construct the ImageList.
			//ImageList MyImageList = new ImageList();
			//// Set the ImageSize property to a larger size  
			//// (the default is 16 x 16).
			//MyImageList.ImageSize = new Size(250, 250);

			////set listview properties
			//listView1.View = View.LargeIcon;
			//listView1.CheckBoxes = true;
			////listView1.LargeImageList = MyImageList;
			////listView1.SmallImageList = MyImageList;
			//listView1.LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			//listView1.SmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;

			//string[] imdDir = System.IO.Directory.GetFiles(@"C:\Users\lasse\Pictures\desktops");
			//int currentImage = 0;

			//foreach ( string strImage in imdDir )
			//{

			//	if ( currentImage <= imdDir.Length )
			//	{
			//		bool boolIsImage = strImage.Contains("jpg");
			//		if ( boolIsImage == true )
			//		{

			//			MyImageList.Images.Add(Image.FromFile(strImage));
			//			this.richTextBox1.Text += strImage + " \n";



			//			listView1.Items[currentImage].ImageIndex = ( currentImage + 1 );
			//			listView1.Items.Add(strImage);
			//			this.Controls.Add(listView1);

			//			currentImage++;

			//		}
			//	}
			//}


			//// Get a Graphics object from the form's handle.
			//Graphics theGraphics = Graphics.FromHwnd(this.Handle);

			//// Loop through the images in the list, drawing each image. 
			//for ( int count = 0; count < MyImageList.Images.Count; count++ )
			//	{
			//	//MyImageList.Draw(theGraphics , new Point(85 , 85) , count);


			//	// Call Application.DoEvents to force a repaint of the form.
			//	Application.DoEvents();


			//	// Call the Sleep method to allow the user to see the image.
			//	System.Threading.Thread.Sleep(1000);
			//	}

			#endregion



		}

		private void Form1_Load (object sender, EventArgs e)
		{


		}


		private void button1_Click (object sender, EventArgs e)
		{

			string[] imgPath;
			int currentImage = 0;

			ImageList imgList = new ImageList();
			imgList.ImageSize = new Size(150, 150);
			imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			imgList.TransparentColor = Color.White;

			listView1.View = View.LargeIcon;
			listView1.CheckBoxes = true;
			listView1.LargeImageList = imgList;
			listView1.SmallImageList = imgList;
			listView1.LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			listView1.SmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;

			imgPath = Directory.GetFiles(@"C:\Users\lasse\Pictures\desktops");

			foreach ( string strImage in imgPath )
			{

				if ( currentImage <= imgPath.Length )
				{
					bool boolIsImage = strImage.Contains("jpg");
					if ( boolIsImage == true )
					{

						imgList.Images.Add(Image.FromFile(strImage));
						//richTextBox1.Text += strImage + " \n";
						listView1.BeginUpdate();
						//listView1.Items[currentImage].ImageIndex = ( currentImage + 1 );
						listView1.Items.Add(strImage, currentImage);
						listView1.EndUpdate();
						currentImage++;

					}
				}
			}



		}



		private void CheckItemSelected (object sender, ItemCheckedEventArgs e)
		{
			//richTextBox1.Text="";
			
			//	ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;
				
			//	///Select item that is checked if not selected
			//	//if ( listView1.SelectedItems.Count >= 0 )
			//	//{
			//	//	if ( e.Item.Index > 0 )
			//	//	{
			//	//		checkedItems[e.Item.Index].Selected= true;
			//	//		richTextBox1.Text = listView1.FocusedItem.Text;
			//	//		pictureBox1.Image = Image.FromFile(listView1.FocusedItem.Text);
			//	//		pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			//	//	}
			//	//}

			//	foreach ( ListViewItem item in checkedItems )
			//	{
			//		//richTextBox1.Text += this.listView1.Items[e.Item.Index].SubItems[1].Text + "\n";
			//		richTextBox1.Text = listView1.Items[e.Item.Index].Text + "\n";
			//	}
			//	//if (e.Item.Checked .CurrentValue==CheckState.Unchecked)
			//	//{

			//	//}
			//	//else if((e.CurrentValue==CheckState.Checked))
			//	//{

			//	//}
			//	//// Output the price to TextBox1.
			//	//TextBox1.Text = price.ToString();

			//	//richTextBox1.Text = listView1.CheckedItems;
			

		}

		private void ItemSelectedChange (object sender, ListViewItemSelectionChangedEventArgs e)
		{
			
			if ( listView1.SelectedItems.Count > 0 )
			{
				richTextBox1.Text = listView1.FocusedItem.Text;
				pictureBox1.Image = Image.FromFile(listView1.FocusedItem.Text);
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

			}
		}

		private void CheckItemCheck (object sender, ItemCheckEventArgs e)
		{
			ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;
			if (checkedItems.Count > 0)
			{
				//che
			}
		}

		private void button2_Click (object sender, EventArgs e)
		{
			
		}




	}
}
