/*
 * This program will blink LEDs A and B in an alternating pattern,
 * with an increase in speed on every loop.
 */

#define PIN_NUMBER_A 2            // LED Positive is connected to PIN 2
#define PIN_NUMBER_B 4            // LED Positive is connected to PIN 4
#define MIN_LOOP_DELAY 50         // Stop the loop when LOOP_DELAY is lower than this
#define REDUCTION_PERCENTAGE 0.90 // reduce LOOP_DELAY by 90%

int LOOP_DELAY = 3000; // milliseconds

void setup()
{
    // put your setup code here, to run once:
    pinMode(PIN_NUMBER_A, OUTPUT);
    pinMode(PIN_NUMBER_B, OUTPUT);

    // Turn on the LED 2 at first
    digitalWrite(PIN_NUMBER_B, HIGH);
}

void loop()
{
    // toggle LEDs
    digitalWrite(PIN_NUMBER_A, digitalRead(PIN_NUMBER_A) == HIGH ? LOW : HIGH);
    digitalWrite(PIN_NUMBER_B, digitalRead(PIN_NUMBER_B) == HIGH ? LOW : HIGH);
    delay(LOOP_DELAY);
    LOOP_DELAY *= REDUCTION_PERCENTAGE;

    // Stop the loop if done
    if (LOOP_DELAY < MIN_LOOP_DELAY)
        return;
}
