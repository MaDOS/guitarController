#include <CapacitiveSensor.h>

int menuInput = 7;
int menuSendPin = 8;
int capSenseSendPin = 9;
int resetTrigger = 10;
int menuNavState = LOW;

CapacitiveSensor pick = CapacitiveSensor(capSenseSendPin,A0);
CapacitiveSensor fret5 = CapacitiveSensor(capSenseSendPin,A1);
CapacitiveSensor fret4 = CapacitiveSensor(capSenseSendPin,A2);
CapacitiveSensor fret3 = CapacitiveSensor(capSenseSendPin,A3);
CapacitiveSensor fret2 = CapacitiveSensor(capSenseSendPin,A4);
CapacitiveSensor fret1 = CapacitiveSensor(capSenseSendPin,A5);

int fret1State, fret2State, fret3State, fret4State, fret5State, pickState = LOW;
int menuNavigationState = LOW;

long threshold = 350;
long valF1 = 0;
long valF2 = 0;
long valF3 = 0;
long valF4 = 0;
long valF5 = 0;
long valPick = 0;

long sensorDelayStart = 0;
long sensorDelayEnd = 0;

//--- driver debug
int maxMeasuredVal = 0;
int minMeasuredVal = 1000;
int resetDelayMinMax = 10000;
long lastMinMaxResetMillis = 0;


long measureDelay = 0;
int measureDelayProbeDelay = 50;
long lastSentProbeDelayMillis = 0;
//---

void setup()
{
  digitalWrite(resetTrigger, HIGH);
  pinMode(resetTrigger, OUTPUT);
  pinMode(menuSendPin, OUTPUT);
  pinMode(menuInput, INPUT_PULLUP);
  digitalWrite(menuSendPin, LOW);
  
  Serial.begin(38400);
  
  if(digitalRead(menuInput) == LOW)
  {
    menuNavigationHIGH(); //Pullup inverts
  }
  else
  {
    menuNavigationLOW();
  }
}

void loop()
{ 
  sensorDelayStart = millis();
  
  valF1 =  fret1.capacitiveSensor(10);
  valF2 =  fret2.capacitiveSensor(10);
  valF3 =  fret3.capacitiveSensor(10);
  valF4 =  fret4.capacitiveSensor(10);
  valF5 =  fret5.capacitiveSensor(10);
  valPick =  pick.capacitiveSensor(10);
  
  sensorDelayEnd = millis();
  
  
  //debug();
  
  driverDebug();
  
  trigger();
  triggerMenuSwitch();
  triggerConnect();
}

void trigger()
{
  if(valF1 > threshold) 
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
  
  if(valF2 > threshold) 
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
  
  if(valF3 > threshold) 
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
  
  if(valF4 > threshold) 
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
  
  if(valF5 > threshold) 
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
  
  if(valPick > threshold)
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

void triggerMenuSwitch()
{
  if(digitalRead(menuInput) == LOW)
  {
    if(menuNavState == LOW)
    {
      menuNavigationHIGH(); //Pullup inverts
    }
  }
  else
  {
    if(menuNavState == HIGH)
    {
      menuNavigationLOW();
    }
  }
}

void menuNavigationHIGH()
{
  menuNavState = HIGH;
  Serial.print("menuNav:HIGH;");
}

void menuNavigationLOW()
{
  menuNavState = LOW;
  Serial.print("menuNav:LOW;");
}

void triggerConnect()
{
  String rcv = "";
  char chr;
  
  while(Serial.available())
  {
    chr = Serial.read();
    rcv.concat(chr);
  }
  
  if(rcv == "u")
  {
    if(digitalRead(menuInput) == LOW)
    {
      menuNavigationHIGH(); //Pullup inverts
    }
    else
    {
      menuNavigationLOW();
    }
  }
}

void driverDebug()
{
  //--- MeasureDelay
  
  if((millis() - lastSentProbeDelayMillis) > measureDelayProbeDelay)
  {
    measureDelay = sensorDelayEnd - sensorDelayStart;
    Serial.print("measureDelay:");
    Serial.print(measureDelay);
    Serial.print(";");
    lastSentProbeDelayMillis = millis();
  }
  
  
  //--- Search for new minVal
  if(valF1 < minMeasuredVal)
  {
    //minMeasuredVal = valF1;
    //Serial.print("minVal:");
    //Serial.print(minMeasuredVal);
    //Serial.print(";");
  }
}

void debug()
{ 
  Serial.print("Performance Delay: ");
  Serial.print(millis() - sensorDelayStart);   
  Serial.print("\r\n");
  
  Serial.print("\tFret1: "); 
  Serial.print(valF1); 
  Serial.print("\r\n");
  
  Serial.print("\tFret2: "); 
  Serial.print(valF2); 
  Serial.print("\r\n");

  Serial.print("\tFret3: "); 
  Serial.print(valF3); 
  Serial.print("\r\n");

  Serial.print("\tFret4: "); 
  Serial.print(valF4); 
  Serial.print("\r\n");

  Serial.print("\tFret5: "); 
  Serial.print(valF5); 
  Serial.print("\r\n");

  Serial.print("\tPick: "); 
  Serial.print(valPick); 
  Serial.print("\r\n");  
  
  delay(50);
}

