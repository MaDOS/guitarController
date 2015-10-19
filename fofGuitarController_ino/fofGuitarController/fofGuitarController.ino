int fret1 = A5;
int fret2 = A4;
int fret3 = A3;
int fret4 = A2;
int fret5 = A1;
int pick = A0;

int fret1State, fret2State, fret3State, fret4State, fret5State, pickState = LOW;


void setup()
{
  pinMode(fret1, INPUT_PULLUP);
  pinMode(fret2, INPUT_PULLUP);
  pinMode(fret3, INPUT_PULLUP);
  pinMode(fret4, INPUT_PULLUP);
  pinMode(fret5, INPUT_PULLUP);
  pinMode(pick, INPUT_PULLUP);
  Serial.begin(9600);
}

void loop()
{
  readStates();
  delay(10);
}

void readStates()
{
  if(digitalRead(fret1) == LOW) //PULLUP invertiert -> HIGH
  {
    if(fret1State == LOW)
    {
      fret1State = HIGH;
      Serial.print("fret1:HIGH;");
    }
  }
  else 
  {
    if(fret1State == HIGH)
    {
      fret1State = LOW;
      Serial.print("fret1:LOW;");
    }
  }
  
  if(digitalRead(fret2) == LOW) //PULLUP invertiert -> HIGH
  {
    if(fret2State == LOW)
    {
      fret2State = HIGH;
      Serial.print("fret2:HIGH;");
    }
  }
  else 
  {
    if(fret2State == HIGH)
    {
      fret2State = LOW;
      Serial.print("fret2:LOW;");
    }
  }
  
  if(digitalRead(fret3) == LOW) //PULLUP invertiert -> HIGH
  {
    if(fret3State == LOW)
    {
      fret3State = HIGH;
      Serial.print("fret3:HIGH;");
    }
  }
  else 
  {
    if(fret3State == HIGH)
    {
      fret3State = LOW;
      Serial.print("fret3:LOW;");
    }
  }
  
  if(digitalRead(fret4) == LOW) //PULLUP invertiert -> HIGH
  {
    if(fret4State == LOW)
    {
      fret4State = HIGH;
      Serial.print("fret4:HIGH;");
    }
  }
  else 
  {
    if(fret4State == HIGH)
    {
      fret4State = LOW;
      Serial.print("fret4:LOW;");
    }
  }
  
  if(digitalRead(fret5) == LOW) //PULLUP invertiert -> HIGH
  {
    if(fret5State == LOW)
    {
      fret5State = HIGH;
      Serial.print("fret5:HIGH;");
    }
  }
  else 
  {
    if(fret5State == HIGH)
    {
      fret5State = LOW;
      Serial.print("fret5:LOW;");
    }
  }
  
  if(digitalRead(pick) == LOW) //PULLUP invertiert -> HIGH
  {
    if(pickState == LOW)
    {
      pickState = HIGH;
      Serial.print("pick:HIGH;");
    }
  }
  else 
  {
    if(pickState == HIGH)
    {
      pickState = LOW;
      Serial.print("pick:LOW;");
    }
  }
}
