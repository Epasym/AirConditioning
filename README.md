# AirConditioning
A simple AC simulation in C#

Each AC unit has a name, default is simply "AirCon".
The targettemp field is simply the temperature the unit wants to reach.
Cooling is whether it must cool the room or heat it.
On simply states whether or not the unit is powered on.
maxtemp and mintemp are the highest and lowest temperatures the unit can be effective at.
power is how effective the unit is (from 1 to 10)

The StartStop method behaves the way an On/Off button would.
Similarly, the CoolHeat method behaves like a toggle between cooling and heating.
TempUp and TempDown change the targettemperature incrementally after checking that it doesn't exceed the max and min.
ConditionRoom takes any float, meant to represent the room's current temperature, and after checking if it's on and cooling or heating
tries to reach that temperature.
The rest are simple setters and getters.

The Room class only has two properties, a name and a temperature. It's only here for the Airconunit class to interact with.
