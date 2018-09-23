using System.Collections.Generic;

namespace ImageRecognizer {
	public class Angles {
		List<byte[,]> angles = new List<byte[,]>();

		angles.Add( new byte[,] { {1, 0, 1}, {0, 1, 0}, {0, 0, 0}}	);
		angles.Add( new byte[,] { {0, 0, 0}, {1, 1, 0}, {0, 1, 0}}	);
		angles.Add( new byte[,] { {0, 0, 0}, {0, 1, 1}, {0, 1, 0}}	);
		angles.Add( new byte[,] { {0, 1, 0}, {0, 1, 1}, {0, 0, 0}}	);
		angles.Add( new byte[,] { {1, 0, 1}, {0, 1, 0}, {0, 0, 0}}	);
		angles.Add( new byte[,] { {1, 0, 0}, {0, 1, 0}, {1, 0, 0}}	);
		angles.Add( new byte[,] { {0, 0, 0}, {0, 1, 0}, {1, 0, 1}}	);
		angles.Add( new byte[,] { {0, 0, 1}, {0, 1, 0}, {0, 0, 1}}	);
	}
}