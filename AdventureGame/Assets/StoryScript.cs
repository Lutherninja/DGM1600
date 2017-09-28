using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textObject;

	public enum States {start, bedroom, main_room, outside, look, };
	public States myState;

	public bool wood = false;
	public bool stone = false;


	void Start () {
		myState = States.start;

	}

	void Update () {
		if (myState == States.start) {
			State_start ();
		} else if (myState == States.main_room) {
			State_mainroom ();
		} else if (myState == States.outside) {
			State_outside ();
		} else if (myState == States.look) {
			State_look ();
		}
	}

	void State_start (){
		textObject.text = "You awake to the sound of yelling and clanging metal." +
		"\nThere is a single door in your bedroom that leads to the main room" +
		"\n\npress D to go to the main room";

		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.main_room;
		}
	}

	void State_mainroom (){
		textObject.text = "The main room is a mess. Tables are turned over, and there is no sign of your parents." +
			"\nYou see fire blazing outside your windows. Your front door is gone." +
			"\n\nPress 'o' to go outside" +
			"\n\nPress 'L' to look around some more";

		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.outside;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.look;
		}

	}
		
	void State_outside (){
		textObject.text = "You rush outside and you see vikings making waste of your village." +
			"\nOff to your left you see a small clearing in the woods you could use to escape" +
			"\n you also see a viking standing over a man rasing an axe" +
			"\n\nPress 'E' to escape" +
			"\nPress 'V' to engage the viking";
		}
	
	void State_look (){
		if (wood == true) {
			textObject.text = "Looking at the room and the unturned furniture you notice a small stone on the floorthat looks unfamiliar" +
				"\nyou have taken the wood" +
				"\n\nPress 'S' to pick up stone" +
			"\nPress 'o' to go outside";
		} else {
			textObject.text = "Looking at the room and the unturned furniture you notice a small stone on the floorthat looks unfamiliar" +
		"\nAmong the flipped wooden furniture you find a sharp piece of wood" +
		"\n\nPress 'S' to pick up stone" +
		"\nPress 'W' to pick up the wood" +
		"\nPress 'o' to go outside";
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.outside;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			wood = true;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			stone = true;
		}
	}
}