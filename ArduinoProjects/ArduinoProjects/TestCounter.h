#pragma once
#ifndef TESTCOUNTER_H
#define TESTCOUNTER_H

#include "Arduino.h"

class TestCounter
{
	private:
public:
	TestCounter();
	~TestCounter();
	void LedLamp();
	int Number = 1;


};
#endif // TESTCOUNTER_H
