// LEDs are on pins 1 to 8.
#define LED_PIN_START 1
#define LED_PIN_END 8
#define DELAY_LENGTH 1000 // in milliseconds

void setup()
{
    for (int pin_number = LED_PIN_START; pin_number <= LED_PIN_END; pin_number++)
        pinMode(pin_number, OUTPUT); // set up all LEDs
}

// Turn on all odd-numbered LEDs
void onOddNumbers()
{
    for (int i = LED_PIN_START; i <= LED_PIN_END; i++)
        digitalWrite(i, i % 2 == 0 ? LOW : HIGH);
}

// Turn on all even-numbered LEDs
void onEvenNumbers()
{
    for (int i = LED_PIN_START; i <= LED_PIN_END; i++)
        digitalWrite(i, i % 2 == 0 ? HIGH : LOW);
}

// Turn off all LEDs
void offAllNumbers()
{
    for (int i = LED_PIN_START; i <= LED_PIN_END; i++)
        digitalWrite(i, LOW);
}

void strobeLights()
{
    // Turn on LEDs one-by-one.
    for (int active_led = LED_PIN_START; active_led <= LED_PIN_END; active_led++)
    {
        // Turn on only the active LED
        for (int i = LED_PIN_START; i <= LED_PIN_END; i++)
            digitalWrite(i, i == active_led ? HIGH : LOW);

        delay(100);
    }
}

void blinkLights()
{
    int decrement = 100;
    int current_delay = DELAY_LENGTH;
    bool led_is_on = false;

    while (current_delay > 0)
    {
        for (int i = LED_PIN_START; i <= LED_PIN_END; i++)
            digitalWrite(i, led_is_on ? HIGH : LOW);

        delay(decrement);
        led_is_on = !led_is_on;
        current_delay -= decrement; // subtract the time taken from the current delay
    }
}

void loop()
{
    onOddNumbers();
    delay(DELAY_LENGTH);

    onEvenNumbers();
    delay(DELAY_LENGTH);

    offAllNumbers();
    delay(DELAY_LENGTH);

    strobeLights();
    delay(DELAY_LENGTH);

    offAllNumbers();
    delay(DELAY_LENGTH);

    blinkLights();
    delay(DELAY_LENGTH);
}