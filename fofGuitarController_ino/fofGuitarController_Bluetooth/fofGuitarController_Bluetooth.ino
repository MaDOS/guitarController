#include <CapacitiveSensor.h>
#include <SoftwareSerial.h>

//SoftwareSerial usb(0,1); // RX | TX //TODO: Problem with 2 SoftwareSerials reading usb still uses hardSerial
SoftwareSerial bt(2,3); // RX (-> TX on hc05) | TX (-> RX on hc05)

int menuInput = 7;
int menuSendPin = 8;
int capSenseSendPin = 9;
int resetTrigger = 10;
int menuNavState = LOW;

boolean usbConnected = false;
boolean btConnected = false;

CapacitiveSensor pick = CapacitiveSensor(capSenseSendPin,A0);
CapacitiveSensor fret5 = CapacitiveSensor(capSenseSendPin,A1);
CapacitiveSensor fret4 = CapacitiveSensor(capSenseSendPin,A2);
CapacitiveSensor fret3 = CapacitiveSensor(capSenseSendPin,A3);
CapacitiveSensor fret2 = CapacitiveSensor(capSenseSendPin,A4);
CapacitiveSensor fret1 = CapacitiveSensor(capSenseSendPin,A5);

int fret1State, fret2State, fret3State, fret4State, fret5State, pickState = LOW;
int menuNavigationState = LOW;

long threshold = 250;
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
  bt.begin(38400);
  
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
  //or
  driverDebug();
  
  trigger();
  triggerMenuSwitch();
  triggerConnect();
}

void writeToSerial(String data)
{
  if(usbConnected)
  {
    Serial.print(data);
  }
  if(btConnected)
  {
    bt.print(data);
  }
}

void writeToSerial(String data, boolean debug)
{
  if(usbConnected || debug)
  {
    Serial.print(data);
  }
  if(btConnected)
  {
    bt.print(data);
  }
}

void writeToSerial(long int data)
{
  if(usbConnected)
  {
    Serial.print(data);
  }
  if(btConnected)
  {
    bt.print(data);
  }
}

void trigger()
{
  if(valF1 > threshold) 
  {
    if(fret1State == LOW)
    {
      fret1State = HIGH;
      writeToSerial("fret1:HIGH;");
    }
  }
  else 
  {
    if(fret1State == HIGH)
    {
      fret1State = LOW;
      writeToSerial("fret1:LOW;");
    }
  }
  
  if(valF2 > threshold) 
  {
    if(fret2State == LOW)
    {
      fret2State = HIGH;
      writeToSerial("fret2:HIGH;");
    }
  }
  else 
  {
    if(fret2State == HIGH)
    {
      fret2State = LOW;
      writeToSerial("fret2:LOW;");
    }
  }
  
  if(valF3 > threshold) 
  {
    if(fret3State == LOW)
    {
      fret3State = HIGH;
      writeToSerial("fret3:HIGH;");
    }
  }
  else 
  {
    if(fret3State == HIGH)
    {
      fret3State = LOW;
      writeToSerial("fret3:LOW;");
    }
  }
  
  if(valF4 > threshold) 
  {
    if(fret4State == LOW)
    {
      fret4State = HIGH;
      writeToSerial("fret4:HIGH;");
    }
  }
  else 
  {
    if(fret4State == HIGH)
    {
      fret4State = LOW;
      writeToSerial("fret4:LOW;");
    }
  }
  
  if(valF5 > threshold) 
  {
    if(fret5State == LOW)
    {
      fret5State = HIGH;
      writeToSerial("fret5:HIGH;");
    }
  }
  else 
  {
    if(fret5State == HIGH)
    {
      fret5State = LOW;
      writeToSerial("fret5:LOW;");
    }
  }
  
  if(valPick > threshold)
  {
    if(pickState == LOW)
    {
      pickState = HIGH;
      writeToSerial("pick:HIGH;");
    }
  }
  else 
  {
    if(pickState == HIGH)
    {
      pickState = LOW;
      writeToSerial("pick:LOW;");
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
  writeToSerial("menuNav:HIGH;");
}

void menuNavigationLOW()
{
  menuNavState = LOW;
  writeToSerial("menuNav:LOW;");
}

void triggerConnect()
{
  char chr;
  
  while(Serial.available())
  {
    chr = Serial.read();
    if(chr == 'u')
    { 
      usbConnected = true;
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
  
  while(bt.available())
  {
    chr = bt.read();
    if(chr == 'b')
    {
      btConnected = true;
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
}

void driverDebug()
{
  //--- MeasureDelay
  
  if((millis() - lastSentProbeDelayMillis) > measureDelayProbeDelay)
  {
    measureDelay = sensorDelayEnd - sensorDelayStart;
    writeToSerial("measureDelay:");
    writeToSerial(measureDelay);
    writeToSerial(";");
    lastSentProbeDelayMillis = millis();
  }
  
  
  //--- Search for new minVal
  if(valF1 < minMeasuredVal)
  {
    //minMeasuredVal = valF1;
    //writeToSerial("minVal:");
    //writeToSerial(minMeasuredVal);
    //writeToSerial(";");
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

