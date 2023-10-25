using System;
using Godot;

public partial class Brain : Node2D
{
	private int[][] _networkWeights;
	private int[] _layerSizes;
	private const int BiasOffset = 1;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Random rand = new Random();
		for (int layer = 0; layer < _networkWeights.Length; layer++)
		{
			for (int weight = 0; weight < _networkWeights[layer].Length + BiasOffset; weight++)
			{
				weight = rand.Next();
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
