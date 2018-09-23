using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageRecognizer {
	internal class Program {
		public static void Main(string[] args) {
			Bitmap bitmap = new Bitmap("file.bmp");
			int x = bitmap.Width;
			int y = bitmap.Height;
			byte[,] arr = new byte[x,y];
			for (int i = 0; i < x; i++) {
				for (int j = 0; j < y; j++) {
					Color pixel = bitmap.GetPixel(i, j);
					arr[i, j] = pixel.ToArgb() == Color.White.ToArgb() ? (byte) 0 : (byte) 1;
					Console.Write(arr[i,j]);
				}
				Console.WriteLine();
			}
		}
	}
}