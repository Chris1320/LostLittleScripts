int BUT_PIN = 1;
int LED_PIN = 4;

void setup() {
  pinMode(BUT_PIN, INPUT);
  pinMode(LED_PIN, OUTPUT);

  Serial.begin(9600);
  Serial.println("Listening for actions...");
}

void loop() {
  if (digitalRead(BUT_PIN) == LOW) {
    digitalWrite(LED_PIN, HIGH);
    Serial.println("Button state: LOW");
  } else {
    digitalWrite(LED_PIN, LOW);
    Serial.println("Button state: HIGH");
  }
}
