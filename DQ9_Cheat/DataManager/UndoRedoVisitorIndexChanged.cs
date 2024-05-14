﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.DataManager.UndoRedoVisitorIndexChanged
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: C:\Users\yzsco\Downloads\dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

#nullable disable
namespace DQ9_Cheat.DataManager
{
  internal class UndoRedoVisitorIndexChanged : UndoRedoElement
  {
    private int _srcIndex;
    private int _toIndex;

    public UndoRedoVisitorIndexChanged(int srcIndex, int toIndex)
    {
      this._srcIndex = srcIndex;
      this._toIndex = toIndex;
    }

    public override void Undo()
    {
      this.GetSaveData().RikkaData.VisitorManager.MoveTo(this._toIndex, this._srcIndex);
    }

    public override void Redo()
    {
      this.GetSaveData().RikkaData.VisitorManager.MoveTo(this._srcIndex, this._toIndex);
    }
  }
}
