﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.GameData.ProfileAddressList
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DQ9_Cheat.GameData
{
  public static class ProfileAddressList
  {
    private static List<ProfileAddress> _dqAreaList = new List<ProfileAddress>();
    private static List<ProfileAddress> _prefectureList = new List<ProfileAddress>();
    private static List<ProfileAddress> _otherAreaList = new List<ProfileAddress>();
    private static List<ProfileAddress> _unknownAreaList = new List<ProfileAddress>();

    static ProfileAddressList()
    {
      string[] strArray1 = new string[18]
      {
        "Angel Falls",
        "Zere",
        "Stornway",
        "Coffinwell",
        "Alltrades Abbey",
        "Porth Llaffan",
        "Slurry Quay",
        "Dourbridge",
        "Zere Rocks",
        "Bloomingdale",
        "Gleeba",
        "Batsureg",
        "Swinedimples Academy",
        "Wormwood Creek",
        "Upover",
        "The Magmaroo",
        "The Gortress",
        "Gittingham Palace"
      };
      for (int index = 0; index < strArray1.Length; ++index)
        _dqAreaList.Add(new ProfileAddress(strArray1[index], index));
      string[] strArray2 = new string[47]
      {
        "AFG",
        "あおもり",
        "いわて",
        "みやぎ",
        "あきた",
        "やまがた",
        "ふくしま",
        "いばらき",
        "とちぎ",
        "ぐんま",
        "さいたま",
        "ちば",
        "とうきょう",
        "かながわ",
        "にいがた",
        "とやま",
        "いしかわ",
        "ふくい",
        "やまなし",
        "ながの",
        "ぎふ",
        "しずおか",
        "あいち",
        "みえ",
        "しが",
        "きょうと",
        "おおさか",
        "ひょうご",
        "なら",
        "わかやま",
        "とっとり",
        "しまね",
        "おかやま",
        "ひろしま",
        "やまぐち",
        "とくしま",
        "かがわ",
        "えひめ",
        "こうち",
        "ふくおか",
        "さが",
        "ながさき",
        "くまもと",
        "おおいた",
        "みやざき",
        "かごしま",
        "おきなわ"
      };
      string str = "AFGAGOALBANDAREARGARMATGAUSAUTAZEBDIBELBENBFABGDBGRBHRBHSBIHBLRBLZBOLBRABRBBRNBTNBWACAFCAMCANCHECHLCHNCIVCMRCODCOGCOLCOMCPVCUBCYPCZEDEUDJIDMADNKDOMDZAECUEGYERIESPESTETHFINFJIFRAFSMGABGBRGEOGHAGHBGINGMBGNQGRCGRDGTMGUYHITHNDHRYHUNINAINDIRLIRNIRQISLISRITAJAMJORJPNKAZKENKGZKIRKNAKORKWTLAOLBNLBRLBYLCALIELKALSOLTULUXLVAMARMCOMDAMDGMDVMEXMHLMKDMLIMLTMMRMNEMNGMOZMTNMUSMWIMYSNAMNERNGANICNLDNORNPLNRUNZLOMNORIPAKPANPERPHLPLWPNGPOLPRKPRTPRYQATROURUSRWASAUSDNSENSGPSLBSLESLVSMRSOMSRBSTPSURSVKSVNSWESWZSYCSYRTCDTHATJKTKMTLSTOGTONTTOTUNTURTUVTZAUGAUKRURYUSAUZBVCTVENVNMVUTWSMYEMZAFZMBZWE";
      for (int index = 0; index < 144; ++index)
        _prefectureList.Add(new ProfileAddress(str.Substring(index * 3, 3), index + 310));
      string[] strArray3 = new string[8]
      {
        "Asia",
        "Europe",
        "Africa",
        "North America",
        "Central America",
        "South America",
        "Australasia",
        "Antartica"
      };
      for (int index = 0; index < strArray3.Length; ++index)
        _otherAreaList.Add(new ProfileAddress(strArray3[index], index + 200));
      _unknownAreaList.Add(new ProfileAddress("Unknown", 300));
    }

    public static ReadOnlyCollection<ProfileAddress> DQAreaList
    {
      get => _dqAreaList.AsReadOnly();
    }

    public static ReadOnlyCollection<ProfileAddress> PrefectureList
    {
      get => _prefectureList.AsReadOnly();
    }

    public static ReadOnlyCollection<ProfileAddress> OtherAreaList
    {
      get => _otherAreaList.AsReadOnly();
    }

    public static ReadOnlyCollection<ProfileAddress> UnknownAreaList
    {
      get => _unknownAreaList.AsReadOnly();
    }

    public static ProfileAddress GetAddressFromIndex(ushort index)
    {
      foreach (ProfileAddress dqArea in _dqAreaList)
      {
        if (dqArea.Index == index)
          return dqArea;
      }
      foreach (ProfileAddress prefecture in _prefectureList)
      {
        if (prefecture.Index == index)
          return prefecture;
      }
      foreach (ProfileAddress otherArea in _otherAreaList)
      {
        if (otherArea.Index == index)
          return otherArea;
      }
      return _unknownAreaList[0];
    }
  }
}
