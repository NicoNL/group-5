using Godot;
using System;

public partial class GameScene : Control
{
	public override void _Ready()
	{
		var pauseButton = GetNode<Button>("%PauseButton");
		var buyButton = GetNode<Button>("%BuyButton");
		var resumeButton = GetNode<Button>("%ResumeButton");
		var goToMenuButton = GetNode<Button>("%GoToMenuButton");

		if (pauseButton != null || resumeButton != null)
			pauseButton.Pressed += PauseResumeGame;
		else
			GD.PrintErr("Pause button not found!");
			
		if(goToMenuButton != null)
			goToMenuButton.Pressed += GoToMenu;
		else
			GD.PrintErr("Menu Button not found!");
		
		if (buyButton != null)
			buyButton.Pressed += BuyItem;
		else
			GD.PrintErr("Buy button not found!");

		//StartMovingObjects();
	}

	private void GoToMenu(){
		GD.Print("Went to Menu");
		GetTree().ChangeSceneToFile("res://scenes/main_menu.tscn");
	}

	private void PauseResumeGame()
	{
		GD.Print("Game Paused");
		//GetTree().Paused = !GetTree().Paused; // Toggle pause state
	}


	private void BuyItem()
	{
		GD.Print("Buying item...");
		// Implement game-specific buy logic here
	}


}
