using UnityEngine;

namespace FlMr_Inventory
{
    public abstract class ItemBase : ScriptableObject
    {
        [SerializeField] private int uniqueId;
        [SerializeField] private string itemName;
        [SerializeField] private Sprite icon;
        [SerializeField] private string description;

        /// <summary>
        /// アイテムの種類と1:1対応する整数
        /// (データを保存するときや、将来通信機能を実装する際に真価を発揮する)
        /// </summary>
        public int UniqueId => uniqueId;

        /// <summary>
        /// アイテム名
        /// </summary>
        public string ItemName => itemName;

        /// <summary>
        /// アイテムのアイコン
        /// </summary>
        public Sprite Icon => icon;

        /// <summary>
        /// プレイヤーに対するアイテムの説明
        /// </summary>
        public string Description => description;
    }
}