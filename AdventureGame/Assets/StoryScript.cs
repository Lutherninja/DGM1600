using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textObject;

	public enum States {start, bedroom, main_room, outside, look, woods, viking, punch, running, escape, distract };
	public States myState;

	public bool wood = false;
	public bool stone = false;


	void Start () {
		myState = States.start;

	}
	void Reset () {
		wood = false;
		stone = false;

			
	
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
		} else if (myState == States.viking) {
			State_viking ();
		} else if (myState == States.woods) {
			State_woods ();
		} else if (myState == States.escape) {
			State_escape ();
		} else if (myState == States.punch) {
			State_punch ();
		} else if (myState == States.distract) {
			State_distract ();
		} else if (myState == States.running) {
			State_running ();
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
		if (stone == true) {
			textObject.text = "You rush outside and you see vikings making waste of your village." +
			"\nOff to your left you see a small clearing in the woods you could use to escape" +
			"\nyou also see a viking standing over a man rasing an axe" +
			"\n\nPress 'E' to escape" +
			"\nPress 'V' to engage the viking" +
			"\nPress 'T' to throw your stone to distract the viking";
		} else if (stone == false) {
			textObject.text = "You rush outside and you see vikings making waste of your village." +
			"\nOff to your left you see a small clearing in the woods you could use to escape" +
			"\nyou also see a viking standing over a man rasing an axe" +
			"\n\nPress 'E' to escape" +
			"\nPress 'V' to engage the viking" +
			"\nPress 'R' to go back to main room";
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.woods;
		} else if (Input.GetKeyDown (KeyCode.V)) {
			myState = States.viking;
		} else if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.woods;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.main_room;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.distract;
		}
	}
	
	void State_look (){
		if (wood == true && stone == false) {
			textObject.text = "Looking at the room and the unturned furniture you notice a small stone on the floorthat looks unfamiliar" +
			"\n\nPress 'S' to pick up stone" +
			"\nYou have taken the wood" +
			"\nPress 'O' to go outside" +
			"\nPress 'R' to go back to the main room";
		} else if (stone == true && wood == false) {
			textObject.text = "Looking at the room and the unturned furniture you notice a small stone on the floorthat looks unfamiliar" +
			"\n\nYou have taken the stone" +
			"\nPress 'W' to pick up wood" +
			"\nPress 'O' to go outside" +
			"\nPress 'R' to go back to the main room";
		} else if (wood == true && stone == true) {
			textObject.text = "Looking at the room and the unturned furniture you notice a small stone on the floorthat looks unfamiliar" +
				"\n\nYou have taken the stone" +
				"\nYou have taken the wood" +
				"\nPress 'O' to go outside" +
				"\nPress 'R' to go back to the main room";
		} else if (wood == false && stone == false) {
			textObject.text = "Looking at the room and the unturned furniture you move towards a table and notice a small stone on the floorthat looks unfamiliar" +
			"\nAmong the flipped wooden furniture you find a sharp piece of wood" +
			"\n\nPress 'S' to pick up stone" +
			"\nPress 'W' to pick up the wood" +
			"\nPress 'O' to go outside" +
			"\nPress 'R' to go back to the main room";
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.outside;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			wood = true;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			stone = true;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.main_room;
		}
	}

	void State_viking () {
		if (wood == true && stone == true) {
			textObject.text = "You sneak up behind the viking and jam the wooden stick into his lower knee, the viking drops. You now have an opening" +
			"\n\nPress 'P' to punch the viking" +
			"\nPress 'R' to grab the man and run";
		} else if (wood == false) {
			textObject.text = "You sneak up behind the viking and grab him. He spins loosening your grip and takes a swipe with his axe cutting deep into your side." +
			"\nYou lie there bleeding out, as you see the axe fall on the man you tried to save." +
			"\n\nGAME OVER";
		} 
		if (Input.GetKeyDown (KeyCode.E)) {
			Reset ();
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.punch;
		}
	}

	void State_woods () {
		textObject.text = "You see a small clearing in the woods that you use to avoid being seen by the Viking." +
		"\nYou live your new life in the forest providing for yourself. You are a survivor." +
		"\n\nYOU WIN";
	}
	void State_punch () {
		if (stone == true) {
			textObject.text = "You grip the stone in your hand and swing forward with all your might, making a connection with the side of the Viking's head. The Viking drops." +
			"\nThe man expresses his gratitude" +
			"\n\nPress E to escape with the man";
		} else if (stone == false) {
			textObject.text = "You swing your fist with all the strength you can muster and catch the viking in the back of the head." +
			"\nthe viking stumbles forward and turns swinging his axe slicing into your stomach." +
			"\nYou lie there bleeding out as you watch the viking swing his axe down on the man" +
			"\n\nGAME OVER";
		} 
		if (Input.GetKeyDown (KeyCode.E)) {
			myState = States.escape;
		}

	}
	void State_escape () {
		textObject.text = "You help the man up and you both make a break for the forest bordering the village." +
			"\nYou made a clean escape and saved the mans life. You are a hero." +
			"\n\nYOU WIN";
	}
	void State_distract () {
		textObject.text = "You throw your stone and the viking looks around, not certain where the sound had come from." +
			"\nNows your chance!" +
			"\n\nPress 'V' to engage viking" +
			"\nPress 'R' to run away with the man";
		if (Input.GetKeyDown (KeyCode.V)) {
			myState = States.viking;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.running;
		}

	}	
	void State_running () {
		textObject.text = "You grab the man and run twards the woods, the Viking spins furiously unsure of what is going on" +
			"\nYou enter the woods and are out of sight before the Viking can chase you" +
			"\nThe man expresses his gratitude and you live your lives traveling and providing for yourselves. You are a hero" +
			"\n\nYOU WIN";
	
	}
}

