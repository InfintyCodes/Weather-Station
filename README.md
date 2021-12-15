# Weather-Station

In this project i used Adafruit Huzzah ESP8266 that was connected to DHT11 to Know the temperature in my Garage and compare it with the temperature from an API for the area that i am living in to turn on the engine heater so i can save time and i did the same for my house to save energi that the heater burn by know the right temperature second by second.

# Components:
1. Adafruit Huzzah ESP8266.
2. DHT11.
3. Simulate device "For API".

# Editors I Used:
1. Visual Studio 2022.
2. Arduino IDE.

# The Temperature Sensor:
For The Real sensor i wrote the code in Arduino IDE.
I connect the ESP8266 to the internet using WIFI library in Arduino IDE For the ESP8266 "#include <ESP8266WiFi.h>" then i connected it to Azure IOTHUB using the Connection String for a Device i already created in my IOTHUB and the messages were sending using MQTT-Protocol when the temperature changes 
