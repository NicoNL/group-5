using Godot;
using System;

public partial class MainMenu : Control
{
public override void _Ready()
	{
		var startButton = GetNode<Button>("%StartGame");
		var quitButton = GetNode<Button>("%Exit");

		// Null checks help avoid crashes if nodes aren't found
		if (startButton != null)
			startButton.Pressed += StartGame;
		else
			GD.PrintErr("Start button not found!");

		if (quitButton != null)
			quitButton.Pressed += QuitGame;
		else
			GD.PrintErr("Quit button not found!");
	}

	private void StartGame()
	{
		GD.Print("Starting game...");
		GetTree().ChangeSceneToFile("res://scenes/GameScene.tscn");
	}

	private void QuitGame()
	{
		GD.Print("Quitting game...");
		GetTree().Quit();
	}
}
