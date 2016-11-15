/*
	Particle Photon project for Visual Studio 2015

	This sample sketch is provided as it is without any WARRANTY.
	You can	use it for personal as well as commercial use.

	I am not liable for any loss of data or injuries caused by
	this sketch or this project tools as well as solution.

	Refer following link for more info:
	https://www.hackster.io/AnuragVasanwala/particle-photon-visual-studio-2015-ea22e0
	
	(E): AnuragVasanwala@Gmail.com

*/

/* Always remember to include Global.h or application.h */
#include "Global.h"

void setup()
{
	/* Configure Serial/UART @ 9600 baud */
	Serial.begin(9600);
	Serial.println("Hello Cloud :)");

	/* Disable automating flashing RGB LED */
	RGB.control(true);

	/* 
		Setup PinMiode.

		Pin-mappings are defined in PinMappings.h
		which can be found in Solution Explorer.

		"CTRL+ALT+L" to open Solution Explorer

		To change BuiltInLED value on the go,
		move cursor on 'BuiltInLED' and hit F12.
	*/
	pinMode(BuiltInLED, OUTPUT);
	pinMode(ExternalLED, OUTPUT);

	/*
		Setup Particle Cloud Function for led parameter
		
		'ledToggle' function is defined in Global.h
		Open Global.h to modify it.
	*/
	Particle.function("led", ledToggle);

	/* Setup LEDs initial state */
	digitalWrite(BuiltInLED, LOW);
	digitalWrite(ExternalLED, LOW);

}

void loop()
{
	/* Every 5sec, blink RGB LED */
	if (millis() - Time1 > 5000)
	{
		Serial.println("Hello Cloud :)");

		/* Set Cyan color of RGB LED */
		RGB.color(RGB_COLOR_CYAN);

		/* Wait for 20 milliseconds */
		delay(20);

		/* Reset RGB LED */
		RGB.color(0, 0, 0);

		/* Store current milliseconds */
		Time1 = millis();
	}
}
