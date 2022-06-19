using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class DynamicArray {

	/// <summary>
	/// The hash of the Dynamic array.
	/// </summary>
	public Dictionary<string, Hashtable> dArray = new Dictionary<string, Hashtable>();

	public int Left = 0;
	public int Right = 0;
	public int Top = 0;
	public int Bottom = 0;
	/// <summary>
	/// Gets or sets the <see cref="DynamicArray"/> with the specified x y.
	/// </summary>
	/// <param name="x">The x coordinate.</param>
	/// <param name="y">The y coordinate.</param>
	public string this[int x, int y]{
		get { 
			if (dArray.ContainsKey(x.ToString())) {
				if (dArray[x.ToString()].ContainsKey(y.ToString())) {
					return dArray [x.ToString ()] [y.ToString ()].ToString();
				}
			}
			return "";
		}
		set { 
			if (!dArray.ContainsKey(x.ToString())) {
				dArray [x.ToString ()] = new Hashtable ();
			}
			dArray [x.ToString ()] [y.ToString ()] = value;
			if (x <= Left) {
				Left = x-1;
			}
			if (x >= Right) {
				Right = x+1;
			}
			if (y <= Top) {
				Top = y-1;
			}
			if (y >= Bottom) {
				Bottom = y+1;
			}
		}
	}
}
