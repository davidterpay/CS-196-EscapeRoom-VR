#pragma strict

var sound : AudioClip;

function Start () {
	
}
 
function OnTriggerEnter(Col : Collider)
{
	if(Col.CompareTag("Player"))
	{
		GetComponent.<AudioSource>().PlayOneShot(sound);
	}
}