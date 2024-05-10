/*
 * ITE4: Project #1 Assignment
 *
 * Simulate the project using Tinkercad, make sure to take screenshots the
 * pictures of the diagram and code, and make a video of the output of the
 * project.
 *
 * 1. Potentiometer with 2 control LED lights.
 * 2. Buzzer with 3 LEDs and 3 Buttons.
 */

#define CLOCKSPEED 100  // in milliseconds
#define POT_MIN 0
#define POT_MAX 1023
#define LED_MIN 0
#define LED_MAX 255
// The following decay values should be more than and
// (preferrably) a multiple of CLOCKSPEED.
#define BUZ_DECAY 1000
#define LED_DECAY 3000

// pin assignments for potentiometer and LEDs
#define PIN_POT A0
#define PIN_POT_LED_G 3
#define PIN_POT_LED_R 5

// pin assignments for buzzer, LEDs, and buttons
#define PIN_BUZ 10
#define PIN_BUT1 7
#define PIN_BUT2 8
#define PIN_BUT3 9
#define PIN_LED1 13
#define PIN_LED2 12
#define PIN_LED3 11

// non-zero when they should be active.
int LED1_ACTIVE_TIME_LEFT = 0;
int LED2_ACTIVE_TIME_LEFT = 0;
int LED3_ACTIVE_TIME_LEFT = 0;

void setup() {
  pinMode(PIN_POT, INPUT);
  pinMode(PIN_POT_LED_G, OUTPUT);
  pinMode(PIN_POT_LED_R, OUTPUT);

  Serial.begin(9200);
}

void loop() {
  // Update the values of the potentiometer and its LEDs.
  int pot_val = analogRead(PIN_POT);
  int led_g_val = 255 - map(pot_val, POT_MIN, POT_MAX, LED_MIN, LED_MAX);
  int led_r_val = map(pot_val, POT_MIN, POT_MAX, LED_MIN, LED_MAX);
  bool is_but1_pushed = digitalRead(PIN_BUT1);
  bool is_but2_pushed = digitalRead(PIN_BUT2);
  bool is_but3_pushed = digitalRead(PIN_BUT3);

  // WARN: For debugging only... I know, this is cursed.
  Serial.println(String(is_but1_pushed) + " | " + String(is_but2_pushed) +
                 " | " + String(is_but3_pushed) + " | " + String(pot_val) +
                 " | " + String(led_g_val) + " | " + String(led_r_val) + " | " +
                 String(LED1_ACTIVE_TIME_LEFT) + " | " +
                 String(LED2_ACTIVE_TIME_LEFT) + " | " +
                 String(LED3_ACTIVE_TIME_LEFT));

  if (is_but1_pushed || is_but2_pushed || is_but3_pushed) {
    // determine which LEDs to activate.
    if (is_but1_pushed) {
      LED1_ACTIVE_TIME_LEFT = LED_DECAY;
      tone(PIN_BUZ, 262, BUZ_DECAY);
    }
    if (is_but2_pushed) {
      LED2_ACTIVE_TIME_LEFT = LED_DECAY;
      tone(PIN_BUZ, 330, BUZ_DECAY);
    }
    if (is_but3_pushed) {
      LED3_ACTIVE_TIME_LEFT = LED_DECAY;
      tone(PIN_BUZ, 392, BUZ_DECAY);
    }
  }

  // update the values of the LEDs of the potentiometer.
  analogWrite(PIN_POT_LED_G, led_g_val);
  analogWrite(PIN_POT_LED_R, led_r_val);

  // Check the LEDs for decay.
  if (LED1_ACTIVE_TIME_LEFT > 0) {
    digitalWrite(PIN_LED1, HIGH);
    LED1_ACTIVE_TIME_LEFT -= CLOCKSPEED;
  } else
    digitalWrite(PIN_LED1, LOW);
  if (LED2_ACTIVE_TIME_LEFT > 0) {
    digitalWrite(PIN_LED2, HIGH);
    LED2_ACTIVE_TIME_LEFT -= CLOCKSPEED;
  } else
    digitalWrite(PIN_LED2, LOW);
  if (LED3_ACTIVE_TIME_LEFT > 0) {
    digitalWrite(PIN_LED3, HIGH);
    LED3_ACTIVE_TIME_LEFT -= CLOCKSPEED;
  } else
    digitalWrite(PIN_LED3, LOW);

  delay(CLOCKSPEED);
}
