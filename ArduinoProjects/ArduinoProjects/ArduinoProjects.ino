///*
// Name:		ArduinoProjects.ino
// Created:	11/2/2016 10:21:28 AM
// Author:	hrm30
//*/
//#include "TestCounter.h"
//int Number;
//// the setup function runs once when you press reset or power the board
//void setup() {
//	Serial.begin(57600);
//	pinMode(LED_BUILTIN, OUTPUT);
//	pinMode(10, INPUT);
//	
//}
//
//// the loop function runs over and over again until power down or reset
//void loop() {
//	TestCounter x;
//	Number = x.Number;
//	//Serial.println("Hello World");
//	//Serial.print("PI = ");
//
//	Serial.println(Number);
//	x.LedLamp();
//	//Serial.println(PI, 6);
//	//digitalWrite(LED_BUILTIN, HIGH);
//	//delay(500);
//	//digitalWrite(LED_BUILTIN, LOW);
//	//
//	//delay(1500);
//	//int Sensorvalue = digitalRead(10);
//	//Serial.println(Sensorvalue);
//	
//}

#include <SoftwareSerial.h>

SoftwareSerial wifi{ 2,3 };

void setup() {
	Serial.begin(9600);
	Serial.println("Start Wifi");
	wifi.begin(9600);
}

void loop() {
	if (Serial.available() > 0)
	{
		Serial.println("yes");
		byte b = Serial.read();
		wifi.write(b);
		Serial.write(b);
	}
	else
	{
		//Serial.println("no");
		byte b = Serial.read();
		wifi.write(b);

	}

}
