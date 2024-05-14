﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.GameData.SavePlaceList
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: C:\Users\yzsco\Downloads\dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

using FriedGinger.DQCheat;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

#nullable disable
namespace DQ9_Cheat.GameData
{
  internal static class SavePlaceList
  {
    private static List<SavePlace> _list = new List<SavePlace>();

    static SavePlaceList() => SavePlaceListFixer.AddSavePlaces(SavePlaceList._list);

    public static ReadOnlyCollection<SavePlace> GetList(SavePlaceType type, string search)
    {
      if (!string.IsNullOrEmpty(search))
      {
        Regex regex = new Regex(search.Trim(), RegexOptions.IgnoreCase);
        List<SavePlace> savePlaceList = new List<SavePlace>();
        foreach (SavePlace savePlace in SavePlaceList._list)
        {
          if ((type == SavePlaceType.All || type == savePlace.Type) && regex.IsMatch(savePlace.Name))
            savePlaceList.Add(savePlace);
        }
        return savePlaceList.AsReadOnly();
      }
      List<SavePlace> savePlaceList1 = new List<SavePlace>();
      foreach (SavePlace savePlace in SavePlaceList._list)
      {
        if (type == SavePlaceType.All || type == savePlace.Type)
          savePlaceList1.Add(savePlace);
      }
      return savePlaceList1.AsReadOnly();
    }

    public static SavePlace GetSavePlace(ushort index)
    {
      foreach (SavePlace savePlace in SavePlaceList._list)
      {
        if ((int) savePlace.Index == (int) index)
          return savePlace;
      }
      return (SavePlace) null;
    }
  }
}
