using UnityEngine;

namespace Blake
{
	[System.Serializable]
	public class Item
	{
		public string ItemName => name;
		public Sprite ItemSprite => itemSprite;
		public int Cost => cost;

		[SerializeField] private string name;
		[SerializeField] private Sprite itemSprite;
		[SerializeField] private int cost;
	}
}