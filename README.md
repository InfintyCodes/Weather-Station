# Weather-Station

In this project i used Adafruit Huzzah ESP8266 that was connected to DHT11 to Know the temperature in my Garage and compare it 
with the temperature from an API for the area that i am living in to turn on the engine heater so i can save time 
and i did the same for my house to save energi that the heater burn by know the right temperature second by second.

# Components:
1. Adafruit Huzzah ESP8266.
2. DHT11.
3. Simulate device "For API".

# Editors I Used:
1. Visual Studio 2022.
2. Arduino IDE.

# The Temperature Sensor:
For The Real sensor i wrote the code in Arduino IDE.
I connect the ESP8266 to the internet using WIFI library in Arduino IDE For the ESP8266 "#include <ESP8266WiFi.h>" then i 
connected it to Azure IOTHUB using the Connection String for a Device i already created in my IOTHUB and the messages were 
sending using MQTT-Protocol when the temperature changes 
![image](https://user-images.githubusercontent.com/70653989/146512094-e2100cb9-90b4-4a9f-af9c-3b2e78c988b8.png)
To Check The device code click on this link:
https://github.com/InfintyCodes/ESP8266Device

# DataBase:
For this part i used SQL DataBase so i sent all the messages that were sent to My Azure IOTHUB to An SQL DataBase i created 
to save them there and use them for different purposes so in the future like(PowerBI, WebSite, ETC...).
In this part i used an Azure Function i wrote in visual studio 2022 and this function saves data in SQL Queery by using an 
EventhubTrigger that's connected by IotHub-Primary-ConnectionString to MySQL-DataBase-ConnectionString
To Check The device code click on this link:
https://github.com/InfintyCodes/SkickaMessagesToSqlDataBase



