#include <LiquidCrystal_I2C.h>

#define PIN_POT A0
#define PIN_LED_G 3
#define PIN_LED_Y 4
#define PIN_LED_R 5

int prev_lcd_state = 0;
int fade_effect_strength = 0;
int fade_effect_increment = 51;
LiquidCrystal_I2C lcd(0x27, 16, 2);

void setup() {
  pinMode(PIN_POT, INPUT);
  pinMode(PIN_LED_G, OUTPUT);
  pinMode(PIN_LED_Y, OUTPUT);
  pinMode(PIN_LED_R, OUTPUT);
  lcd.init();
  lcd.backlight();
  Serial.begin(9600);
}

void loop() {
  int pot_val = analogRead(PIN_POT);
  Serial.println(pot_val);
  if (pot_val <= 50) {
    digitalWrite(PIN_LED_G, HIGH);
    digitalWrite(PIN_LED_Y, LOW);
    digitalWrite(PIN_LED_R, LOW);
    if (prev_lcd_state != 1) {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Warming");
      prev_lcd_state = 1;
    }
  } else if (pot_val <= 150) {
    digitalWrite(PIN_LED_G, LOW);
    digitalWrite(PIN_LED_Y, HIGH);
    digitalWrite(PIN_LED_R, LOW);
    if (prev_lcd_state != 2) {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Cooked");
      prev_lcd_state = 2;
    }
  } else {  // >150
    digitalWrite(PIN_LED_G, LOW);
    digitalWrite(PIN_LED_Y, LOW);
    analogWrite(PIN_LED_R, fade_effect_strength);
    if (fade_effect_strength + fade_effect_increment > 255 ||
        fade_effect_strength + fade_effect_increment < 0)
      fade_effect_increment = -fade_effect_increment;
    fade_effect_strength += fade_effect_increment;
    if (prev_lcd_state != 3) {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Overcooked");
      prev_lcd_state = 3;
    }
  }
  delay(100);
}
