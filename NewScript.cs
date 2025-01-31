using Godot;
using System;
using System.Numerics;

public partial class Newscript : Node2D
{
	//public static int number = 1;
	//public static int lower = 0;
	private float speed = 100f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{		
		GD.Print("Liikutaan");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) //kahden framen aikana kulunu aika
	{
		//liikkuu yhden pikselin alaspäin per frame (Y akselilla)
		//GlobalPosition += Vector2.Down;
		//käytetään delta muuttujaa - kauanko on kulunut aikaa viime framesta/sek
		// muuntaa deltan - float'iksi
		Godot.Vector2 movement = Godot.Vector2.Down * speed * (float)delta;

		GlobalPosition += movement;

	}
}

