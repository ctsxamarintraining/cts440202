using System;

namespace ArrayExercise
{
	public class ArrayFourD
	{string [,,,] fourDimentional = new string[2,2,2,2];

		/// <summary>
		/// Creating an Array of Four Dimention
		/// </summary>
		public Array Create4DStringArray(){

			int num = 0;
			for (int i = 0; i < 2; i++) {

				for (int j = 0; j < 2; j++) {

					for (int k = 0; k < 2; k++) {

						for (int l = 0; l < 2; l++) {
							num++;
							fourDimentional[i,j,k,l] = "Name: " + num;
						}
					}
				}
			}

			return fourDimentional;
		}

		public ArrayFourD ()
		{
		}
	}
}

