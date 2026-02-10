using Godot;
using System;

public partial class CardReleaseState : CardState
{
    public override void Enter()
    {
        card_ui.color.Color = Color.FromHsv(270f / 360f, 0.85f, 0.35f);
        card_ui.state.Text = "Released";    }
}
