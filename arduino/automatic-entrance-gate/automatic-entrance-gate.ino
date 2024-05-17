#include <LiquidCrystal_I2C.h>

#define PIN_BUT 13
#define PIN_BUZ 2
#define PIN_LED_Y 7
#define PIN_LED_R 4

bool door_opened = false;
int button_prev_state = 0;
LiquidCrystal_I2C lcd(0x27, 16, 2);

void setup() {
  pinMode(PIN_BUT, INPUT);
  pinMode(PIN_BUZ, OUTPUT);
  pinMode(PIN_LED_Y, OUTPUT);
  pinMode(PIN_LED_R, OUTPUT);
  lcd.init();
  lcd.backlight();
  Serial.begin(9600);
}

void loop() {
  bool button_pressed = digitalRead(PIN_BUT);
  Serial.println(String(button_pressed) + " | " + String(door_opened));
  if (button_prev_state != button_pressed)
    if (button_pressed) toggleDoorState();
  button_prev_state = button_pressed;
  delay(100);
}

void toggleDoorState() {
  if (door_opened) {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Thank You");
    door_opened = false;
    digitalWrite(PIN_LED_Y, LOW);
    digitalWrite(PIN_LED_R, HIGH);
    alarmTimer(0);
  } else {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("You're Welcome");
    door_opened = true;
    digitalWrite(PIN_LED_Y, HIGH);
    digitalWrite(PIN_LED_R, LOW);
    alarmTimer(1);
  }
}

void alarmTimer(int mode) {
  int total_time = mode == 1 ? 30 : 20;
  for (int i = 0; i < total_time; i++) {
    lcd.setCursor(0, 1);
    int time_remaining = total_time - i;
    lcd.print(time_remaining < 10 ? '0' + String(time_remaining)
                                  : String(time_remaining));
    delay(1000);
  }
  lcd.setCursor(0, 1);
  lcd.print("                ");
  if (mode == 1) {
    tone(PIN_BUZ, 262, 1000);
  } else {
    for (int i = 0; i < 5; i++) {
      tone(PIN_BUZ, 400, 500);
      delay(500);
      tone(PIN_BUZ, 650, 500);
      delay(500);
    }
  }
}
