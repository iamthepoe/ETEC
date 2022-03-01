// C++ code
//
void setup()
{
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
}

void led(int vet[], bool red, bool blue, bool green) {
  digitalWrite(vet[2], red);
  digitalWrite(vet[1], blue);
  digitalWrite(vet[0], green);
}

void loop()
{	
  	int farol01[] = {10,11,12};
  	led(farol01, LOW, LOW, HIGH);
  	delay(1000);
  	led(farol01, HIGH, LOW, LOW);
  	delay(1000);
  	led(farol01, LOW, HIGH, LOW);
  	delay(1000);
  	led(farol01, HIGH, LOW, HIGH);
  	delay(2000);
  	led(farol01, LOW, HIGH, HIGH);
  	delay(3000);
  	led(farol01, HIGH, HIGH, LOW);
  	delay(4000);
  	led(farol01, HIGH, HIGH, HIGH);
  	delay(10000);
  	led(farol01, HIGH, HIGH, LOW);
  	delay(4000);
  	led(farol01, LOW, HIGH, HIGH);
  	delay(3000);
  	led(farol01, HIGH, LOW, HIGH);
  	delay(2000);
  	led(farol01, LOW, HIGH, LOW);
  	delay(1000);
  	led(farol01, HIGH, LOW, LOW);
  	delay(1000);
 	led(farol01, LOW, LOW, HIGH);
  	delay(1000);
}

