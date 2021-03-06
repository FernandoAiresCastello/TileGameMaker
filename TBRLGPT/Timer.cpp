/*=============================================================================

     TBRLGPT
     Tile-Based Retro-Looking Game Project Toolkit

     2018-2021 Developed by Fernando Aires Castello

=============================================================================*/

#include "Timer.h"

namespace TBRLGPT
{
	Timer::Timer() : Timer(0, NULL)
	{
	}

	Timer::Timer(int max, void(*callback)())
	{
		Time = 0;
		MaxTime = max > 0 ? max : 1;
		Callback = callback;
	}

	Timer::~Timer()
	{
	}

	int Timer::GetTime()
	{
		return Time;
	}

	void Timer::Step()
	{
		Time++;
		if (Time > MaxTime) {
			Time = 0;
			if (Callback)
				Callback();
		}
	}

	void Timer::OnInterval(void(*callback)())
	{
		Callback = callback;
	}
}
