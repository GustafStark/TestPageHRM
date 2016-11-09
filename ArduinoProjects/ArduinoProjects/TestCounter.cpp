#include "TestCounter.h"
#include "pins_arduino.h"




TestCounter::TestCounter()
{
}


TestCounter::~TestCounter()
{
}

void TestCounter::LedLamp()
{

	digitalWrite(LED_BUILTIN, HIGH);
	delay(1500);
	digitalWrite(LED_BUILTIN, LOW);
	delay(1500); 
	digitalWrite(LED_BUILTIN, HIGH);
	delay(1500);
	digitalWrite(LED_BUILTIN, LOW);
	delay(500);
	digitalWrite(LED_BUILTIN, HIGH);
	delay(500);
	digitalWrite(LED_BUILTIN, LOW);
	delay(500);
	printf("Hello");
}
