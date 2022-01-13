using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPattern {
    public virtual void ExecuteAction() {

    }

    public virtual void UndoAction() {

    }

    public virtual void RedoAction() {
    }
}

public class MoveUnitCommand : CommandPattern {
    public int x, y;
    public int undoX, undoY;
    public CommandUnit unit = null;

    public MoveUnitCommand(CommandUnit _unit, int _x, int _y) {
        x = _x; y = _y;
        unit = _unit;
    }

    public override void ExecuteAction() {
        undoX = unit.posX;
        undoY = unit.posY;
        unit.MoveTo(x, y);

    }

    public override void UndoAction() {
        unit.posX = undoX;
        unit.posY = undoY;
        unit.MoveTo(undoX, undoY);

    } public override void RedoAction() {
        unit.MoveTo(x, y);

    }

}

public class ScaleUnitCommand : CommandPattern {
    public float x, y;
    public float undoX, undoY;
    public CommandUnit unit = null;

    public ScaleUnitCommand(CommandUnit _unit, float _x, float _y) {
        x = _x; y = _y;
        unit = _unit;

    }

    public override void ExecuteAction() {
        undoX = unit.scaleX;
        undoY = unit.scaleY;
        unit.ScaleTo(x, y);

    }

    public override void UndoAction() {
        unit.scaleX = undoX;
        unit.scaleY = undoY;
        unit.ScaleTo(undoX, undoY);

    } public override void RedoAction() {
        unit.ScaleTo(x, y);
    }

}