using Godot;
using System;

public partial class NewScript: Node
{
	public static int number = 1;
	public static int lower = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{		
		GD.Print("Hello world!");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		if(number > 1000) {
			return;
		}
		int result = number + lower;
		GD.Print(number);

		lower = number;
		number = result;
	}
}

