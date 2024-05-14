﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.DataManager.BasisData
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

using DQ9_Cheat.Controls;
using DQ9_Cheat.GameData;

namespace DQ9_Cheat.DataManager
{
  internal class BasisData
  {
    private DataValue<byte> _afterEnding;
    private DataValue<ushort> _savePlace;
    private DataValue<byte> _profileExplanation;
    private DataValue<byte> _profileSetting_Sex;
    private DataValue<ushort> _profileTone;
    private DataValue<ushort> _profileBirthYearMonth;
    private DataValue<byte> _profileBirthDay;
    private DataValue<byte> _profileSecretAge;
    private DataValue<ushort> _handle;
    private DataValue<ushort> _address;
    private DataValueString _profileMessage;
    private DataValue<ushort> _playTimeHour;
    private DataValue<byte> _playTimeMinute;
    private DataValue<byte> _playTimeSecond;
    private DataValue<ushort> _multiPlayTimeHour;
    private DataValue<byte> _multiPlayTimeMinute;
    private DataValue<byte> _multiPlayTimeSecond;
    private DataValue<uint> _money;
    private DataValue<uint> _bankMoney;
    private DataValue<uint> _medal;
    private DataValue<uint> _battleCount;
    private DataValue<uint> _loseCount;
    private DataValue<uint> _escapeCount;
    private DataValue<uint> _escapeSuccessCount;
    private DataValue<uint> _victoryCount;
    private DataValue<int> _alchemyCount;
    private DataValue<byte> _gestureLearn1;
    private DataValue<byte> _gestureLearn2;
    private DataValue<byte> _gestureLearn3;
    private DataValue<byte> _gestureUp;
    private DataValue<byte> _gestureLeft;
    private DataValue<byte> _gestureRight;
    private DataValue<byte> _gestureDown1;
    private DataValue<byte> _gestureDown2;
    private DataValue<byte> _gestureDown3;
    private DataValue<byte> _gestureDown4;
    private DataValue<ushort> _intermissionPlace;
    private DataValue<int> _intermissionX;
    private DataValue<int> _intermissionY;
    private DataValue<int> _intermissionZ;

    public BasisData(SaveData owner)
    {
      BasisDataControl basisDataControl = MainWindow.Instance.BasisDataControl;
      basisDataControl.BeginUpdate();
      _intermissionPlace = new DataValue<ushort>(owner, 27104U, null, 0, ushort.MaxValue);
      _intermissionX = new DataValue<int>(owner, 27108U, null, int.MinValue, int.MaxValue);
      _intermissionY = new DataValue<int>(owner, 27112U, null, int.MinValue, int.MaxValue);
      _intermissionZ = new DataValue<int>(owner, 27116U, null, int.MinValue, int.MaxValue);
      _afterEnding = new DataValue<byte>(owner, 12276U, null, 0, byte.MaxValue);
      _savePlace = new DataValue<ushort>(owner, 11476U, null, 0, ushort.MaxValue);
      _profileExplanation = new DataValue<byte>(owner, 26987U, null, 0, byte.MaxValue);
      _profileSetting_Sex = new DataValue<byte>(owner, 26983U, null, 0, byte.MaxValue);
      _profileTone = new DataValue<ushort>(owner, 26982U, null, 0, ushort.MaxValue);
      _profileBirthYearMonth = new DataValue<ushort>(owner, 26980U, null, 0, ushort.MaxValue);
      basisDataControl.NumericUpDown_ProfileBirthYear.Maximum = 4096M;
      basisDataControl.NumericUpDown_ProfileBirthYear.Minimum = 0M;
      basisDataControl.NumericUpDown_ProfileBirthMonth.Maximum = 12M;
      basisDataControl.NumericUpDown_ProfileBirthMonth.Minimum = 1M;
      _profileBirthDay = new DataValue<byte>(owner, 26982U, null, 0, byte.MaxValue);
      basisDataControl.NumericUpDown_ProfileBirthDay.Maximum = 31M;
      basisDataControl.NumericUpDown_ProfileBirthDay.Minimum = 1M;
      _address = new DataValue<ushort>(owner, 26985U, null, 0, ushort.MaxValue);
      _handle = new DataValue<ushort>(owner, 26986U, null, 0, ushort.MaxValue);
      byte[] fillData = new byte[2]{ 129, 69 };
      _profileMessage = new DataValueString(owner, 26988U, null, 114, false, fillData);
      _profileSecretAge = new DataValue<byte>(owner, 26983U, basisDataControl.CheckBox_SecretAge, 0, byte.MaxValue);
      _playTimeHour = new DataValue<ushort>(owner, 16024U, null, 0, ushort.MaxValue);
      basisDataControl.NumericUpDown_Hour.Maximum = _playTimeHour.Max;
      basisDataControl.NumericUpDown_Hour.Minimum = _playTimeHour.Min;
      _playTimeMinute = new DataValue<byte>(owner, 16026U, null, 0, 59);
      basisDataControl.NumericUpDown_Minute.Maximum = _playTimeMinute.Max;
      basisDataControl.NumericUpDown_Minute.Minimum = _playTimeMinute.Min;
      _playTimeSecond = new DataValue<byte>(owner, 16027U, null, 0, 59);
      basisDataControl.NumericUpDown_Second.Maximum = _playTimeSecond.Max;
      basisDataControl.NumericUpDown_Second.Minimum = _playTimeSecond.Min;
      _multiPlayTimeHour = new DataValue<ushort>(owner, 16028U, null, 0, ushort.MaxValue);
      basisDataControl.NumericUpDown_MultiPlayTimeHour.Maximum = _multiPlayTimeHour.Max;
      basisDataControl.NumericUpDown_MultiPlayTimeHour.Minimum = _multiPlayTimeHour.Min;
      _multiPlayTimeMinute = new DataValue<byte>(owner, 16030U, null, 0, 59);
      basisDataControl.NumericUpDown_MultiPlayTimeMinute.Maximum = _multiPlayTimeMinute.Max;
      basisDataControl.NumericUpDown_MultiPlayTimeMinute.Minimum = _multiPlayTimeMinute.Min;
      _multiPlayTimeSecond = new DataValue<byte>(owner, 16031U, null, 0, 59);
      basisDataControl.NumericUpDown_MultiPlayTimeSecond.Maximum = _multiPlayTimeSecond.Max;
      basisDataControl.NumericUpDown_MultiPlayTimeSecond.Minimum = _multiPlayTimeSecond.Min;
      _money = new DataValue<uint>(owner, 11448U, null, 0U, 9999999U);
      basisDataControl.NumericUpDown_Money.Maximum = _money.Max;
      basisDataControl.NumericUpDown_Money.Minimum = _money.Min;
      _bankMoney = new DataValue<uint>(owner, 11452U, null, 0U, 1000000000U);
      basisDataControl.NumericUpDown_BankMoney.Maximum = _bankMoney.Max;
      basisDataControl.NumericUpDown_BankMoney.Minimum = _bankMoney.Min;
      _medal = new DataValue<uint>(owner, 11460U, null, 0U, 500U);
      basisDataControl.NumericUpDown_Medal.Maximum = _medal.Max;
      basisDataControl.NumericUpDown_Medal.Minimum = _medal.Min;
      _battleCount = new DataValue<uint>(owner, 16084U, null, 0U, uint.MaxValue);
      basisDataControl.NumericUpDown_BattleCount.Minimum = _battleCount.Min;
      basisDataControl.NumericUpDown_BattleCount.Maximum = 16777215M;
      _loseCount = new DataValue<uint>(owner, 16088U, null, 0U, uint.MaxValue);
      basisDataControl.NumericUpDown_LoseCount.Minimum = _loseCount.Min;
      basisDataControl.NumericUpDown_LoseCount.Maximum = 16777215M;
      _escapeCount = new DataValue<uint>(owner, 16076U, null, 0U, uint.MaxValue);
      basisDataControl.NumericUpDown_EscapeCount.Minimum = _escapeCount.Min;
      basisDataControl.NumericUpDown_EscapeCount.Maximum = 16777215M;
      _escapeSuccessCount = new DataValue<uint>(owner, 16080U, null, 0U, uint.MaxValue);
      basisDataControl.NumericUpDown_EscapeSuccessCount.Minimum = _escapeSuccessCount.Min;
      basisDataControl.NumericUpDown_EscapeSuccessCount.Maximum = 16777215M;
      _victoryCount = new DataValue<uint>(owner, 16032U, null, 0U, uint.MaxValue);
      basisDataControl.NumericUpDown_VictoryCount.Minimum = 0M;
      basisDataControl.NumericUpDown_VictoryCount.Maximum = 16777215M;
      _alchemyCount = new DataValue<int>(owner, 15016U, null, 0, int.MaxValue);
      basisDataControl.NumericUpDown_AlchemyCount.Minimum = _alchemyCount.Min;
      basisDataControl.NumericUpDown_AlchemyCount.Maximum = _alchemyCount.Max;
      _gestureLearn1 = new DataValue<byte>(owner, 12108U, null, 0, byte.MaxValue);
      _gestureLearn2 = new DataValue<byte>(owner, 12109U, null, 0, byte.MaxValue);
      _gestureLearn3 = new DataValue<byte>(owner, 12110U, null, 0, byte.MaxValue);
      _gestureUp = new DataValue<byte>(owner, 11468U, null, 0, byte.MaxValue);
      _gestureLeft = new DataValue<byte>(owner, 11469U, null, 0, byte.MaxValue);
      _gestureRight = new DataValue<byte>(owner, 11470U, null, 0, byte.MaxValue);
      _gestureDown1 = new DataValue<byte>(owner, 11471U, null, 0, byte.MaxValue);
      _gestureDown2 = new DataValue<byte>(owner, 11472U, null, 0, byte.MaxValue);
      _gestureDown3 = new DataValue<byte>(owner, 11473U, null, 0, byte.MaxValue);
      _gestureDown4 = new DataValue<byte>(owner, 11474U, null, 0, byte.MaxValue);
      basisDataControl.EndUpdate();
    }

    public SavePlace SavePlace
    {
      get
      {
        return (_afterEnding.Value & 4) == 0 ? SavePlaceList.GetSavePlace(_savePlace.Value) : SavePlaceList.GetSavePlace(ushort.MaxValue);
      }
      set
      {
        if (value.Index == ushort.MaxValue)
        {
          _afterEnding.Value = (byte) (_afterEnding.Value & 251 | 4);
          _savePlace.Value = 109;
        }
        else
        {
          _afterEnding.Value &= 251;
          _savePlace.Value = value.Index;
        }
      }
    }

    public bool ProfileExplanation
    {
      get => (_profileExplanation.Value & 64) != 0;
      set
      {
        _profileExplanation.Value = (byte) (_profileExplanation.Value & 191 | (value ? 64 : 0));
      }
    }

    public byte ProfileSex
    {
      get => (byte) ((_profileSetting_Sex.Value & 2) >> 1);
      set
      {
        _profileSetting_Sex.Value = (byte) (_profileSetting_Sex.Value & 253 | (value != 0 ? 2 : 0));
      }
    }

    public bool ProfileSetting
    {
      get => (_profileSetting_Sex.Value & 4) != 0;
      set
      {
        _profileSetting_Sex.Value = (byte) (_profileSetting_Sex.Value & 251 | (value ? 4 : 0));
      }
    }

    public byte ProfileTone
    {
      get => (byte) ((_profileTone.Value & 480) >> 5);
      set
      {
        _profileTone.Value = (ushort) (_profileTone.Value & 65055 | value << 5 & 480);
      }
    }

    public bool ProfileToneSetting
    {
      get => (_profileTone.Value & 2048) != 0;
      set
      {
        _profileTone.Value = (ushort) (_profileTone.Value & 63487 | (value ? 2048 : 0));
      }
    }

    public ushort ProfileBirthYear
    {
      get => (ushort) (_profileBirthYearMonth.Value & 4095U);
      set
      {
        _profileBirthYearMonth.Value = (ushort) (value & 4095 | ProfileBirthMonth << 12);
      }
    }

    public byte ProfileBirthMonth
    {
      get => (byte) ((uint) _profileBirthYearMonth.Value >> 12);
      set
      {
        _profileBirthYearMonth.Value = (ushort) (ProfileBirthYear & 4095 | value << 12);
      }
    }

    public byte ProfileBirthDay
    {
      get => (byte) (_profileBirthDay.Value & 31U);
      set
      {
        _profileBirthDay.Value = (byte) (_profileBirthDay.Value & 224 | value & 31);
      }
    }

    public bool ProfileSecretAge
    {
      get => (_profileSecretAge.Value & 128) == 0;
      set
      {
        _profileSecretAge.Value = (byte) ((byte) (_profileSecretAge.Value & (uint) sbyte.MaxValue) | (value ? 0 : 128));
      }
    }

    public Handle Handle
    {
      get
      {
        ushort num = (ushort) ((_handle.Value & 16376) >> 3);
        ProfileJob jobFromIndex = ProfileJobList.GetJobFromIndex(num);
        if (jobFromIndex != null)
          return new Handle(jobFromIndex);
        TitleElement titleElement = TitleDataList.GetTitleElement(num);
        return titleElement != null ? new Handle(titleElement) : null;
      }
      set
      {
        if (value == null)
          return;
        ushort num;
        if (value.HandleType == HandleType.HandleJob && value.Job != null)
        {
          num = (ushort) (value.Job.Index << 3 & 16376);
        }
        else
        {
          if (value.HandleType != HandleType.HandleTitle || value.Title == null)
            return;
          num = (ushort) (value.Title.DataIndex << 3 & 16376);
        }
        _handle.Value = (ushort) (_handle.Value & 49159U | num);
      }
    }

    public ProfileAddress Address
    {
      get
      {
        return ProfileAddressList.GetAddressFromIndex((ushort) ((_address.Value & 2046) >> 1));
      }
      set
      {
        _address.Value = (ushort) (_address.Value & 63489 | value.Index << 1 & 2046);
      }
    }

    public DataValueString ProfileMessage => _profileMessage;

    public DataValue<ushort> PlayTimeHour => _playTimeHour;

    public DataValue<byte> PlayTimeMinute => _playTimeMinute;

    public DataValue<byte> PlayTimeSecond => _playTimeSecond;

    public DataValue<ushort> MultiPlayTimeHour => _multiPlayTimeHour;

    public DataValue<byte> MultiPlayTimeMinute => _multiPlayTimeMinute;

    public DataValue<byte> MultiPlayTimeSecond => _multiPlayTimeSecond;

    public DataValue<uint> Money => _money;

    public DataValue<uint> BankMoney => _bankMoney;

    public DataValue<uint> Medal => _medal;

    public uint BattleCount
    {
      get => _battleCount.Value & 16777215U;
      set
      {
        _battleCount.Value = (uint) ((int) _battleCount.Value & -16777216 | (int) value & 16777215);
      }
    }

    public uint LoseCount
    {
      get => _loseCount.Value & 16777215U;
      set
      {
        _loseCount.Value = (uint) ((int) _loseCount.Value & -16777216 | (int) value & 16777215);
      }
    }

    public uint EscapeCount
    {
      get => _escapeCount.Value & 16777215U;
      set
      {
        _escapeCount.Value = (uint) ((int) _escapeCount.Value & -16777216 | (int) value & 16777215);
      }
    }

    public uint EscapeSuccessCount
    {
      get => _escapeSuccessCount.Value & 16777215U;
      set
      {
        _escapeSuccessCount.Value = (uint) ((int) _escapeSuccessCount.Value & -16777216 | (int) value & 16777215);
      }
    }

    public uint VictoryCount
    {
      get => _victoryCount.Value & 16777215U;
      set
      {
        _victoryCount.Value = (uint) ((int) _victoryCount.Value & -16777216 | (int) value & 16777215);
      }
    }

    public DataValue<int> AlchemyCount => _alchemyCount;

    public bool IsGestureLearn(int index)
    {
      if (index < 6)
        return (_gestureLearn1.Value & 1 << index + 2) != 0;
      return index < 14 ? (_gestureLearn2.Value & 1 << index - 6) != 0 : (_gestureLearn3.Value & 1) != 0;
    }

    public void SetGestureLearn(int index, bool value)
    {
      if (index < 6)
        _gestureLearn1.Value = (byte) (_gestureLearn1.Value & ~(1 << index + 2) | (value ? 1 << index + 2 : 0));
      else if (index < 14)
        _gestureLearn2.Value = (byte) (_gestureLearn2.Value & ~(1 << index - 6) | (value ? 1 << index - 6 : 0));
      else
        _gestureLearn3.Value = (byte) (_gestureLearn3.Value & 254 | (value ? 1 : 0));
    }

    public byte GestureUp
    {
      get => _gestureUp.Value != byte.MaxValue ? _gestureUp.Value : (byte) 0;
      set => _gestureUp.Value = value >= GestureList.List.Count ? byte.MaxValue : value;
    }

    public byte GestureLeft
    {
      get => _gestureLeft.Value != byte.MaxValue ? _gestureLeft.Value : (byte) 0;
      set
      {
        _gestureLeft.Value = value >= GestureList.List.Count ? byte.MaxValue : value;
      }
    }

    public byte GestureRight
    {
      get => _gestureRight.Value != byte.MaxValue ? _gestureRight.Value : (byte) 0;
      set
      {
        _gestureRight.Value = value >= GestureList.List.Count ? byte.MaxValue : value;
      }
    }

    public byte GestureDown1
    {
      get => _gestureDown1.Value != byte.MaxValue ? _gestureDown1.Value : (byte) 0;
      set
      {
        _gestureDown1.Value = value >= GestureList.List.Count ? byte.MaxValue : value;
      }
    }

    public byte GestureDown2
    {
      get => _gestureDown2.Value != byte.MaxValue ? _gestureDown2.Value : (byte) 0;
      set
      {
        _gestureDown2.Value = value >= GestureList.List.Count ? byte.MaxValue : value;
      }
    }

    public byte GestureDown3
    {
      get => _gestureDown3.Value != byte.MaxValue ? _gestureDown3.Value : (byte) 0;
      set
      {
        _gestureDown3.Value = value >= GestureList.List.Count ? byte.MaxValue : value;
      }
    }

    public byte GestureDown4
    {
      get => _gestureDown4.Value != byte.MaxValue ? _gestureDown4.Value : (byte) 0;
      set
      {
        _gestureDown4.Value = value >= GestureList.List.Count ? byte.MaxValue : value;
      }
    }

    public SavePlace IntermissionPlace
    {
      get => SavePlaceList.GetSavePlace(_intermissionPlace.Value);
      set
      {
        if (value.Index == ushort.MaxValue)
          _intermissionPlace.Value = 100;
        else
          _intermissionPlace.Value = value.Index;
      }
    }

    public DataValue<int> IntermissionX => _intermissionX;

    public DataValue<int> IntermissionY => _intermissionY;

    public DataValue<int> IntermissionZ => _intermissionZ;
  }
}
