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

	//Lisätään konstruktoori, joka hyväksyy vain nimen.
	AgentBeliefs(string name)
	{
		Name = name;
	}

	//Uudelleenrvioidaan tilannetta ja ympäristöä,
	//jos nykyinen tapahtuma on totta vai ei.
	public bool Evaluate()
	{
		return condition();
	}

	//Lisätään uskomuksille rakennetta, ts. Builder.

	public class Builder
	{
		readonly AgentBeliefs belief;

		//Hyväksytään uskomuksen nimen
		//ja luodaan uuden version.
		public Builder(string name)
		{
			belief = new AgentBeliefs(name);
		}

		//Lisätään tilanne kyseiselle uskomukselle.
		public Builder WithCondition(Func<bool> condition)
		{
			belief.condition = condition;
			return this;
		}

		//Lisätään uskomuksen paikkakoordinaatit.
		public Builder WithLocation(Func<Vector2I> observedLocation)
		{
			belief.observedLocation = observedLocation;
			return this;
		}

		//Rakennetaan loppultaan kyseisen uskomuksen. 
		public AgentBeliefs Build()
		{
			return belief;

		}
	}
}

//Luodaan uskomuksille tehtaan, jotta
//pystymme hallinoimaan helpommin monia uskomuksia.

//Tehtaassa sisältää metodeja ja informaatiota,
//jotka muodostavat sanakirjan (Dictionary) uskomuksille.