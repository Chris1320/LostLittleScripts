int BUT_PIN = 1;
int LED_PIN = 4;

void setup() {
    pinMode(BUT_PIN, INPUT);
    pinMode(LED_PIN, OUTPUT);
}
void loop() {
    if (digitalRead(BUT_PIN) == LOW) {
        digitalWrite(LED_PIN, HIGH);
    }
    else digitalWrite(LED_PIN, LOW);
}