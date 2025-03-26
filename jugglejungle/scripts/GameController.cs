using Godot;

public partial class GameController : Node
{
	[Export] public PackedScene entityScene;  // Assign a scene with a Sprite2D root
	private bool isDragging = false;
	private Texture2D draggedTexture;
	
	public override void _Process(double delta)
	{
		if (isDragging && draggedTexture != null)
		{
			Vector2 mousePosition = GetViewport().GetMousePosition();
			UpdatePreview(mousePosition);
		}
	}

	public void StartDragging(Texture2D texture)
	{
		if (texture == null) return;
		isDragging = true;
		draggedTexture = texture;
	}

	public void StopDragging()
	{
		if (!isDragging || draggedTexture == null) return;
		isDragging = false;

		// Place at final mouse position
		Vector2 dropPosition = GetViewport().GetMousePosition();
		PlaceEntity(dropPosition, draggedTexture);
		
		draggedTexture = null;
	}

	public void PlaceEntity(Vector2 position, Texture2D texture)
	{
		if (entityScene == null)
		{
			GD.PrintErr("No entity scene assigned!");
			return;
		}

		Node2D entity = entityScene.Instantiate<Node2D>();
		GetNode<Node2D>("/root/GameScene/EntitiesLayer").AddChild(entity);
		entity.Position = position;

		// Assign texture to new entity
		Sprite2D sprite = entity.GetNodeOrNull<Sprite2D>("Sprite2D");
		if (sprite != null)
		{
			sprite.Texture = texture;
		}
		else
		{
			GD.PrintErr("Entity does not have a Sprite2D node!");
		}
	}

	private void UpdatePreview(Vector2 position)
	{
		// Visual feedback while dragging (optional)
		if (draggedTexture != null)
		{
			GetNode<Sprite2D>("res://GameScene/PreviewSprite").Position = position;
		}
	}
}
