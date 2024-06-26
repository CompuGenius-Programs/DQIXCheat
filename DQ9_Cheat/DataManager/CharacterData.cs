﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.DataManager.CharacterData
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

using System;
using DQ9_Cheat.GameData;

namespace DQ9_Cheat.DataManager;

internal class CharacterData
{
    public const int DataSize = 572;
    private const uint CharacterDataOffset = 136;
    private readonly DataValue<byte> _color;
    private readonly DataValue<ushort> _equipmentAccessory;
    private readonly DataValue<ushort> _equipmentArm;
    private readonly DataValue<ushort> _equipmentHead;
    private readonly DataValue<ushort> _equipmentLowerBody;
    private readonly DataValue<ushort> _equipmentShield;
    private readonly DataValue<ushort> _equipmentShoe;
    private readonly DataValue<ushort> _equipmentUpperBody;
    private readonly DataValue<ushort> _equipmentWeapon;
    private readonly DataValue<byte> _eyeColor;
    private readonly DataValue<ushort> _maxHP;
    private readonly DataValue<ushort> _maxMP;
    private readonly DataValue<ushort> _nowHP;
    private readonly DataValue<ushort> _nowMP;
    private readonly DataValue<byte> _rank;
    private readonly DataValue<uint>[] _reviseAtmgcHPMP = new DataValue<uint>[13];
    private readonly DataValue<uint>[] _reviseFacSmartRev = new DataValue<uint>[13];
    private readonly DataValue<uint>[] _revisePowQuickDef = new DataValue<uint>[13];
    private readonly DataValue<byte> _sex;

    private readonly DataValue<byte>[] _skillSpecialtyEffect =
        new DataValue<byte>[SkillDataList.SpecialtyEffectMaxIndex / 8 + 1];

    private readonly DataValue<byte> _skinColor;
    private readonly DataValue<byte> _specialtyCheer;
    private readonly DataValue<byte> _specialtyRuler;
    private readonly DataValue<byte> _state;
    private readonly DataValue<byte> _strategy;
    private readonly DataValue<byte>[] _transmigration = new DataValue<byte>[13];

    public CharacterData(SaveData owner, uint index)
    {
        var characterDataControl = MainWindow.Instance.CharacterDataControl;
        Index = index;
        var num = 572U * index;
        _state = new DataValue<byte>(owner, 454U + num, null, 0, byte.MaxValue);
        Name = new DataValueString(owner, 456U + num, null, 10, true);
        _sex = new DataValue<byte>(owner, 508U + num, null, 0, byte.MaxValue);
        Job = new DataValue<byte>(owner, 216U + num, null, 0, (byte)(JobDataList.List.Count - 1));
        for (var index1 = 0; index1 < 13; ++index1)
        {
            JobLevel[index1] = new DataValue<byte>(owner, (uint)((ulong)(138 + index1) + num), null, 0, 99);
            JobExperience[index1] =
                new DataValue<uint>(owner, (uint)((ulong)(164 + 4 * index1) + num), null, 0U, 999999999U);
            _transmigration[index1] =
                new DataValue<byte>(owner, (uint)((ulong)(151 + index1) + num), null, 0, byte.MaxValue);
            _revisePowQuickDef[index1] = new DataValue<uint>(owner, (uint)(224U + num + (ulong)(12 * index1)), null, 0U,
                uint.MaxValue);
            _reviseFacSmartRev[index1] = new DataValue<uint>(owner, (uint)(228U + num + (ulong)(12 * index1)), null, 0U,
                uint.MaxValue);
            _reviseAtmgcHPMP[index1] =
                new DataValue<uint>(owner, (uint)(232U + num + (ulong)(12 * index1)), null, 0U, uint.MaxValue);
        }

        for (var index2 = 0; index2 < SkillDataList.List.Count; ++index2)
            JobSkillLevel[index2] = new DataValue<byte>(owner, (uint)(383U + num + (ulong)index2), null, 0, 100);
        _specialtyRuler = new DataValue<byte>(owner, 416U + num, null, 0, byte.MaxValue);
        _specialtyCheer = new DataValue<byte>(owner, 453U + num, null, 0, byte.MaxValue);
        for (var index3 = 0; index3 < SkillDataList.SpecialtyEffectMaxIndex / 8 + 1; ++index3)
            _skillSpecialtyEffect[index3] =
                new DataValue<byte>(owner, (uint)((ulong)(418 + index3) + num), null, 0, byte.MaxValue);
        _nowHP = new DataValue<ushort>(owner, 477U + num, characterDataControl.NumericUpDown_NowHP, 0, ushort.MaxValue);
        _maxHP = new DataValue<ushort>(owner, 480U + num, null, 0, ushort.MaxValue);
        _nowMP = new DataValue<ushort>(owner, 478U + num, characterDataControl.NumericUpDown_NowMP, 0, ushort.MaxValue);
        _maxMP = new DataValue<ushort>(owner, 481U + num, null, 0, ushort.MaxValue);
        FigureWidth = new DataValue<ushort>(owner, 512U + num, null, 0, ushort.MaxValue);
        FigureHeight = new DataValue<ushort>(owner, 514U + num, null, 0, ushort.MaxValue);
        HairType = new DataValue<byte>(owner, 494U + num, null, 0, byte.MaxValue);
        HairColor = new DataValue<byte>(owner, 509U + num, null, 0, byte.MaxValue);
        FaceType = new DataValue<byte>(owner, 492U + num, null, 0, byte.MaxValue);
        _skinColor = new DataValue<byte>(owner, 508U + num, null, 0, byte.MaxValue);
        _eyeColor = new DataValue<byte>(owner, 508U + num, null, 0, byte.MaxValue);
        _equipmentWeapon = new DataValue<ushort>(owner, 502U + num, null, 0, ushort.MaxValue);
        _equipmentShield = new DataValue<ushort>(owner, 504U + num, null, 0, ushort.MaxValue);
        _equipmentHead = new DataValue<ushort>(owner, 500U + num, null, 0, ushort.MaxValue);
        _equipmentUpperBody = new DataValue<ushort>(owner, 488U + num, null, 0, ushort.MaxValue);
        _equipmentArm = new DataValue<ushort>(owner, 496U + num, null, 0, ushort.MaxValue);
        _equipmentLowerBody = new DataValue<ushort>(owner, 490U + num, null, 0, ushort.MaxValue);
        _equipmentShoe = new DataValue<ushort>(owner, 498U + num, null, 0, ushort.MaxValue);
        _equipmentAccessory = new DataValue<ushort>(owner, 506U + num, null, 0, ushort.MaxValue);
        _equipmentWeapon = new DataValue<ushort>(owner, 502U + num, null, 0, ushort.MaxValue);
        SkillPoint = new DataValue<ushort>(owner, 380U + num, null, 0, 9999);
        _strategy = new DataValue<byte>(owner, 455U + num, null, 0, byte.MaxValue);
        _rank = new DataValue<byte>(owner, 137U + num, null, 0, byte.MaxValue);
        _color = new DataValue<byte>(owner, 137U + num, null, 0, byte.MaxValue);
        if (index != 0U)
            return;
        characterDataControl.BeginUpdate();
        characterDataControl.NumericUpDown_Level.Minimum = JobLevel[0].Min;
        characterDataControl.NumericUpDown_Level.Maximum = JobLevel[0].Max;
        characterDataControl.NumericUpDown_Experience.Minimum = JobExperience[0].Min;
        characterDataControl.NumericUpDown_Experience.Maximum = JobExperience[0].Max;
        characterDataControl.NumericUpDown_NowHP.Maximum = 999M;
        characterDataControl.NumericUpDown_NowHP.Minimum = _nowHP.Min;
        characterDataControl.NumericUpDown_NowMP.Maximum = 999M;
        characterDataControl.NumericUpDown_NowMP.Minimum = _nowHP.Min;
        characterDataControl.NumericUpDown_FigureWidth.Maximum = FigureWidth.Max;
        characterDataControl.NumericUpDown_FigureWidth.Minimum = FigureWidth.Min;
        characterDataControl.NumericUpDown_FigureHeight.Maximum = FigureHeight.Max;
        characterDataControl.NumericUpDown_FigureHeight.Minimum = FigureHeight.Min;
        characterDataControl.NumericUpDown_Hair.Maximum = HairType.Max;
        characterDataControl.NumericUpDown_Hair.Minimum = HairType.Min;
        characterDataControl.NumericUpDown_HairColor.Maximum = HairColor.Max;
        characterDataControl.NumericUpDown_HairColor.Minimum = HairColor.Min;
        characterDataControl.NumericUpDown_Face.Maximum = FaceType.Max;
        characterDataControl.NumericUpDown_Face.Minimum = FaceType.Min;
        characterDataControl.NumericUpDown_SkinColor.Maximum = 7M;
        characterDataControl.NumericUpDown_SkinColor.Minimum = 0M;
        characterDataControl.NumericUpDown_EyeColor.Maximum = 15M;
        characterDataControl.NumericUpDown_EyeColor.Minimum = 0M;
        characterDataControl.NumericUpDown_SkillPoint.Maximum = SkillPoint.Max;
        characterDataControl.NumericUpDown_SkillPoint.Minimum = SkillPoint.Min;
        characterDataControl.EndUpdate();
    }

    public bool Die
    {
        get => (_state.Value & 1) != 0;
        set => _state.Value = (byte)((_state.Value & 254) | (value ? 1 : 0));
    }

    public bool Poison
    {
        get => (_state.Value & 2) != 0;
        set => _state.Value = (byte)((_state.Value & 253) | (value ? 2 : 0));
    }

    public bool Curse
    {
        get => (_state.Value & 4) != 0;
        set => _state.Value = (byte)((_state.Value & 251) | (value ? 4 : 0));
    }

    public DataValueString Name { get; }

    public byte Sex
    {
        get => (byte)(_sex.Value & 1U);
        set => _sex.Value = (byte)((_sex.Value & 254) | (value == 0 ? 0 : 1));
    }

    public DataValue<byte> Job { get; }

    public DataValue<byte>[] JobLevel { get; } = new DataValue<byte>[13];

    public DataValue<uint>[] JobExperience { get; } = new DataValue<uint>[13];

    public DataValue<byte>[] JobSkillLevel { get; } = new DataValue<byte>[SkillDataList.List.Count];

    public ushort NowHP
    {
        get => (ushort)((_nowHP.Value & 4092) >> 2);
        set => _nowHP.Value = (ushort)((_nowHP.Value & 61443) | (value << 2));
    }

    public ushort MaxHP
    {
        get => (ushort)(_maxHP.Value & 1023U);
        set => _maxHP.Value = (ushort)((_maxHP.Value & 64512U) | value);
    }

    public ushort NowMP
    {
        get => (ushort)((_nowMP.Value & 65520) >> 4);
        set => _nowMP.Value = (ushort)((_nowMP.Value & 15) | (value << 4));
    }

    public ushort MaxMP
    {
        get => (ushort)((_maxMP.Value & 4092) >> 2);
        set => _maxMP.Value = (ushort)((_maxMP.Value & 61443) | (value << 2));
    }

    public DataValue<ushort> FigureWidth { get; }

    public DataValue<ushort> FigureHeight { get; }

    public DataValue<byte> HairType { get; }

    public DataValue<byte> HairColor { get; }

    public DataValue<byte> FaceType { get; }

    public byte SkinColor
    {
        get => (byte)((_skinColor.Value & 14) >> 1);
        set => _skinColor.Value = (byte)((_skinColor.Value & 241) | (value << 1));
    }

    public byte EyeColor
    {
        get => (byte)((_eyeColor.Value & 240) >> 4);
        set => _eyeColor.Value = (byte)((_eyeColor.Value & 15) | (value << 4));
    }

    public ItemDataBase EquipmentWeapon
    {
        get => ItemDataList.GetItem(ItemType.Weapon, _equipmentWeapon.Value);
        set => _equipmentWeapon.Value = value != null ? value.Value : ushort.MaxValue;
    }

    public ItemDataBase EquipmentShield
    {
        get => ItemDataList.GetItem(ItemType.Shield, _equipmentShield.Value);
        set => _equipmentShield.Value = value != null ? value.Value : ushort.MaxValue;
    }

    public ItemDataBase EquipmentHead
    {
        get => ItemDataList.GetItem(ItemType.Head, _equipmentHead.Value);
        set => _equipmentHead.Value = value != null ? value.Value : ushort.MaxValue;
    }

    public ItemDataBase EquipmentUpperBody
    {
        get => ItemDataList.GetItem(ItemType.UpperBody, _equipmentUpperBody.Value);
        set => _equipmentUpperBody.Value = value != null ? value.Value : ushort.MaxValue;
    }

    public ItemDataBase EquipmentArm
    {
        get => ItemDataList.GetItem(ItemType.Arm, _equipmentArm.Value);
        set => _equipmentArm.Value = value != null ? value.Value : ushort.MaxValue;
    }

    public ItemDataBase EquipmentLowerBody
    {
        get => ItemDataList.GetItem(ItemType.LowerBody, _equipmentLowerBody.Value);
        set => _equipmentLowerBody.Value = value != null ? value.Value : ushort.MaxValue;
    }

    public ItemDataBase EquipmentShoe
    {
        get => ItemDataList.GetItem(ItemType.Shoe, _equipmentShoe.Value);
        set => _equipmentShoe.Value = value != null ? value.Value : ushort.MaxValue;
    }

    public ItemDataBase EquipmentAccessory
    {
        get => ItemDataList.GetItem(ItemType.Accessory, _equipmentAccessory.Value);
        set => _equipmentAccessory.Value = value != null ? value.Value : ushort.MaxValue;
    }

    public DataValue<ushort> SkillPoint { get; }

    public Strategy Strategy
    {
        get => StrategyList.GetStrategy(_strategy.Value);
        set => _strategy.Value = (byte)((_strategy.Value & 199U) | value.Value);
    }

    public byte Rank
    {
        get => (byte)((_rank.Value >> 4) & 1);
        set => _rank.Value = (byte)((_rank.Value & 15) | (value == 0 ? 0 : 16));
    }

    public byte Color
    {
        get => (byte)(_color.Value & 15U);
        set => _color.Value = (byte)((_color.Value & 240) | (value & 15));
    }

    public uint Index { get; }

    public byte GetTransmigration(int index)
    {
        return _transmigration[index].Value <= 10 ? _transmigration[index].Value : (byte)10;
    }

    public void SetTransmigration(int index, byte value)
    {
        _transmigration[index].Value = (byte)((_transmigration[index].Value & 240) | (value > 10 ? 10 : value));
    }

    public bool IsLearnRular()
    {
        return (_specialtyRuler.Value & 16) != 0;
    }

    public void SetLearnRular(bool value)
    {
        _specialtyRuler.Value = (byte)((_specialtyRuler.Value & 239) | (value ? 16 : 0));
    }

    public bool IsLearnCheer()
    {
        return (_specialtyCheer.Value & 64) != 0;
    }

    public void SetLearnCheer(bool value)
    {
        _specialtyCheer.Value = (byte)((_specialtyCheer.Value & 191) | (value ? 64 : 0));
    }

    public bool IsLearnSkillSpecialtyEffect(int index)
    {
        return (_skillSpecialtyEffect[index / 8].Value & (1 << (index % 8))) != 0;
    }

    public void SetLearnSkillSpecialtyEffect(int index, bool value)
    {
        var num = (byte)~(1 << (index % 8));
        _skillSpecialtyEffect[index / 8].Value =
            (byte)((_skillSpecialtyEffect[index / 8].Value & num) | (value ? ~num : 0));
    }

    public ushort GetRevisePower(int index)
    {
        return index >= 0 && index < 13 ? (ushort)(_revisePowQuickDef[index].Value & 1023U) : (ushort)0;
    }

    public void SetRevisePower(int index, ushort value)
    {
        if (index < 0 || index >= 13)
            return;
        _revisePowQuickDef[index].Value = (_revisePowQuickDef[index].Value & 4294966272U) | value;
    }

    public ushort GetReviseQuick(int index)
    {
        return index >= 0 && index < 13 ? (ushort)((_revisePowQuickDef[index].Value & 1047552U) >> 10) : (ushort)0;
    }

    public void SetReviseQuick(int index, ushort value)
    {
        if (index < 0 || index >= 13)
            return;
        _revisePowQuickDef[index].Value = (uint)(((int)_revisePowQuickDef[index].Value & -1047553) | (value << 10));
    }

    public ushort GetReviseDefense(int index)
    {
        return index >= 0 && index < 13 ? (ushort)((_revisePowQuickDef[index].Value & 1072693248U) >> 20) : (ushort)0;
    }

    public void SetReviseDefense(int index, ushort value)
    {
        if (index < 0 || index >= 13)
            return;
        _revisePowQuickDef[index].Value = (uint)(((int)_revisePowQuickDef[index].Value & -1072693249) | (value << 20));
    }

    public ushort GetReviseFacility(int index)
    {
        return index >= 0 && index < 13 ? (ushort)(_reviseFacSmartRev[index].Value & 1023U) : (ushort)0;
    }

    public void SetReviseFacility(int index, ushort value)
    {
        if (index < 0 || index >= 13)
            return;
        _reviseFacSmartRev[index].Value = (_reviseFacSmartRev[index].Value & 4294966272U) | value;
    }

    public ushort GetReviseSmart(int index)
    {
        return index >= 0 && index < 13 ? (ushort)((_reviseFacSmartRev[index].Value & 1047552U) >> 10) : (ushort)0;
    }

    public void SetReviseSmart(int index, ushort value)
    {
        if (index < 0 || index >= 13)
            return;
        _reviseFacSmartRev[index].Value = (uint)(((int)_reviseFacSmartRev[index].Value & -1047553) | (value << 10));
    }

    public ushort GetReviseRevivalMagic(int index)
    {
        return index >= 0 && index < 13 ? (ushort)((_reviseFacSmartRev[index].Value & 1072693248U) >> 20) : (ushort)0;
    }

    public void SetReviseRevivalMagic(int index, ushort value)
    {
        if (index < 0 || index >= 13)
            return;
        _reviseFacSmartRev[index].Value = (uint)(((int)_reviseFacSmartRev[index].Value & -1072693249) | (value << 20));
    }

    public ushort GetReviseAttackMagic(int index)
    {
        return index >= 0 && index < 13 ? (ushort)(_reviseAtmgcHPMP[index].Value & 1023U) : (ushort)0;
    }

    public void SetReviseAttackMagic(int index, ushort value)
    {
        if (index < 0 || index >= 13)
            return;
        _reviseAtmgcHPMP[index].Value = (_reviseAtmgcHPMP[index].Value & 4294966272U) | value;
    }

    public ushort GetReviseMaxHP(int index)
    {
        return index >= 0 && index < 13 ? (ushort)((_reviseAtmgcHPMP[index].Value & 1047552U) >> 10) : (ushort)0;
    }

    public void SetReviseMaxHP(int index, ushort value)
    {
        if (index < 0 || index >= 13)
            return;
        _reviseAtmgcHPMP[index].Value = (uint)(((int)_reviseAtmgcHPMP[index].Value & -1047553) | (value << 10));
    }

    public ushort GetReviseMaxMP(int index)
    {
        return index >= 0 && index < 13 ? (ushort)((_reviseAtmgcHPMP[index].Value & 1072693248U) >> 20) : (ushort)0;
    }

    public void SetReviseMaxMP(int index, ushort value)
    {
        if (index < 0 || index >= 13)
            return;
        _reviseAtmgcHPMP[index].Value = (uint)(((int)_reviseAtmgcHPMP[index].Value & -1072693249) | (value << 20));
    }

    public byte[] GetBytesData()
    {
        var destinationArray = new byte[572];
        Array.Copy(SaveDataManager.Instance.SaveData.Data, (uint)(136 + 572 * (int)Index), destinationArray, 0L, 572L);
        return destinationArray;
    }

    public void Copy(byte[] srcData)
    {
        srcData.CopyTo(SaveDataManager.Instance.SaveData.Data, (uint)(136 + 572 * (int)Index));
    }

    public void Clear()
    {
        SaveDataManager.Instance.UndoRedoMgr.Edited(new UndoRedoCharacterDataClear(Index));
        Array.Clear(SaveDataManager.Instance.SaveData.Data, 136 + 572 * (int)Index, 572);
    }

    public void InitNewChara()
    {
        var data = SaveDataManager.Instance.SaveData.Data;
        var num = (uint)(136 + 572 * (int)Index);
        data[(int)(num + 1U)] = 12;
        data[(int)(num + 80U)] = 1;
        data[(int)(num + 84U)] = 2;
        for (var index = 7; index < 46; ++index)
            data[(int)(num + 91U + (index - 7) * 4)] =
                index % 4 != 0 ? (byte)192 : index % 8 != 0 ? (byte)128 : (byte)0;
        for (var index = 0; index < 13; ++index)
            data[num + 2U + index] = 1;
        data[(int)(num + 319U)] = 40;
        var sourceArray = new byte[48]
        {
            18,
            16,
            32,
            1,
            5,
            16,
            0,
            0,
            0,
            104,
            64,
            0,
            26,
            16,
            144,
            1,
            22,
            72,
            0,
            2,
            205,
            50,
            85,
            63,
            60,
            35,
            40,
            35,
            byte.MaxValue,
            byte.MaxValue,
            254,
            67,
            byte.MaxValue,
            byte.MaxValue,
            36,
            78,
            byte.MaxValue,
            byte.MaxValue,
            byte.MaxValue,
            byte.MaxValue,
            6,
            240,
            181,
            54,
            10,
            15,
            174,
            15
        };
        Array.Copy(sourceArray, 0L, data, num + 332U, sourceArray.Length);
        for (var index = 0; index < 192; ++index)
            data[num + index + 380L] = byte.MaxValue;
    }
}