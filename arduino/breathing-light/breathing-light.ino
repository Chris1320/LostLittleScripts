#define LED_PIN 3  // LED_PIN should be a PWM
#define DELAY_LEN 50

int brightness_value = 0;
int fading_increment = 5;

void setup() { pinMode(LED_PIN, OUTPUT); }

void loop() {
  analogWrite(LED_PIN, brightness_value);
  brightness_value += fading_increment;  // increment or decrement brightness
                                         // depending on fading value
  delay(DELAY_LEN);  // slow down the loop to allow the user to view the process
  if (brightness_value == 0 || brightness_value == 255)
    fading_increment = -fading_increment;  // invert the value of fading if we
                                           // have reached max value
}
