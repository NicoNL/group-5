using Godot;
using System;

public partial class GameScene : Control
{
	public override void _Ready()
	{
		var pauseButton = GetNode<Button>("%PauseButton");
		var buyButton = GetNode<Button>("%BuyButton");

		if (pauseButton != null)
			pauseButton.Pressed += PauseGame;
		else
			GD.PrintErr("Pause button not found!");

		if (buyButton != null)
			buyButton.Pressed += BuyItem;
		else
			GD.PrintErr("Buy button not found!");

		//StartMovingObjects();
	}

	private void PauseGame()
	{
		GD.Print("Game Paused");
		GetTree().Paused = !GetTree().Paused; // Toggle pause state
	}

	private void BuyItem()
	{
		GD.Print("Buying item...");
		// Implement game-specific buy logic here
	}


}
