#include <stdio.h>
#include <DHT22.h>
#define DHT22_PIN 0 //porta do sensor
DHT22 myDHT22(DHT22_PIN);
float valumid=0;
float valtemp=0;
void setup()
{
Serial.begin(9600);
DHT22_ERROR_t error;
pinMode(Rele1_PIN,OUTPUT);
digitalWrite(Rele1_PIN,LOW);
}
void loop()
{
DHT22_ERROR_t error;
error = myDHT22.readData();
if(error==DHT_ERROR_NONE)
{
valtemp=myDHT22.getTemperatureC();
valumid=myDHT22.getHumidity();
Serial.print(valtemp);
Serial.println(" C");
Serial.print(valumid);
Serial.println("%");
}
delay(1000); //delay de 1 segundo
}
