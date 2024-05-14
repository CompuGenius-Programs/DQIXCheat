﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.GameData.DevilList
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: C:\Users\yzsco\Downloads\dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

using System.Collections.ObjectModel;

#nullable disable
namespace DQ9_Cheat.GameData
{
  public static class DevilList
  {
    private static System.Collections.Generic.List<Devil> _list = new System.Collections.Generic.List<Devil>();

    static DevilList()
    {
      string[] strArray = new string[13]
      {
        "Baramos",
        "Murdaw",
        "Dhoulmagus",
        "Dragonlord",
        "Psaro",
        "Nimzo",
        "Malroth",
        "Estark",
        "Mortamor",
        "Zoma",
        "Orgodemir",
        "Rhapthorne",
        "Nokturnus"
      };
      int[] numArray = new int[13]
      {
        3,
        8,
        12,
        1,
        5,
        7,
        2,
        6,
        9,
        4,
        11,
        13,
        10
      };
      for (int index = 0; index < strArray.Length; ++index)
        DevilList._list.Add(new Devil(strArray[index], numArray[index]));
    }

    public static ReadOnlyCollection<Devil> List => DevilList._list.AsReadOnly();

    public static Devil GetDevilFromIndex(int index)
    {
      if (index > 0 && index <= DevilList._list.Count)
      {
        foreach (Devil devilFromIndex in DevilList._list)
        {
          if (devilFromIndex.Index == index)
            return devilFromIndex;
        }
      }
      return (Devil) null;
    }
  }
}