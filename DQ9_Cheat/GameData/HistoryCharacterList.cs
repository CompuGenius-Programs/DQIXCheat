﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.GameData.HistoryCharacterList
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

using System.Collections.Generic;

namespace DQ9_Cheat.GameData
{
  public static class HistoryCharacterList
  {
    private static List<HistoryCharacter> _list = new List<HistoryCharacter>();

    static HistoryCharacterList()
    {
      string[] strArray = new string[23]
      {
        "Princeton",
        "Princessa",
        "Alena",
        "Kiryl",
        "Borya",
        "Meena",
        "Maya",
        "Torneko",
        "Ragnar",
        "Bianca",
        "Nera",
        "Debora",
        "Milly",
        "Carver",
        "Ashlynn",
        "Kiefer",
        "Maribel",
        "Jessica",
        "Angelo",
        "Yangus",
        "Trode",
        "Morrie",
        "Fleurette"
      };
      int num = 1;
      foreach (string name in strArray)
        _list.Add(new HistoryCharacter(name, num++));
    }

    public static List<HistoryCharacter> List
    {
      get => _list;
    }
  }
}
