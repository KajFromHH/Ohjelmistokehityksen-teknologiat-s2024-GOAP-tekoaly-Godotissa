using Godot;
using System.Collections.Generic;
using System;

// Tänmä koodi on toteutettu seuramalla git-amendin opasvideota
// "Better AI in Unity - GOAP (Goal Oriented Action Planning)"
// Lähde: https://www.youtube.com/watch?v=T_sBYgP7_2k


// Beliefs, eli uskomukset, ovat fundamentaliset tekijät GOAP-mallissa.
// git-amendin mukaan tämä Belief.cs -skripti on lähinnä debuggaukseen.
public partial class AgentBeliefs : Node
{
	public string Name { get; }

	//Määritetään kaikki uskomukset tilanteet tällä vaiheessa pois päältä (false).
	Func<bool> condition = () => false;

	//Monet uskomukset perustuvat vahvasti pelin ympäristöstä ja
	//paikasta. Tämä on tarpeellista Simon-hahmolle löytää ruokaa. 

	//Koska  käytin projektissani kahden ulottuvuuta
	//ruudukko -kentää, niin hyödynnän Vector2I kun se soveltuu 2D Grid-alustaan.

	//Peli alussa, paikkahavanointi on oletuksena nolla.
	Func<Vector2I> observedLocation = () => Vector2I.Zero;

	//Tehdään julkisesti tämä paikkahavanointi.
	//Olennainen määritelmä, kun Simon täytyy uudelleenarvioida ympäristöään.
	public Vector2I Location => observedLocation();

	AgentBeliefs(string name)
	{
		Name = name;
	}

	public bool Evaluate()
	{
		return condition();
	}
}
