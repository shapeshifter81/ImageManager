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
	public partial class ClassImageList 
	{
		//private string[] imgPath;
		//private int currentImage = 0;

		//public ImageList strPubImagePath (string dirPath)
		//{

			//ImageList imgList = new ImageList();
			//imgList.ImageSize = new Size(250, 250);
			//imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			//imgList.TransparentColor = Color.White;

			

			//if ( Directory.Exists(dirPath) )
			//{
			//	imgPath = Directory.GetFiles(dirPath);

			//	foreach ( string strImage in imgPath )
			//	{
					
			//		if ( currentImage <= imgPath.Length)
						
			//		{
			//			bool boolIsImage = strImage.Contains("jpg");
			//			if ( boolIsImage == true )
			//			{
			//				imgList.Images.Add(Image.FromFile(strImage));
			//				//this.richTextBox1.Text += strImage + " \n";

			//				//listView1.Items[currentImage].ImageIndex = ( currentImage + 1 );
			//				//listView1.Items.Add(strImage);
			//				//this.Controls.Add(listView1);
			//				//string[] imgListFiles;
			//				//imgListFiles = imgPath;
			//				currentImage++;
			//				return imgList;			
							
			//			}
			//		}
			//	}


			//}
			//else
			//{
			//	imgPath = Directory.GetFiles(System.Environment.GetFolderPath(
			//		System.Environment.SpecialFolder.MyPictures));

			//}
			
			/////delete

			//return imgList;
		//}

		public ClassImageList ()
		{
			
		}



	}


}
