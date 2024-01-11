// Where the LEDs are connected to.
#define GREEN_LED_PIN 8
#define YELLOW_LED_PIN 9
#define RED_LED_PIN 10

// REFACTOR: can these be in an enum instead?
#define STATE_OFF 0
#define STATE_GREEN 1
#define STATE_YELLOW 2
#define STATE_RED 3

void setup()
{
    pinMode(GREEN_LED_PIN, OUTPUT);
    pinMode(YELLOW_LED_PIN, OUTPUT);
    pinMode(RED_LED_PIN, OUTPUT);
}

/*
 * Set the currently active light.
 * If the parameter is invalid, turn off all lights.
 */
void setActiveLight(int light)
{
    switch (light)
    {
    case STATE_GREEN:
        digitalWrite(GREEN_LED_PIN, HIGH);
        digitalWrite(YELLOW_LED_PIN, LOW);
        digitalWrite(RED_LED_PIN, LOW);
        break;

    case STATE_YELLOW:
        digitalWrite(GREEN_LED_PIN, LOW);
        digitalWrite(YELLOW_LED_PIN, HIGH);
        digitalWrite(RED_LED_PIN, LOW);
        break;

    case STATE_RED:
        digitalWrite(GREEN_LED_PIN, LOW);
        digitalWrite(YELLOW_LED_PIN, LOW);
        digitalWrite(RED_LED_PIN, HIGH);
        break;

    default:
        digitalWrite(GREEN_LED_PIN, LOW);
        digitalWrite(YELLOW_LED_PIN, LOW);
        digitalWrite(RED_LED_PIN, LOW);
        break;
    }
}

void setBlinkingLight(int light, int milliseconds)
{
    int delay_length = 500;

    while (milliseconds > 0) // Blink selected light
    {
        setActiveLight(light);
        delay(delay_length);
        setActiveLight(STATE_OFF);
        delay(delay_length);

        milliseconds -= delay_length * 2;
    }
}

void loop()
{
    setActiveLight(STATE_GREEN); // Green for five seconds.
    delay(5000);
    setBlinkingLight(STATE_YELLOW, 5000); // Blink yellow for five seconds.
    setActiveLight(STATE_RED);            // Red of five seconds.
    delay(5000);
    setBlinkingLight(STATE_YELLOW, 5000); // Blink yellow for five seconds.
}
