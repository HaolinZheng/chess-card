using Godot;
using System;
using System.Data;
using System.Threading.Tasks;

public partial class CardUI : Control
{
    [Signal] public delegate void ReparentRequestEventHandler(CardUI whichCardUi);
    public ColorRect color => GetNode<ColorRect>("Borde");
    public Label state => GetNode<Label>("State");
    public Area2D DropPointDetector => GetNode<Area2D>("DropPointDetector");
    public CardStateMachine stateMachine => GetNode<CardStateMachine>("CardStateMachine");
    public override void _Ready()
    {
        stateMachine.Init(this);
    }
    public override void _Input(InputEvent @event)
    {
        stateMachine.OnInput(@event);
    }
    public override void _GuiInput(InputEvent @event)
    {
        stateMachine.OnGuiInput(@event);
    }
    public void _MouseEntered()
    {
        stateMachine.OnMouseEntered();
    }
    public void _MouseExited()
    {
        stateMachine.OnMouseExited();
    }
}
