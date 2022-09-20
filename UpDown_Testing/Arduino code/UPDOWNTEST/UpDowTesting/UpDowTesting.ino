
const int btUP = 3;
const int btDOWN = 2;// the number of the pushbutton pin
const int ledUP =  12;      // the number of the LED pin
const int ledDOWN =  11; 
char val;


void setup() {

  Serial.begin(9600);

  pinMode(ledUP, OUTPUT);
  pinMode(ledDOWN, OUTPUT);
  pinMode(btUP, INPUT);
  pinMode(btDOWN, INPUT);
}

void loop() {

  if (digitalRead(btUP) == HIGH){

    digitalWrite(ledUP, HIGH);
    Serial.write('u');
    Serial.flush();
    
   }else{

     digitalWrite(ledUP, LOW);
    
    }
   if (digitalRead(btDOWN) == HIGH){

    digitalWrite(ledDOWN, HIGH);
    Serial.write('d');
    Serial.flush();
    
    }else{

      digitalWrite(ledDOWN, LOW);
      
      }
}
