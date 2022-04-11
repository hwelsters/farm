using UnityEngine;

[CreateAssetMenu(fileName="Item", menuName="Create new item")]
public class ItemInfo : ScriptableObject
{
    public string name;
    public string description;

    public int basePrice;
}