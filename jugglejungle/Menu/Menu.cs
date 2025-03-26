using Godot;
using System;

public partial class Menu : Control
{
	public override void _Ready(){
		GetNode<Button>("%Start").Pressed += _Start;
		GetNode<Button>("%Quit").Pressed += _QuitGame;
	}
	

}
