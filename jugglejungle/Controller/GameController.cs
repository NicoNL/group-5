using Godot;
using System;

public partial class GameController : Control
{
	public void StartGame(){
		GetTree().ChangeSceneToFile("res://game.tscn");
	}
	
	public void QuitGame(){
		GetTree().Quit();
	}
	
	public void PauseGame(){
		
	}
	
}
