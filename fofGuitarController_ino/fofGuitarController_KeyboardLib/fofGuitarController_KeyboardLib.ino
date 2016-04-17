#include <CapacitiveSensor.h>

int capSenseSendPin = 9;

CapacitiveSensor pick = CapacitiveSensor(capSenseSendPin,3);
CapacitiveSensor fret5 = CapacitiveSensor(capSenseSendPin,8);
CapacitiveSensor fret4 = CapacitiveSensor(capSenseSendPin,7);
CapacitiveSensor fret3 = CapacitiveSensor(capSenseSendPin,6);
CapacitiveSensor fret2 = CapacitiveSensor(capSenseSendPin,5);
CapacitiveSensor fret1 = CapacitiveSensor(capSenseSendPin,4);

byte fret1State, fret2State, fret3State, fret4State, fret5State, pickState = 0x00;

long threshold = 300;
long valF1 = 0;
long valF2 = 0;
long valF3 = 0;
long valF4 = 0;
long valF5 = 0;
long valPick = 0;

long sensorDelayStart = 0;
long sensorDelayEnd = 0;

void setup()
{  
  //Serial.begin(9600);
  Keyboard.begin();
}

void loop()
{ 
  valF1 =  fret1.capacitiveSensor(12);
  valF2 =  fret2.capacitiveSensor(12);
  valF3 =  fret3.capacitiveSensor(12);
  valF4 =  fret4.capacitiveSensor(12);
  valF5 =  fret5.capacitiveSensor(12);
  valPick =  pick.capacitiveSensor(12);
  
  trigger(); 
  
  //debug();
}

void trigger()
{
  if(valF1 > threshold) 
  {
    if(fret1State == 0x00)
    {
      fret1State = 0xFF;
      Keyboard.press('a');
      Serial.println("Pressing a");
    }
  }
  else 
  {
    if(fret1State == 0xFF)
    {
      fret1State = 0x00;  
      Keyboard.release('a');
      Serial.println("Releasing a");
    }
  }
  
  if(valF2 > threshold) 
  {
    if(fret2State == 0x00)
    {
      fret2State = 0xFF;
      Keyboard.press('s');
      Serial.println("Pressing s");
    }
  }
  else 
  {
    if(fret2State == 0xFF)
    {
      fret2State = 0x00;
      Keyboard.release('s');
      Serial.println("Releasing s");
    }
  }
  
  if(valF3 > threshold) 
  {
    if(fret3State == 0x00)
    {
      fret3State = 0xFF;
      Keyboard.press('d');
      Serial.println("Pressing d");
    }
  }
  else 
  {
    if(fret3State == 0xFF)
    {
      fret3State = 0x00;
      Keyboard.release('d');
      Serial.println("Releasing d");
    }
  }
  
  if(valF4 > threshold) 
  {
    if(fret4State == 0x00)
    {
      fret4State = 0xFF;
      Keyboard.press('f');
      Serial.println("Pressing f");
    }
  }
  else 
  {
    if(fret4State == 0xFF)
    {
      fret4State = 0x00;
      Keyboard.release('f');
      Serial.println("Releasing f");
    }
  }
  
  if(valF5 > threshold) 
  {
    if(fret5State == 0x00)
    {
      fret5State = 0xFF;
      Keyboard.press('g');
      Serial.println("Pressing g");
    }
  }
  else 
  {
    if(fret5State == 0xFF)
    {
      fret5State = 0x00;
      Keyboard.release('g');
      Serial.println("Releasing g");
    }
  }
  
  if(valPick > threshold)
  {
    if(pickState == 0x00)
    {
      pickState = 0xFF;
      Keyboard.press('q');
      Serial.println("Pressing q");
    }
  }
  else 
  {
    if(pickState == 0xFF)
    {
      pickState = 0x00;
      Keyboard.release('q');
      Serial.println("Releasing q");
    }
  }
}

void debug()
{
  Serial.print("ValF1: ");
  Serial.println(valF1);
  
  Serial.print("ValF2: ");
  Serial.println(valF2);  
  
  Serial.print("ValF3: ");
  Serial.println(valF3);
  
  Serial.print("ValF4: ");
  Serial.println(valF4);
  
  Serial.print("ValF5: ");
  Serial.println(valF5);  
  
  Serial.print("ValPick: ");
  Serial.println(valPick);
  
  Serial.println();
}
