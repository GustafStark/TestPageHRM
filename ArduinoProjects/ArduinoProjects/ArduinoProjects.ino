/*
 Name:		ArduinoProjects.ino
 Created:	11/2/2016 10:21:28 AM
 Author:	hrm30
*/
#include "TestCounter.h"
int Number;
// the setup function runs once when you press reset or power the board
void setup() {
	Serial.begin(57600);
	pinMode(LED_BUILTIN, OUTPUT);
	pinMode(10, INPUT);
	
}

// the loop function runs over and over again until power down or reset
void loop() {
	TestCounter x;
	Number = x.Number;
	//Serial.println("Hello World");
	//Serial.print("PI = ");

	//Serial.println(Number);
	//Serial.println(PI, 6);
	digitalWrite(LED_BUILTIN, HIGH);
	delay(500);
	digitalWrite(LED_BUILTIN, LOW);
	
	delay(500);
	int Sensorvalue = digitalRead(10);
	Serial.println(Sensorvalue);
	
}
