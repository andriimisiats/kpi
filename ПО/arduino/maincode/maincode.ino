#include <Q2HX711.h>

Q2HX711 hx711(2, 3);

//
unsigned long previousMillis  = 0; 
unsigned long currentMillis   = 0;
unsigned long am = 0;

//
byte state_13                 = LOW;
byte state_7                  = HIGH;
byte pin13                    = 13;
byte pin7                     = 7;

//
String mode                   = "";
String response               = "";
int impulse                   = 0;
int pause                     = 0;

void setup() 
{
    Serial.begin(38400);    
    pinMode(pin13, OUTPUT);
    pinMode(pin7, OUTPUT);
    digitalWrite(pin7, HIGH);
}

void loop() 
{
    if (Serial.available() > 0)
    {
        String input = Serial.readString();
        
        byte index        = input.indexOf(';');
        mode              = input.substring(0, index);
        byte impulseIndex = input.indexOf(';', index + 1);
        impulse           = input.substring(index + 1, impulseIndex).toInt();
        pause             = input.substring(impulseIndex + 1).toInt();
    }
    
    currentMillis = millis();

    if (mode == "impulse")
    {
        if (am == 0)
        {
            am = millis();

            while(500 > millis() - am)
            {
               response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
               Serial.println(response);
            }
        }

       currentMillis = millis();
        if (currentMillis - previousMillis >= impulse)
        {                        
            previousMillis = currentMillis;

            if (state_7 == LOW)
            {
                response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
                Serial.println(response);
                
                state_13  = LOW;
                state_7   = HIGH;

                response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
                Serial.println(response);

                digitalWrite(pin13,  state_13);
                digitalWrite(pin7,   state_7);

                unsigned long pm = millis();

                while(500 > millis() - pm)
                {
                    response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
                    Serial.println(response);
                }
                
                mode = "";
                impulse = 0;
                am = 0;
                
                return;
            }
            
            response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
            Serial.println(response);
        
            state_13  = HIGH;
            state_7   = LOW;

            response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
            Serial.println(response);
            
            digitalWrite(pin13,  state_13);
            digitalWrite(pin7,   state_7);
        }
        else
        {
            response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
            Serial.println(response);
        }
    }
     
    if (mode == "serie")
    { 
        if (currentMillis - previousMillis >= impulse && state_7 == LOW)
        {
            previousMillis = currentMillis;

            response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
            Serial.println(response);

            state_13  = LOW;
            state_7   = HIGH;

            response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
            Serial.println(response);
  
            digitalWrite(pin13,  state_13);
            digitalWrite(pin7,   state_7);
        }
        if (currentMillis - previousMillis >= pause && state_7 == HIGH)
        {
            previousMillis = currentMillis;

            response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
            Serial.println(response);

            state_13  = HIGH;
            state_7   = LOW;

            response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
            Serial.println(response);

            digitalWrite(pin13,  state_13);
            digitalWrite(pin7,   state_7);
        }
        else
        {
            response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
            Serial.println(response);
        }
    } 

    if (mode == "stationary")
    {
        response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
        Serial.println(response);
        
        state_13  = HIGH;
        state_7   = LOW;

        response = (String) hx711.read() + ";" + (String) millis() + ";" + state_7;
        Serial.println(response);
        
        digitalWrite(pin13,  state_13);
        digitalWrite(pin7,   state_7);
    }

    if (mode == "stop")
    {
        state_13  = LOW;
        state_7   = HIGH;

        digitalWrite(pin13,  state_13);
        digitalWrite(pin7,   state_7);
            
        impulse   = 0;
        pause     = 0;
        mode      = "";
            
        return;
    }
}






