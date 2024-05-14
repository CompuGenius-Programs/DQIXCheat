﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.DataManager.ItemData
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: C:\Users\yzsco\Downloads\dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

using DQ9_Cheat.GameData;
using System.Windows.Forms;

#nullable disable
namespace DQ9_Cheat.DataManager
{
  internal class ItemData
  {
    public const int BagMaxCount = 152;
    public const int ImportantMaxCount = 94;
    public const int WeaponMaxCount = 272;
    public const int ShieldMaxCount = 48;
    public const int HeadMaxCount = 144;
    public const int UpperBodyMaxCount = 192;
    public const int ArmMaxCount = 80;
    public const int LowerBodyMaxCount = 96;
    public const int ShoeMaxCount = 112;
    public const int AccessoryMaxCount = 64;
    private DataValue<ushort>[,] _tools = new DataValue<ushort>[4, 8];
    private DataValue<ushort>[] _bag = new DataValue<ushort>[152];
    private DataValue<byte>[] _bagNum = new DataValue<byte>[152];
    private DataValue<ushort>[] _important = new DataValue<ushort>[94];
    private DataValue<byte>[] _importantNum = new DataValue<byte>[94];
    private DataValue<ushort>[] _weapon = new DataValue<ushort>[272];
    private DataValue<byte>[] _weaponNum = new DataValue<byte>[272];
    private DataValue<ushort>[] _shield = new DataValue<ushort>[48];
    private DataValue<byte>[] _shieldNum = new DataValue<byte>[48];
    private DataValue<ushort>[] _head = new DataValue<ushort>[144];
    private DataValue<byte>[] _headNum = new DataValue<byte>[144];
    private DataValue<ushort>[] _upperBody = new DataValue<ushort>[192];
    private DataValue<byte>[] _upperBodyNum = new DataValue<byte>[192];
    private DataValue<ushort>[] _arm = new DataValue<ushort>[80];
    private DataValue<byte>[] _armNum = new DataValue<byte>[80];
    private DataValue<ushort>[] _lowerBody = new DataValue<ushort>[96];
    private DataValue<byte>[] _lowerBodyNum = new DataValue<byte>[96];
    private DataValue<ushort>[] _shoe = new DataValue<ushort>[112];
    private DataValue<byte>[] _shoeNum = new DataValue<byte>[112];
    private DataValue<ushort>[] _accessory = new DataValue<ushort>[64];
    private DataValue<byte>[] _accessoryNum = new DataValue<byte>[64];

    public ItemData(SaveData owner)
    {
      for (int index1 = 0; index1 < 4; ++index1)
      {
        for (int index2 = 0; index2 < 8; ++index2)
          this._tools[index1, index2] = new DataValue<ushort>(owner, (uint) (7578 + 18 * index1 + 2 * index2), (Control) null, (ushort) 0, ushort.MaxValue);
      }
      for (int index = 0; index < 152; ++index)
      {
        this._bag[index] = new DataValue<ushort>(owner, (uint) (7664 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._bagNum[index] = new DataValue<byte>(owner, (uint) (7968 + index), (Control) null, (byte) 0, (byte) 99);
      }
      for (int index = 0; index < 94; ++index)
      {
        this._important[index] = new DataValue<ushort>(owner, (uint) (11164 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._importantNum[index] = new DataValue<byte>(owner, (uint) (11352 + index), (Control) null, (byte) 0, (byte) 99);
      }
      for (int index = 0; index < 272; ++index)
      {
        this._weapon[index] = new DataValue<ushort>(owner, (uint) (8120 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._weaponNum[index] = new DataValue<byte>(owner, (uint) (10136 + index), (Control) null, (byte) 0, (byte) 99);
      }
      for (int index = 0; index < 48; ++index)
      {
        this._shield[index] = new DataValue<ushort>(owner, (uint) (8664 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._shieldNum[index] = new DataValue<byte>(owner, (uint) (10408 + index), (Control) null, (byte) 0, (byte) 99);
      }
      for (int index = 0; index < 144; ++index)
      {
        this._head[index] = new DataValue<ushort>(owner, (uint) (9336 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._headNum[index] = new DataValue<byte>(owner, (uint) (10744 + index), (Control) null, (byte) 0, (byte) 99);
      }
      for (int index = 0; index < 192; ++index)
      {
        this._upperBody[index] = new DataValue<ushort>(owner, (uint) (8760 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._upperBodyNum[index] = new DataValue<byte>(owner, (uint) (10456 + index), (Control) null, (byte) 0, (byte) 99);
      }
      for (int index = 0; index < 80; ++index)
      {
        this._arm[index] = new DataValue<ushort>(owner, (uint) (9624 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._armNum[index] = new DataValue<byte>(owner, (uint) (10888 + index), (Control) null, (byte) 0, (byte) 99);
      }
      for (int index = 0; index < 96; ++index)
      {
        this._lowerBody[index] = new DataValue<ushort>(owner, (uint) (9144 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._lowerBodyNum[index] = new DataValue<byte>(owner, (uint) (10648 + index), (Control) null, (byte) 0, (byte) 99);
      }
      for (int index = 0; index < 112; ++index)
      {
        this._shoe[index] = new DataValue<ushort>(owner, (uint) (9784 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._shoeNum[index] = new DataValue<byte>(owner, (uint) (10968 + index), (Control) null, (byte) 0, (byte) 99);
      }
      for (int index = 0; index < 64; ++index)
      {
        this._accessory[index] = new DataValue<ushort>(owner, (uint) (10008 + 2 * index), (Control) null, (ushort) 0, ushort.MaxValue);
        this._accessoryNum[index] = new DataValue<byte>(owner, (uint) (11080 + index), (Control) null, (byte) 0, (byte) 99);
      }
    }

    public ItemDataBase GetTool(int partyIndex, int toolIndex)
    {
      return partyIndex < 4 && toolIndex >= 0 && toolIndex < 8 ? ItemDataList.GetItem(ItemType.Tool, this._tools[partyIndex, toolIndex].Value) : (ItemDataBase) null;
    }

    public void SetTool(int partyIndex, int toolIndex, ItemDataBase item)
    {
      if (partyIndex >= 4 || toolIndex < 0 || toolIndex >= 8)
        return;
      this._tools[partyIndex, toolIndex].Value = item != null ? item.Value : ushort.MaxValue;
    }

    public ItemDataBase GetItemData(ItemType itemType, int index)
    {
      DataValue<ushort>[] itemDataList = this.GetItemDataList(itemType);
      return index >= 0 && index < itemDataList.Length ? ItemDataList.GetItem(itemType, itemDataList[index].Value) : (ItemDataBase) null;
    }

    public void SetItemData(ItemType itemType, int index, ItemDataBase item)
    {
      DataValue<ushort>[] itemDataList = this.GetItemDataList(itemType);
      if (index < 0 || index >= itemDataList.Length)
        return;
      if (item != null)
        itemDataList[index].Value = item.Value;
      else
        itemDataList[index].Value = ushort.MaxValue;
    }

    public DataValue<byte> GetItemNum(ItemType itemType, int index)
    {
      DataValue<byte>[] itemNumList = this.GetItemNumList(itemType);
      return index >= 0 && index < itemNumList.Length ? itemNumList[index] : (DataValue<byte>) null;
    }

    private int GetItemMaxCount(ItemType itemType)
    {
      switch (itemType)
      {
        case ItemType.Tool:
          return 152;
        case ItemType.important:
          return 94;
        case ItemType.Weapon:
          return 272;
        case ItemType.Shield:
          return 48;
        case ItemType.Head:
          return 144;
        case ItemType.UpperBody:
          return 192;
        case ItemType.Arm:
          return 80;
        case ItemType.LowerBody:
          return 96;
        case ItemType.Shoe:
          return 112;
        case ItemType.Accessory:
          return 64;
        default:
          return 0;
      }
    }

    private DataValue<ushort>[] GetItemDataList(ItemType itemType)
    {
      switch (itemType)
      {
        case ItemType.Tool:
          return this._bag;
        case ItemType.important:
          return this._important;
        case ItemType.Weapon:
          return this._weapon;
        case ItemType.Shield:
          return this._shield;
        case ItemType.Head:
          return this._head;
        case ItemType.UpperBody:
          return this._upperBody;
        case ItemType.Arm:
          return this._arm;
        case ItemType.LowerBody:
          return this._lowerBody;
        case ItemType.Shoe:
          return this._shoe;
        case ItemType.Accessory:
          return this._accessory;
        default:
          return (DataValue<ushort>[]) null;
      }
    }

    private DataValue<byte>[] GetItemNumList(ItemType itemType)
    {
      switch (itemType)
      {
        case ItemType.Tool:
          return this._bagNum;
        case ItemType.important:
          return this._importantNum;
        case ItemType.Weapon:
          return this._weaponNum;
        case ItemType.Shield:
          return this._shieldNum;
        case ItemType.Head:
          return this._headNum;
        case ItemType.UpperBody:
          return this._upperBodyNum;
        case ItemType.Arm:
          return this._armNum;
        case ItemType.LowerBody:
          return this._lowerBodyNum;
        case ItemType.Shoe:
          return this._shoeNum;
        case ItemType.Accessory:
          return this._accessoryNum;
        default:
          return (DataValue<byte>[]) null;
      }
    }

    public void PossessAll(ItemType itemType, byte count)
    {
      DataValue<ushort>[] itemDataList = this.GetItemDataList(itemType);
      DataValue<byte>[] itemNumList = this.GetItemNumList(itemType);
      ItemDataBase[] list = ItemDataList.GetList(itemType, (string) null);
      for (int index = 0; index < this.GetItemMaxCount(itemType); ++index)
      {
        if (list.Length > index)
        {
          itemDataList[index].Value = list[index].Value;
          itemNumList[index].Value = count;
        }
        else
        {
          itemDataList[index].Value = ushort.MaxValue;
          itemNumList[index].Value = (byte) 0;
        }
      }
    }

    public void RemoveAll(ItemType itemType)
    {
      DataValue<ushort>[] itemDataList = this.GetItemDataList(itemType);
      DataValue<byte>[] itemNumList = this.GetItemNumList(itemType);
      for (int index = 0; index < this.GetItemMaxCount(itemType); ++index)
      {
        itemDataList[index].Value = ushort.MaxValue;
        itemNumList[index].Value = (byte) 0;
      }
    }

    public void SetCountHaving(ItemType itemType, byte count)
    {
      DataValue<ushort>[] itemDataList = this.GetItemDataList(itemType);
      DataValue<byte>[] itemNumList = this.GetItemNumList(itemType);
      for (int index = 0; index < this.GetItemMaxCount(itemType); ++index)
      {
        if (itemDataList[index].Value != ushort.MaxValue)
          itemNumList[index].Value = count;
      }
    }

    public int RemoveOverlap(ItemType itemType)
    {
      DataValue<ushort>[] itemDataList = this.GetItemDataList(itemType);
      DataValue<byte>[] itemNumList = this.GetItemNumList(itemType);
      int num = 0;
      for (int index1 = 0; index1 < this.GetItemMaxCount(itemType) - 1; ++index1)
      {
        if (itemDataList[index1].Value != ushort.MaxValue)
        {
          for (int index2 = index1 + 1; index2 < this.GetItemMaxCount(itemType); ++index2)
          {
            if (itemDataList[index2].Value != ushort.MaxValue && (int) itemDataList[index1].Value == (int) itemDataList[index2].Value)
            {
              itemDataList[index2].Value = ushort.MaxValue;
              itemNumList[index2].Value = (byte) 0;
              ++num;
            }
          }
        }
      }
      if (num > 0)
        this.SqueezeGap(itemType);
      return num;
    }

    public void SqueezeGap(ItemType itemType)
    {
      int index1 = -1;
      DataValue<ushort>[] itemDataList = this.GetItemDataList(itemType);
      DataValue<byte>[] itemNumList = this.GetItemNumList(itemType);
      for (int index2 = 0; index2 < this.GetItemMaxCount(itemType) - 1; ++index2)
      {
        if (itemDataList[index2].Value != ushort.MaxValue)
        {
          if (index1 != -1)
          {
            itemDataList[index1].Value = itemDataList[index2].Value;
            itemDataList[index2].Value = ushort.MaxValue;
            itemNumList[index1].Value = itemNumList[index2].Value;
            itemNumList[index2].Value = (byte) 0;
            ++index1;
          }
        }
        else if (index1 == -1)
          index1 = index2;
      }
    }
  }
}