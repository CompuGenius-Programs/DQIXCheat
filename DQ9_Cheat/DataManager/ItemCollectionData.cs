﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.DataManager.ItemCollectionData
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

using DQ9_Cheat.GameData;

namespace DQ9_Cheat.DataManager;

internal class ItemCollectionData
{
    private readonly DataValue<ushort> _compCount;

    private readonly DataValue<byte>[] _itemCollectionFlag =
        new DataValue<byte>[ItemDataList.MaxItemCollectionIndex / 8 + 1];

    public ItemCollectionData(SaveData owner)
    {
        _compCount = new DataValue<ushort>(owner, 16045U, null, 0, ushort.MaxValue);
        for (uint index = 0; index < _itemCollectionFlag.Length; ++index)
            _itemCollectionFlag[(int)index] = new DataValue<byte>(owner, 12240U + index, null, 0, byte.MaxValue);
    }

    public ushort CompCount => (ushort)((_compCount.Value & 1022) >> 1);

    public void ReviseCompCount()
    {
        ushort num = 0;
        for (var dataIndex = 7; dataIndex <= ItemDataList.MaxItemCollectionIndex; ++dataIndex)
            if (IsItemCollectionHold(dataIndex))
                ++num;
        _compCount.Value = (ushort)((_compCount.Value & 64513) | ((num << 1) & 1022));
    }

    public bool IsItemCollectionHold(int dataIndex)
    {
        return (_itemCollectionFlag[dataIndex >> 3].Value & (1 << (dataIndex % 8))) != 0;
    }

    public void SetItemCollectionHold(int dataIndex, bool value)
    {
        var index = dataIndex >> 3;
        var num = dataIndex % 8;
        var dataValue = _itemCollectionFlag[index];
        dataValue.Value = (byte)((dataValue.Value & ~(1 << num)) | (value ? 1 << num : 0));
    }
}