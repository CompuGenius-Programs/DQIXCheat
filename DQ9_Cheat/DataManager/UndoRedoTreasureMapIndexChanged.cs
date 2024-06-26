﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.DataManager.UndoRedoTreasureMapIndexChanged
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

namespace DQ9_Cheat.DataManager;

internal class UndoRedoTreasureMapIndexChanged : UndoRedoElement
{
    private readonly int _srcIndex;
    private readonly int _toIndex;

    public UndoRedoTreasureMapIndexChanged(int srcIndex, int toIndex)
    {
        _srcIndex = srcIndex;
        _toIndex = toIndex;
    }

    public override void Undo()
    {
        GetSaveData().TreasureMapManager.MoveTo(_toIndex, _srcIndex);
    }

    public override void Redo()
    {
        GetSaveData().TreasureMapManager.MoveTo(_srcIndex, _toIndex);
    }
}