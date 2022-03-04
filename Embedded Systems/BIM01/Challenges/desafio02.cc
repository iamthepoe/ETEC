const int pinoAnalogico = A0;
int posicaoled = 9;
int leds[] = {5, 6, 7, 8, 9, 10, 11, 12, 13}; //ISSO É UM ARRAY

void setup()
{
  for(int thisLed = 0; thisLed < 9; thisLed++){
  pinMode(leds[thisLed], OUTPUT);
  }
  pinMode(pinoAnalogico, INPUT);
}

void loop()
{
  int sensorReading = analogRead(pinoAnalogico);
  int ledLevel = map(sensorReading, 0, 1023, 0, 9);
 
    for(int thisLed = 0; thisLed < 9; thisLed++){
      if(ledLevel>thisLed){
      	digitalWrite(leds[thisLed], HIGH);
      }else{
      	digitalWrite(leds[thisLed], LOW);
      }
    }
                       
}