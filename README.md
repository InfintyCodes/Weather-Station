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
![image](https://user-images.githubusercontent.com/70653989/146547957-995943b0-7c06-4f39-b6a3-4441b8e02262.png)

and that was the resault of the Source Code:
![image](https://user-images.githubusercontent.com/70653989/146536512-7f6a49d5-da41-48f0-b6ce-31056db11f44.png)
To Check The device code click on this link:
https://github.com/InfintyCodes/ESP8266Device

# The Simulate Sensor:
In this part i used a simulate device to collect temperature from an Api for my area using latitude and longatude 
Here is a pictures from the simulate device: 

![image](https://user-images.githubusercontent.com/70653989/146546274-5bb72a5d-c37c-4ff7-affd-e0eb86a03e01.png)
![image](https://user-images.githubusercontent.com/70653989/146547104-0925f2dd-aaa9-471f-8550-8b2a6f06bcde.png)
![image](https://user-images.githubusercontent.com/70653989/146547451-ba3616d7-785f-4042-8f88-073164ae3ff7.png)
![image](https://user-images.githubusercontent.com/70653989/146551900-cf5331dd-0e58-4107-be28-a3936f05892c.png)

To Check The device code click on this link:
https://github.com/InfintyCodes/Simulate-Device

# DataBase:
For this part i used SQL DataBase so i sent all the messages that were sent to My Azure IOTHUB to An SQL DataBase i created 
to save them there and use them for different purposes so in the future like(PowerBI, WebSite, ETC...).
![image](https://user-images.githubusercontent.com/70653989/146547608-2130a846-e436-428c-9405-f85e03b5b52f.png)

In this part i used an Azure Function i wrote in visual studio 2022 and this function saves data in SQL Queery by using an 
![image](https://user-images.githubusercontent.com/70653989/146547659-0851fbe6-3616-4bbd-985e-0ec0373149b0.png)

EventhubTrigger that's connected by IotHub-Primary-ConnectionString to MySQL-DataBase-ConnectionString
and here i visualize data in Power BI:
![image](https://user-images.githubusercontent.com/70653989/146514068-9e0bb011-124b-411d-9bbc-f4212f6f5d38.png)
![image](https://user-images.githubusercontent.com/70653989/146551149-3a20ea6a-7e6b-4de4-b8d7-7a6dccb83645.png)

To Check The device code click on this link:
https://github.com/InfintyCodes/SkickaMessagesToSqlDataBase

To Check the Website Source Code on this link:
https://github.com/InfintyCodes/WeatherWebsite


