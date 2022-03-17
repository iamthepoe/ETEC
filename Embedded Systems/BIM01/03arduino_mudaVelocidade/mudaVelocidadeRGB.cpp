// C++ code
//

const int pinoAnalogico = A0; //configurando o potenciometro
const int posicao[] = {2,3,4}; //inserindo as posições do RGB no arduino
void setup()
{
  pinMode(LED_BUILTIN, OUTPUT);
  pinMode(pinoAnalogico, INPUT);
  for(int i = 0; i<3; i++){ //configurando as posições usando laço de repetição for
  	pinMode(posicao[i], OUTPUT);
  }
}

void led(bool red, bool blue, bool green){ //função utilizada para facilitar o trabalho de ligar e desligar as leds
	digitalWrite(posicao[0], green);	
	digitalWrite(posicao[1], blue);	
	digitalWrite(posicao[2], red);	
} //para utilizá-la, apenas declaramos o que estará aceso e apagado, facilitando o trabalho

void loop()
{
  int sensorReading = analogRead(pinoAnalogico);
  int ledLevel = map(sensorReading, 0, 1023, 0, 4); //configurando as posições do potenciometro
  int meuDelay = 1; //criando a variável que vai agilizar ou atrasar a velocidade dos leds de acordo com o potenciometro
  if(ledLevel == 0){ //colocando os ifs para alterar a velocidade de acordo com o potenciometro
  	meuDelay = 10;
  }else if(ledLevel == 1){
  	meuDelay = 100;
  }else if(ledLevel == 2){
  	meuDelay = 200;
  }else if(ledLevel == 3){
  	meuDelay = 400;
  }else if(ledLevel == 4){
  	meuDelay = 800;
  }
  for(int i = 0; i<3; i++){ //ligando e mudando as cores do led RGB de acordo com o índice do laço de repetição
    if(i==0){
      led(HIGH, LOW, LOW);
    }
    delay(meuDelay);
    if(i==1){
      led(LOW, HIGH, LOW);
    }
    delay(meuDelay);
    if(i==2){
    	led(LOW, LOW, HIGH);
    }
    delay(meuDelay);
    if(i==3){
    	led(HIGH, HIGH, HIGH);
    }
    delay(meuDelay);
  }
  
}