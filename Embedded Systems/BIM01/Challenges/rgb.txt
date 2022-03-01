// C++ code
//
void setup()
{
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(2, OUTPUT);
}

void led(int vet[], bool red, bool blue, bool green) {
  digitalWrite(vet[2], red);
  digitalWrite(vet[1], blue);
  digitalWrite(vet[0], green);
}

void loop()
{	
  	int farol01[] = {10,11,12};
  	int farol02[] = {5,6,7};
  	int farol03[] = {2,3,4};
  	for(int i = 0; i<4; i++){ // estagio 1 e 2
  		led(farol01, LOW, LOW, HIGH); 
      	led(farol02, HIGH, LOW, LOW); 
      	led(farol03, HIGH, LOW, LOW);
        if(i == 0){
		   delay(3000);
        }else{
           delay(500);
           led(farol01, LOW, LOW, LOW); 
           led(farol02, LOW, LOW, LOW); 
           led(farol03, LOW, LOW, LOW);
           delay(500);
        }
  	}
  	for(int i = 0; i<4; i++){ // estagio 3 e 4
          led(farol01, HIGH, LOW, LOW); 
          led(farol02, LOW, LOW, HIGH); 
          led(farol03, HIGH, LOW, LOW);
        if(i == 0){
		   delay(3000);
        }else{
           delay(500);
           led(farol01, LOW, LOW, LOW); 
           led(farol02, LOW, LOW, LOW); 
           led(farol03, LOW, LOW, LOW);
           delay(500);
        }
  	}
  
    for(int i = 0; i<4; i++){ // estagio 5 e 6
         led(farol01, HIGH, LOW, LOW); 
         led(farol02, HIGH, LOW, LOW); 
         led(farol03, LOW, LOW, HIGH);
         if(i == 0){
           delay(3000);
         }else{
           delay(500);
           led(farol01, LOW, LOW, LOW); 
           led(farol02, LOW, LOW, LOW); 
           led(farol03, LOW, LOW, LOW);
           delay(500);
       }
    }
}

