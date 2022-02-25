/* How to use the DHT-22 sensor with Arduino uno
   Temperature and humidity sensor
*/

//Libraries
#include <DHT.h>;
//var
char reading = 0;
int sensor = 0;



//Constants
#define DHTPIN 7     // what pin we're connected to
#define DHTTYPE DHT11   // DHT 22  (AM2302)
DHT dht(DHTPIN, DHTTYPE); //// Initialize DHT sensor for normal 16mhz Arduino

void setup()
{
  Serial.begin(9600);
  Serial.println("DHT funcionando!");
  dht.begin();
}

void loop()
{
float h = dht.readHumidity();
float t = dht.readTemperature();
   if (isnan(t) || isnan(h)) 
     {
      Serial.println("Failed to read from DHT");
     } 
       else 
    {
      
      Serial.println(t);
      Serial.println(h);
  //espera 5 sec
      delay(5000);
    }
  if (Serial.available()){
    reading = Serial.read();
  }
  if (reading == '1')
  {
    while (reading == '1'){
      if (Serial.available()){
        reading = Serial.read();
      }
    
  }

 
   }
   else if(reading == '2'){
    //não faz nada
   }
}
