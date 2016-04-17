#include <frequencyToNote.h>
#include <MIDIUSB.h>
#include <pitchToNote.h>

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
}

void loop()
{ 
  valF1 = fret1.capacitiveSensor(12);
  valF2 = fret2.capacitiveSensor(12);
  valF3 = fret3.capacitiveSensor(12);
  valF4 = fret4.capacitiveSensor(12);
  valF5 = fret5.capacitiveSensor(12);
  valPick = pick.capacitiveSensor(12);
  
  trigger(); 
  MidiUSB.flush();
  
  //debug();
}

void trigger()
{
  if(valF1 > threshold) 
  {
    if(fret1State == 0x00)
    {
      fret1State = 0xFF;
      noteOn(0, 50, 64);
    }
  }
  else 
  {
    if(fret1State == 0xFF)
    {
      fret1State = 0x00;  
      noteOff(0, 50, 0);
    }
  }
  
  if(valF2 > threshold) 
  {
    if(fret2State == 0x00)
    {
      fret2State = 0xFF;
      noteOn(0, 52, 64);
    }
  }
  else 
  {
    if(fret2State == 0xFF)
    {
      fret2State = 0x00;
      noteOff(0, 52, 0);
    }
  }
  
  if(valF3 > threshold) 
  {
    if(fret3State == 0x00)
    {
      fret3State = 0xFF;
      noteOn(0, 53, 64);
    }
  }
  else 
  {
    if(fret3State == 0xFF)
    {
      fret3State = 0x00;
      noteOff(0, 53, 0);
    }
  }
  
  if(valF4 > threshold) 
  {
    if(fret4State == 0x00)
    {
      fret4State = 0xFF;
      noteOn(0, 55, 64);
    }
  }
  else 
  {
    if(fret4State == 0xFF)
    {
      fret4State = 0x00;
      noteOff(0, 55, 0);
    }
  }
  
  if(valF5 > threshold) 
  {
    if(fret5State == 0x00)
    {
      fret5State = 0xFF;
      noteOn(0, 57, 64);
    }
  }
  else 
  {
    if(fret5State == 0xFF)
    {
      fret5State = 0x00;
      noteOff(0, 57, 0);
    }
  }
  
  if(valPick > threshold)
  {
    if(pickState == 0x00)
    {
      pickState = 0xFF;
      noteOn(0, 48, 64);
    }
  }
  else 
  {
    if(pickState == 0xFF)
    {
      pickState = 0x00;
      noteOff(0, 48, 0);
    }
  }
}

void noteOn(byte channel, byte pitch, byte velocity) {
  midiEventPacket_t noteOn = {0x09, 0x90 | channel, pitch, velocity};
  MidiUSB.sendMIDI(noteOn);
}

void noteOff(byte channel, byte pitch, byte velocity) {
  midiEventPacket_t noteOff = {0x08, 0x80 | channel, pitch, velocity};
  MidiUSB.sendMIDI(noteOff);
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
