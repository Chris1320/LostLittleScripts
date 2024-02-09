#define POT_PIN A0
#define LED_PIN 3

void setup() {
  pinMode(POT_PIN, INPUT);
  pinMode(LED_PIN, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  int pot_val = analogRead(POT_PIN);
  int led_val = map(pot_val, 0, 1023, 0, 255);
  analogWrite(LED_PIN, led_val);
  Serial.print(pot_val);
  Serial.print(" | ");
  Serial.println(led_val);
}
