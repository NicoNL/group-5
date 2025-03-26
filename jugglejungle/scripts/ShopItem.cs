using Godot;
using System;

public partial class ShopItem : TextureRect
{
	private TextureRect previewInstance; // Duplicate for dragging
	private bool isDragging = false;

	public override void _GuiInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseButton)
		{
			if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
			{
				StartDragging();
			}
			else if (mouseButton.ButtonIndex == MouseButton.Left && !mouseButton.Pressed)
			{
				PlaceDraggedEntity();
			}
		}
		else if (@event is InputEventMouseMotion && isDragging)
		{
			UpdateDraggingPosition();
		}
	}

	private void StartDragging()
	{
		if (previewInstance == null)
		{
			previewInstance = new TextureRect
			{
				Texture = this.Texture, // Copy texture
				ExpandMode = TextureRect.ExpandModeEnum.IgnoreSize,
				Modulate = new Color(1, 1, 1, 0.5f) // Make semi-transparent
			};
			GetTree().Root.AddChild(previewInstance);
		}

		isDragging = true;
	}

	private void UpdateDraggingPosition()
	{
		if (previewInstance != null)
		{
			previewInstance.Position = GetGlobalMousePosition();
		}
	}

	private void PlaceDraggedEntity()
	{
		if (!isDragging || previewInstance == null) return;

		// Find the GameController node
		GameController gameController = GetNode<GameController>("res://GameController");

		if (gameController != null)
		{
			gameController.PlaceEntity(previewInstance.Position, previewInstance.Texture as Texture2D);
		}

		// Cleanup
		previewInstance.QueueFree();
		previewInstance = null;
		isDragging = false;
	}
}
