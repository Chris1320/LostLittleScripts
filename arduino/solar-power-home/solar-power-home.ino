#include <LiquidCrystal_I2C.h>

#define DELAY 250
#define PIN_LDR A0
#define PIN_BUZ 6
#define PIN_LED_B 4
#define PIN_LED_G 2

byte prev_lcd_content = 0;
LiquidCrystal_I2C lcd(0x27, 16, 2);

void setup() {
  pinMode(PIN_LDR, INPUT);
  pinMode(PIN_BUZ, OUTPUT);
  pinMode(PIN_LED_B, OUTPUT);
  pinMode(PIN_LED_G, OUTPUT);
  lcd.init();
  lcd.backlight();
  Serial.begin(9600);
}
void loop() {
  int ldr_value = analogRead(PIN_LDR);

  Serial.println(ldr_value);
  // TODO: What if the value is 601-899?
  if (ldr_value <= 300) {
    if (prev_lcd_content != 1) {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Light and fan");
      lcd.setCursor(0, 1);
      lcd.print("is working");
      prev_lcd_content = 1;
    }
    digitalWrite(PIN_LED_B, HIGH);
    digitalWrite(PIN_LED_G, LOW);
    tone(PIN_BUZ, 462, DELAY);
  } else if (ldr_value <= 600) {
    if (prev_lcd_content != 2) {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Ref and aircon");
      lcd.setCursor(0, 1);
      lcd.print("is working");
      prev_lcd_content = 2;
    }
    digitalWrite(PIN_LED_G, HIGH);
    digitalWrite(PIN_LED_B, LOW);
    noTone(PIN_BUZ);
  } else if (ldr_value >= 900) {
    if (prev_lcd_content != 3) {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Whole house");
      lcd.setCursor(0, 1);
      lcd.print("is solar powered");
      prev_lcd_content = 3;
    }
    digitalWrite(PIN_LED_B, LOW);
    digitalWrite(PIN_LED_G, LOW);
    noTone(PIN_BUZ);
  }
  delay(DELAY);
}
